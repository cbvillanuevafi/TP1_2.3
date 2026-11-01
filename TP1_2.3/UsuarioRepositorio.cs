using System;
using System.Collections.Generic;
using Npgsql;
using NpgsqlTypes;

/// <summary>
/// Acceso a datos de usuarios sobre las tablas
/// usuarios, credenciales, generos y tipos_usuario (PostgreSQL / Neon).
/// </summary>
public static class UsuarioRepositorio
{
    private const string SelectBase = @"
SELECT u.id_usuario       AS ""IdUsuario"",
       u.nombre           AS ""Nombre"",
       u.apellido         AS ""Apellido"",
       u.dni              AS ""Dni"",
       u.telefono         AS ""Telefono"",
       u.email            AS ""Email"",
       u.domicilio        AS ""Domicilio"",
       g.nombre           AS ""Genero"",
       u.fecha_nacimiento AS ""FechaNacimiento"",
       t.nombre           AS ""TipoUsuario"",
       u.primer_ingreso   AS ""PrimerIngreso"",
       c.id_credencial    AS ""IdCredencial"",
       c.nombre_usuario   AS ""NombreUsuario"",
       c.contrasena       AS ""Contrasena""
FROM usuarios u
INNER JOIN generos g ON g.id_genero = u.id_genero
INNER JOIN tipos_usuario t ON t.id_tipo_usuario = u.id_tipo_usuario
INNER JOIN credenciales c ON c.id_usuario = u.id_usuario";

    /// <summary>
    /// Devuelve el usuario si el nombre de usuario y la contraseña coinciden; si no, null.
    /// El nombre de usuario se compara sin distinguir mayúsculas.
    /// </summary>
    public static Usuario? ValidarCredenciales(string nombreUsuario, string contrasena)
    {
        string sql = SelectBase + @"
WHERE UPPER(c.nombre_usuario) = UPPER(@NombreUsuario)
  AND c.contrasena = @Contrasena";

        using (NpgsqlConnection cn = ConexionDB.AbrirConexion())
        using (NpgsqlCommand cmd = new NpgsqlCommand(sql, cn))
        {
            Agregar(cmd, "@NombreUsuario", NpgsqlDbType.Varchar, nombreUsuario, 50);
            Agregar(cmd, "@Contrasena", NpgsqlDbType.Varchar, contrasena, 255);

            using (NpgsqlDataReader reader = cmd.ExecuteReader())
            {
                return reader.Read() ? Mapear(reader) : null;
            }
        }
    }

    /// <summary>
    /// Busca un usuario por nombre de usuario (sin distinguir mayúsculas).
    /// </summary>
    public static Usuario? BuscarPorNombreUsuario(string nombreUsuario)
    {
        string sql = SelectBase + @"
WHERE UPPER(c.nombre_usuario) = UPPER(@NombreUsuario)";

        using (NpgsqlConnection cn = ConexionDB.AbrirConexion())
        using (NpgsqlCommand cmd = new NpgsqlCommand(sql, cn))
        {
            Agregar(cmd, "@NombreUsuario", NpgsqlDbType.Varchar, nombreUsuario, 50);

            using (NpgsqlDataReader reader = cmd.ExecuteReader())
            {
                return reader.Read() ? Mapear(reader) : null;
            }
        }
    }

    public static List<Usuario> ObtenerTodos()
    {
        string sql = SelectBase + " ORDER BY u.apellido, u.nombre";

        List<Usuario> usuarios = new List<Usuario>();

        using (NpgsqlConnection cn = ConexionDB.AbrirConexion())
        using (NpgsqlCommand cmd = new NpgsqlCommand(sql, cn))
        using (NpgsqlDataReader reader = cmd.ExecuteReader())
        {
            while (reader.Read())
            {
                usuarios.Add(Mapear(reader));
            }
        }

        return usuarios;
    }

