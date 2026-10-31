using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;

/// <summary>
/// Acceso a datos de usuarios sobre las tablas
/// dbo.Usuarios, dbo.Credenciales, dbo.Generos y dbo.TiposUsuario.
/// </summary>
public static class UsuarioRepositorio
{
    private const string SelectBase = @"
SELECT u.IdUsuario,
       u.Nombre,
       u.Apellido,
       u.Dni,
       u.Telefono,
       u.Email,
       u.Domicilio,
       g.Nombre AS Genero,
       u.FechaNacimiento,
       t.Nombre AS TipoUsuario,
       u.PrimerIngreso,
       c.IdCredencial,
       c.NombreUsuario,
       c.Contrasena
FROM dbo.Usuarios u
INNER JOIN dbo.Generos g ON g.IdGenero = u.IdGenero
INNER JOIN dbo.TiposUsuario t ON t.IdTipoUsuario = u.IdTipoUsuario
INNER JOIN dbo.Credenciales c ON c.IdUsuario = u.IdUsuario";

    /// <summary>
    /// Devuelve el usuario si el nombre de usuario y la contraseña coinciden; si no, null.
    /// El nombre de usuario se compara sin distinguir mayúsculas.
    /// </summary>
    public static Usuario? ValidarCredenciales(string nombreUsuario, string contrasena)
    {
        string sql = SelectBase + @"
WHERE UPPER(c.NombreUsuario) = UPPER(@NombreUsuario)
  AND c.Contrasena = @Contrasena";

        using (SqlConnection cn = ConexionDB.AbrirConexion())
        using (SqlCommand cmd = new SqlCommand(sql, cn))
        {
            Agregar(cmd, "@NombreUsuario", SqlDbType.VarChar, nombreUsuario, 50);
            Agregar(cmd, "@Contrasena", SqlDbType.VarChar, contrasena, 255);

            using (SqlDataReader reader = cmd.ExecuteReader())
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
WHERE UPPER(c.NombreUsuario) = UPPER(@NombreUsuario)";

        using (SqlConnection cn = ConexionDB.AbrirConexion())
        using (SqlCommand cmd = new SqlCommand(sql, cn))
        {
            Agregar(cmd, "@NombreUsuario", SqlDbType.VarChar, nombreUsuario, 50);

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                return reader.Read() ? Mapear(reader) : null;
            }
        }
    }

    public static List<Usuario> ObtenerTodos()
    {
        string sql = SelectBase + " ORDER BY u.Apellido, u.Nombre";

        List<Usuario> usuarios = new List<Usuario>();

        using (SqlConnection cn = ConexionDB.AbrirConexion())
        using (SqlCommand cmd = new SqlCommand(sql, cn))
        using (SqlDataReader reader = cmd.ExecuteReader())
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
FROM dbo.Credenciales
WHERE UPPER(NombreUsuario) = UPPER(@NombreUsuario)";

        using (SqlConnection cn = ConexionDB.AbrirConexion())
        using (SqlCommand cmd = new SqlCommand(sql, cn))
        {
            Agregar(cmd, "@NombreUsuario", SqlDbType.VarChar, nombreUsuario, 50);

            return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
        }
    }

    public static bool ExisteDni(string dni)
    {
        const string sql = "SELECT COUNT(*) FROM dbo.Usuarios WHERE Dni = @Dni";

        using (SqlConnection cn = ConexionDB.AbrirConexion())
        using (SqlCommand cmd = new SqlCommand(sql, cn))
        {
            Agregar(cmd, "@Dni", SqlDbType.VarChar, dni, 20);

            return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
        }
    }

