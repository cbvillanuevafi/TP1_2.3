using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

public static class AccesoDatos
{
    private const string Columnas =
        "IdUsuario, Nombre, Apellido, Dni, Telefono, Email, Genero, " +
        "FechaNacimiento, NombreUsuario, Contrasena, TipoUsuario, PrimerIngreso";

    public static Usuario ObtenerUsuarioPorCredenciales(string nombreUsuario, string contrasena)
    {
        try
        {
            using (SqlConnection conexion = ConexionDB.ObtenerConexion())
            {
                string consulta =
                    "SELECT " + Columnas + " FROM dbo.Usuarios " +
                    "WHERE NombreUsuario = @nombreUsuario AND Contrasena = @contrasena";

                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);
                    comando.Parameters.AddWithValue("@contrasena", contrasena);

                    using (SqlDataReader lector = comando.ExecuteReader())
                    {
                        if (lector.Read())
                            return LeerUsuario(lector);

                        return null;
                    }
                }
            }
        }
        catch (SqlException ex)
        {
            MessageBox.Show(
                "Error al consultar el usuario: " + ex.Message,
                "Error de base de datos",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            return null;
        }
    }

    public static bool ExisteUsuario(string nombreUsuario)
    {
        try
        {
            using (SqlConnection conexion = ConexionDB.ObtenerConexion())
            {
                string consulta =
                    "SELECT COUNT(1) FROM dbo.Usuarios WHERE NombreUsuario = @nombreUsuario";

                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);

                    return Convert.ToInt32(comando.ExecuteScalar()) > 0;
                }
            }
        }
        catch (SqlException ex)
        {
            MessageBox.Show(
                "Error al consultar el usuario: " + ex.Message,
                "Error de base de datos",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            return false;
        }
    }

    public static bool ExisteDni(string dni)
    {
        try
        {
            using (SqlConnection conexion = ConexionDB.ObtenerConexion())
            {
                string consulta =
                    "SELECT COUNT(1) FROM dbo.Usuarios WHERE Dni = @dni";

                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@dni", dni);

                    return Convert.ToInt32(comando.ExecuteScalar()) > 0;
                }
            }
        }
        catch (SqlException ex)
        {
            MessageBox.Show(
                "Error al consultar el DNI: " + ex.Message,
                "Error de base de datos",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            return false;
        }
    }

    public static bool RegistrarUsuario(Usuario usuario)
    {
        try
        {
            using (SqlConnection conexion = ConexionDB.ObtenerConexion())
            {
                string consulta =
                    "INSERT INTO dbo.Usuarios " +
                    "(Nombre, Apellido, Dni, Telefono, Email, Genero, FechaNacimiento, " +
                    "NombreUsuario, Contrasena, TipoUsuario, PrimerIngreso) " +
                    "VALUES " +
                    "(@nombre, @apellido, @dni, @telefono, @email, @genero, @fechaNacimiento, " +
                    "@nombreUsuario, @contrasena, @tipoUsuario, @primerIngreso); " +
                    "SELECT SCOPE_IDENTITY();";

                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@nombre", usuario.Nombre);
                    comando.Parameters.AddWithValue("@apellido", usuario.Apellido);
                    comando.Parameters.AddWithValue("@dni", usuario.Dni);
                    comando.Parameters.AddWithValue("@telefono", usuario.Telefono);
                    comando.Parameters.AddWithValue("@email", usuario.Email);
                    comando.Parameters.AddWithValue("@genero", (object)usuario.Genero ?? DBNull.Value);
                    comando.Parameters.AddWithValue("@fechaNacimiento", usuario.FechaNacimiento);
                    comando.Parameters.AddWithValue("@nombreUsuario", usuario.NombreUsuario);
                    comando.Parameters.AddWithValue("@contrasena", usuario.Contrasena);
                    comando.Parameters.AddWithValue("@tipoUsuario", usuario.TipoUsuario);
                    comando.Parameters.AddWithValue("@primerIngreso", usuario.PrimerIngreso);

                    usuario.IdUsuario = Convert.ToInt32(comando.ExecuteScalar());
                }
            }

            return true;
        }
        catch (SqlException ex)
        {
            MessageBox.Show(
                "Error al registrar el usuario: " + ex.Message,
                "Error de base de datos",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            return false;
        }
    }

    public static bool ActualizarContrasena(int idUsuario, string contrasena)
    {
        try
        {
            using (SqlConnection conexion = ConexionDB.ObtenerConexion())
            {
                string consulta =
                    "UPDATE dbo.Usuarios " +
                    "SET Contrasena = @contrasena, PrimerIngreso = 0 " +
                    "WHERE IdUsuario = @idUsuario";

                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@contrasena", contrasena);
                    comando.Parameters.AddWithValue("@idUsuario", idUsuario);

                    comando.ExecuteNonQuery();
                }
            }

            return true;
        }
        catch (SqlException ex)
        {
            MessageBox.Show(
                "Error al cambiar la contraseña: " + ex.Message,
                "Error de base de datos",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            return false;
        }
    }

    public static bool ActualizarContrasenaPorNombreUsuario(string nombreUsuario, string contrasena)
    {
        try
        {
            using (SqlConnection conexion = ConexionDB.ObtenerConexion())
            {
                string consulta =
                    "UPDATE dbo.Usuarios " +
                    "SET Contrasena = @contrasena, PrimerIngreso = 0 " +
                    "WHERE NombreUsuario = @nombreUsuario";

                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@contrasena", contrasena);
                    comando.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);

                    comando.ExecuteNonQuery();
                }
            }

            return true;
        }
        catch (SqlException ex)
        {
            MessageBox.Show(
                "Error al actualizar la contraseña: " + ex.Message,
                "Error de base de datos",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            return false;
        }
    }

    public static bool ActualizarPerfil(Usuario usuario)
    {
        try
        {
            using (SqlConnection conexion = ConexionDB.ObtenerConexion())
            {
                string consulta =
                    "UPDATE dbo.Usuarios " +
                    "SET Nombre = @nombre, Apellido = @apellido, Telefono = @telefono, " +
                    "Email = @email, Genero = @genero, FechaNacimiento = @fechaNacimiento " +
                    "WHERE IdUsuario = @idUsuario";

                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@nombre", usuario.Nombre);
                    comando.Parameters.AddWithValue("@apellido", usuario.Apellido);
                    comando.Parameters.AddWithValue("@telefono", usuario.Telefono);
                    comando.Parameters.AddWithValue("@email", usuario.Email);
                    comando.Parameters.AddWithValue("@genero", (object)usuario.Genero ?? DBNull.Value);
                    comando.Parameters.AddWithValue("@fechaNacimiento", usuario.FechaNacimiento);
                    comando.Parameters.AddWithValue("@idUsuario", usuario.IdUsuario);

                    comando.ExecuteNonQuery();
                }
            }

            return true;
        }
        catch (SqlException ex)
        {
            MessageBox.Show(
                "Error al actualizar el perfil: " + ex.Message,
                "Error de base de datos",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            return false;
        }
    }

    private static Usuario LeerUsuario(SqlDataReader lector)
    {
        int indiceGenero = lector.GetOrdinal("Genero");

        Usuario usuario = new Usuario
        {
            IdUsuario = lector.GetInt32(lector.GetOrdinal("IdUsuario")),
            Nombre = lector.GetString(lector.GetOrdinal("Nombre")),
            Apellido = lector.GetString(lector.GetOrdinal("Apellido")),
            Dni = lector.GetString(lector.GetOrdinal("Dni")),
            Telefono = lector.GetString(lector.GetOrdinal("Telefono")),
            Email = lector.GetString(lector.GetOrdinal("Email")),
            Genero = lector.IsDBNull(indiceGenero) ? null : lector.GetString(indiceGenero),
            FechaNacimiento = lector.GetDateTime(lector.GetOrdinal("FechaNacimiento")),
            NombreUsuario = lector.GetString(lector.GetOrdinal("NombreUsuario")),
            Contrasena = lector.GetString(lector.GetOrdinal("Contrasena")),
            TipoUsuario = lector.GetString(lector.GetOrdinal("TipoUsuario")),
            PrimerIngreso = lector.GetBoolean(lector.GetOrdinal("PrimerIngreso"))
        };

        return usuario;
    }
}