    public static bool ExisteNombreUsuario(string nombreUsuario)
    {
        const string sql = @"
SELECT COUNT(*)
FROM credenciales
WHERE UPPER(nombre_usuario) = UPPER(@NombreUsuario)";

        using (NpgsqlConnection cn = ConexionDB.AbrirConexion())
        using (NpgsqlCommand cmd = new NpgsqlCommand(sql, cn))
        {
            Agregar(cmd, "@NombreUsuario", NpgsqlDbType.Varchar, nombreUsuario, 50);

            return Convert.ToInt64(cmd.ExecuteScalar()) > 0;
        }
    }

    public static bool ExisteDni(string dni)
    {
        const string sql = "SELECT COUNT(*) FROM usuarios WHERE dni = @Dni";

        using (NpgsqlConnection cn = ConexionDB.AbrirConexion())
        using (NpgsqlCommand cmd = new NpgsqlCommand(sql, cn))
        {
            Agregar(cmd, "@Dni", NpgsqlDbType.Varchar, dni, 20);

            return Convert.ToInt64(cmd.ExecuteScalar()) > 0;
        }
    }

    /// <summary>
    /// Inserta el usuario y su credencial en una sola transacción.
    /// Devuelve el IdUsuario generado.
    /// </summary>
    public static int Insertar(Usuario usuario)
    {
        using (NpgsqlConnection cn = ConexionDB.AbrirConexion())
        using (NpgsqlTransaction tx = cn.BeginTransaction())
        {
            try
            {
                int idGenero = ObtenerId(cn, tx, "generos", "id_genero", usuario.Genero);
                int idTipoUsuario = ObtenerId(
                    cn, tx, "tipos_usuario", "id_tipo_usuario", usuario.TipoUsuario);

                const string sqlUsuario = @"
INSERT INTO usuarios
    (nombre, apellido, dni, telefono, email, domicilio,
     id_genero, fecha_nacimiento, id_tipo_usuario, primer_ingreso)
VALUES
    (@Nombre, @Apellido, @Dni, @Telefono, @Email, @Domicilio,
     @IdGenero, @FechaNacimiento, @IdTipoUsuario, @PrimerIngreso)
RETURNING id_usuario";

                using (NpgsqlCommand cmd = new NpgsqlCommand(sqlUsuario, cn, tx))
                {
                    Agregar(cmd, "@Nombre", NpgsqlDbType.Varchar, usuario.Nombre, 50);
                    Agregar(cmd, "@Apellido", NpgsqlDbType.Varchar, usuario.Apellido, 50);
                    Agregar(cmd, "@Dni", NpgsqlDbType.Varchar, usuario.Dni, 20);
                    Agregar(cmd, "@Telefono", NpgsqlDbType.Varchar, usuario.Telefono, 20);
                    Agregar(cmd, "@Email", NpgsqlDbType.Varchar, usuario.Email, 100);
                    Agregar(cmd, "@Domicilio", NpgsqlDbType.Varchar, usuario.Domicilio, 200);
                    Agregar(cmd, "@IdGenero", NpgsqlDbType.Integer, idGenero);
                    Agregar(cmd, "@FechaNacimiento", NpgsqlDbType.Date, AFecha(usuario.FechaNacimiento));
                    Agregar(cmd, "@IdTipoUsuario", NpgsqlDbType.Integer, idTipoUsuario);
                    Agregar(cmd, "@PrimerIngreso", NpgsqlDbType.Boolean, usuario.PrimerIngreso);

                    usuario.IdUsuario = Convert.ToInt32(cmd.ExecuteScalar());
                }

                const string sqlCredencial = @"
INSERT INTO credenciales (id_usuario, nombre_usuario, contrasena)
VALUES (@IdUsuario, @NombreUsuario, @Contrasena)
RETURNING id_credencial";

                using (NpgsqlCommand cmd = new NpgsqlCommand(sqlCredencial, cn, tx))
                {
                    Agregar(cmd, "@IdUsuario", NpgsqlDbType.Integer, usuario.IdUsuario);
                    Agregar(cmd, "@NombreUsuario", NpgsqlDbType.Varchar, usuario.NombreUsuario, 50);
                    Agregar(cmd, "@Contrasena", NpgsqlDbType.Varchar, usuario.Contrasena, 255);

                    usuario.IdCredencial = Convert.ToInt32(cmd.ExecuteScalar());
                }

                tx.Commit();
                return usuario.IdUsuario;
            }
            catch
            {
                tx.Rollback();
                throw;
            }
        }
    }