    /// <summary>
    /// Inserta el usuario y su credencial en una sola transacción.
    /// Devuelve el IdUsuario generado.
    /// </summary>
    public static int Insertar(Usuario usuario)
    {
        using (SqlConnection cn = ConexionDB.AbrirConexion())
        using (SqlTransaction tx = cn.BeginTransaction())
        {
            try
            {
                int idGenero = ObtenerId(cn, tx, "dbo.Generos", "IdGenero", usuario.Genero);
                int idTipoUsuario = ObtenerId(cn, tx, "dbo.TiposUsuario", "IdTipoUsuario", usuario.TipoUsuario);

                const string sqlUsuario = @"
INSERT INTO dbo.Usuarios
    (Nombre, Apellido, Dni, Telefono, Email, Domicilio, IdGenero, FechaNacimiento, IdTipoUsuario, PrimerIngreso)
OUTPUT INSERTED.IdUsuario
VALUES
    (@Nombre, @Apellido, @Dni, @Telefono, @Email, @Domicilio, @IdGenero, @FechaNacimiento, @IdTipoUsuario, @PrimerIngreso);";

                using (SqlCommand cmd = new SqlCommand(sqlUsuario, cn, tx))
                {
                    Agregar(cmd, "@Nombre", SqlDbType.VarChar, usuario.Nombre, 50);
                    Agregar(cmd, "@Apellido", SqlDbType.VarChar, usuario.Apellido, 50);
                    Agregar(cmd, "@Dni", SqlDbType.VarChar, usuario.Dni, 20);
                    Agregar(cmd, "@Telefono", SqlDbType.VarChar, usuario.Telefono, 20);
                    Agregar(cmd, "@Email", SqlDbType.VarChar, usuario.Email, 100);
                    Agregar(cmd, "@Domicilio", SqlDbType.VarChar, usuario.Domicilio, 200);
                    Agregar(cmd, "@IdGenero", SqlDbType.Int, idGenero);
                    Agregar(cmd, "@FechaNacimiento", SqlDbType.Date, usuario.FechaNacimiento.Date);
                    Agregar(cmd, "@IdTipoUsuario", SqlDbType.Int, idTipoUsuario);
                    Agregar(cmd, "@PrimerIngreso", SqlDbType.Bit, usuario.PrimerIngreso);

                    usuario.IdUsuario = Convert.ToInt32(cmd.ExecuteScalar());
                }

                const string sqlCredencial = @"
INSERT INTO dbo.Credenciales (IdUsuario, NombreUsuario, Contrasena)
OUTPUT INSERTED.IdCredencial
VALUES (@IdUsuario, @NombreUsuario, @Contrasena);";

                using (SqlCommand cmd = new SqlCommand(sqlCredencial, cn, tx))
                {
                    Agregar(cmd, "@IdUsuario", SqlDbType.Int, usuario.IdUsuario);
                    Agregar(cmd, "@NombreUsuario", SqlDbType.VarChar, usuario.NombreUsuario, 50);
                    Agregar(cmd, "@Contrasena", SqlDbType.VarChar, usuario.Contrasena, 255);

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
        using (SqlConnection cn = ConexionDB.AbrirConexion())
        using (SqlTransaction tx = cn.BeginTransaction())
        {
            try
            {
                int idGenero = ObtenerId(cn, tx, "dbo.Generos", "IdGenero", usuario.Genero);
                int idTipoUsuario = ObtenerId(cn, tx, "dbo.TiposUsuario", "IdTipoUsuario", usuario.TipoUsuario);

                const string sql = @"
UPDATE dbo.Usuarios
SET Nombre = @Nombre,
    Apellido = @Apellido,
    Telefono = @Telefono,
    Email = @Email,
    Domicilio = @Domicilio,
    IdGenero = @IdGenero,
    FechaNacimiento = @FechaNacimiento,
    IdTipoUsuario = @IdTipoUsuario
WHERE IdUsuario = @IdUsuario;";

                using (SqlCommand cmd = new SqlCommand(sql, cn, tx))
                {
                    Agregar(cmd, "@Nombre", SqlDbType.VarChar, usuario.Nombre, 50);
                    Agregar(cmd, "@Apellido", SqlDbType.VarChar, usuario.Apellido, 50);
                    Agregar(cmd, "@Telefono", SqlDbType.VarChar, usuario.Telefono, 20);
                    Agregar(cmd, "@Email", SqlDbType.VarChar, usuario.Email, 100);
                    Agregar(cmd, "@Domicilio", SqlDbType.VarChar, usuario.Domicilio, 200);
                    Agregar(cmd, "@IdGenero", SqlDbType.Int, idGenero);
                    Agregar(cmd, "@FechaNacimiento", SqlDbType.Date, usuario.FechaNacimiento.Date);
                    Agregar(cmd, "@IdTipoUsuario", SqlDbType.Int, idTipoUsuario);
                    Agregar(cmd, "@IdUsuario", SqlDbType.Int, usuario.IdUsuario);

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
    /// La contraseña está en dbo.Credenciales y el flag en dbo.Usuarios,
    /// por eso se actualizan las dos tablas en una transacción.
    /// </summary>
    public static void ActualizarContrasena(int idUsuario, string contrasena, bool primerIngreso)
    {
        using (SqlConnection cn = ConexionDB.AbrirConexion())
        using (SqlTransaction tx = cn.BeginTransaction())
        {
            try
            {
                const string sqlCredencial = @"
UPDATE dbo.Credenciales
SET Contrasena = @Contrasena
WHERE IdUsuario = @IdUsuario;";

                using (SqlCommand cmd = new SqlCommand(sqlCredencial, cn, tx))
                {
                    Agregar(cmd, "@Contrasena", SqlDbType.VarChar, contrasena, 255);
                    Agregar(cmd, "@IdUsuario", SqlDbType.Int, idUsuario);

                    if (cmd.ExecuteNonQuery() == 0)
                    {
                        throw new InvalidOperationException(
                            "No se encontró la credencial del usuario en la base de datos.");
                    }
                }

                const string sqlUsuario = @"
UPDATE dbo.Usuarios
SET PrimerIngreso = @PrimerIngreso
WHERE IdUsuario = @IdUsuario;";

                using (SqlCommand cmd = new SqlCommand(sqlUsuario, cn, tx))
                {
                    Agregar(cmd, "@PrimerIngreso", SqlDbType.Bit, primerIngreso);
                    Agregar(cmd, "@IdUsuario", SqlDbType.Int, idUsuario);

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
        SqlConnection cn,
        SqlTransaction tx,
        string tabla,
        string columnaId,
        string valor)
    {
        string sql = $"SELECT {columnaId} FROM {tabla} WHERE Nombre = @Valor";

        using (SqlCommand cmd = new SqlCommand(sql, cn, tx))
        {
            Agregar(cmd, "@Valor", SqlDbType.VarChar, valor, 30);

            object? resultado = cmd.ExecuteScalar();

            if (resultado == null || resultado == DBNull.Value)
            {
                throw new InvalidOperationException(
                    $"No existe '{valor}' en la tabla {tabla}.");
            }

            return Convert.ToInt32(resultado);
        }
    }

    private static Usuario Mapear(SqlDataReader reader)
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

    private static string LeerTextoOpcional(SqlDataReader reader, string columna)
    {
        int indice = reader.GetOrdinal(columna);

        return reader.IsDBNull(indice) ? string.Empty : reader.GetString(indice);
    }

    private static void Agregar(
        SqlCommand cmd,
        string nombre,
        SqlDbType tipo,
        object? valor,
        int tamano = 0)
    {
        SqlParameter parametro = tamano > 0
            ? new SqlParameter(nombre, tipo, tamano)
            : new SqlParameter(nombre, tipo);

        parametro.Value = valor ?? DBNull.Value;
        cmd.Parameters.Add(parametro);
    }
}