    /// <summary>
    /// Actualiza los datos personales del usuario (el DNI no se modifica).
    /// </summary>
    public static void ActualizarPerfil(Usuario usuario)
    {
        using (NpgsqlConnection cn = ConexionDB.AbrirConexion())
        using (NpgsqlTransaction tx = cn.BeginTransaction())
        {
            try
            {
                int idGenero = ObtenerId(cn, tx, "generos", "id_genero", usuario.Genero);
                int idTipoUsuario = ObtenerId(
                    cn, tx, "tipos_usuario", "id_tipo_usuario", usuario.TipoUsuario);

                const string sql = @"
UPDATE usuarios
SET nombre = @Nombre,
    apellido = @Apellido,
    telefono = @Telefono,
    email = @Email,
    domicilio = @Domicilio,
    id_genero = @IdGenero,
    fecha_nacimiento = @FechaNacimiento,
    id_tipo_usuario = @IdTipoUsuario
WHERE id_usuario = @IdUsuario";

                using (NpgsqlCommand cmd = new NpgsqlCommand(sql, cn, tx))
                {
                    Agregar(cmd, "@Nombre", NpgsqlDbType.Varchar, usuario.Nombre, 50);
                    Agregar(cmd, "@Apellido", NpgsqlDbType.Varchar, usuario.Apellido, 50);
                    Agregar(cmd, "@Telefono", NpgsqlDbType.Varchar, usuario.Telefono, 20);
                    Agregar(cmd, "@Email", NpgsqlDbType.Varchar, usuario.Email, 100);
                    Agregar(cmd, "@Domicilio", NpgsqlDbType.Varchar, usuario.Domicilio, 200);
                    Agregar(cmd, "@IdGenero", NpgsqlDbType.Integer, idGenero);
                    Agregar(cmd, "@FechaNacimiento", NpgsqlDbType.Date, AFecha(usuario.FechaNacimiento));
                    Agregar(cmd, "@IdTipoUsuario", NpgsqlDbType.Integer, idTipoUsuario);
                    Agregar(cmd, "@IdUsuario", NpgsqlDbType.Integer, usuario.IdUsuario);

                    if (cmd.ExecuteNonQuery() == 0)
                    {
                        throw new InvalidOperationException(
                            "El usuario ya no existe en la base de datos.");
                    }
                }

                tx.Commit();
            }
            catch
            {
                tx.Rollback();
                throw;
            }
        }
    }

    /// <summary>
    /// Cambia la contraseña y el flag de primer ingreso.
    /// La contraseña está en credenciales y el flag en usuarios,
    /// por eso se actualizan las dos tablas en una transacción.
    /// </summary>
    public static void ActualizarContrasena(int idUsuario, string contrasena, bool primerIngreso)
    {
        using (NpgsqlConnection cn = ConexionDB.AbrirConexion())
        using (NpgsqlTransaction tx = cn.BeginTransaction())
        {
            try
            {
                const string sqlCredencial = @"
UPDATE credenciales
SET contrasena = @Contrasena
WHERE id_usuario = @IdUsuario";

                using (NpgsqlCommand cmd = new NpgsqlCommand(sqlCredencial, cn, tx))
                {
                    Agregar(cmd, "@Contrasena", NpgsqlDbType.Varchar, contrasena, 255);
                    Agregar(cmd, "@IdUsuario", NpgsqlDbType.Integer, idUsuario);

                    if (cmd.ExecuteNonQuery() == 0)
                    {
                        throw new InvalidOperationException(
                            "No se encontró la credencial del usuario en la base de datos.");
                    }
                }

                const string sqlUsuario = @"
UPDATE usuarios
SET primer_ingreso = @PrimerIngreso
WHERE id_usuario = @IdUsuario";

                using (NpgsqlCommand cmd = new NpgsqlCommand(sqlUsuario, cn, tx))
                {
                    Agregar(cmd, "@PrimerIngreso", NpgsqlDbType.Boolean, primerIngreso);
                    Agregar(cmd, "@IdUsuario", NpgsqlDbType.Integer, idUsuario);

                    cmd.ExecuteNonQuery();
                }

                tx.Commit();
            }
            catch
            {
                tx.Rollback();
                throw;
            }
        }
    }

    private static int ObtenerId(
        NpgsqlConnection cn,
        NpgsqlTransaction tx,
        string tabla,
        string columnaId,
        string valor)
    {
        string sql = $"SELECT {columnaId} FROM {tabla} WHERE nombre = @Valor";

        using (NpgsqlCommand cmd = new NpgsqlCommand(sql, cn, tx))
        {
            Agregar(cmd, "@Valor", NpgsqlDbType.Varchar, valor, 30);

            object? resultado = cmd.ExecuteScalar();

            if (resultado == null || resultado == DBNull.Value)
            {
                throw new InvalidOperationException(
                    $"No existe '{valor}' en la tabla {tabla}.");
            }

            return Convert.ToInt32(resultado);
        }
    }

    private static Usuario Mapear(NpgsqlDataReader reader)
    {
        return new Usuario
        {
            IdUsuario = reader.GetInt32(reader.GetOrdinal("IdUsuario")),
            Nombre = reader.GetString(reader.GetOrdinal("Nombre")),
            Apellido = reader.GetString(reader.GetOrdinal("Apellido")),
            Dni = reader.GetString(reader.GetOrdinal("Dni")),
            Telefono = LeerTextoOpcional(reader, "Telefono"),
            Email = reader.GetString(reader.GetOrdinal("Email")),
            Domicilio = LeerTextoOpcional(reader, "Domicilio"),
            Genero = reader.GetString(reader.GetOrdinal("Genero")),
            FechaNacimiento = reader.GetDateTime(reader.GetOrdinal("FechaNacimiento")),
            TipoUsuario = reader.GetString(reader.GetOrdinal("TipoUsuario")),
            PrimerIngreso = reader.GetBoolean(reader.GetOrdinal("PrimerIngreso")),
            IdCredencial = reader.GetInt32(reader.GetOrdinal("IdCredencial")),
            NombreUsuario = reader.GetString(reader.GetOrdinal("NombreUsuario")),
            Contrasena = reader.GetString(reader.GetOrdinal("Contrasena"))
        };
    }

    private static string LeerTextoOpcional(NpgsqlDataReader reader, string columna)
    {
        int indice = reader.GetOrdinal(columna);

        return reader.IsDBNull(indice) ? string.Empty : reader.GetString(indice);
    }

    /// <summary>
    /// Npgsql exige DateTimeKind.Unspecified para columnas date/timestamp
    /// sin zona horaria. DateTime.Today viene como Local, así que lo ajustamos.
    /// </summary>
    private static DateTime AFecha(DateTime fecha)
    {
        return DateTime.SpecifyKind(fecha.Date, DateTimeKind.Unspecified);
    }

    private static void Agregar(
        NpgsqlCommand cmd,
        string nombre,
        NpgsqlDbType tipo,
        object? valor,
        int tamano = 0)
    {
        NpgsqlParameter parametro = tamano > 0
            ? new NpgsqlParameter(nombre, tipo, tamano)
            : new NpgsqlParameter(nombre, tipo);

        parametro.Value = valor ?? DBNull.Value;
        cmd.Parameters.Add(parametro);
    }
}
