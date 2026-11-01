using MySqlConnector;

/// <summary>
/// Punto único de acceso a la base de datos MySQL / MariaDB.
/// Usar siempre dentro de un using para liberar la conexión.
/// </summary>
public static class ConexionDB
{
    public static MySqlConnection AbrirConexion()
    {
        MySqlConnection conexion = new MySqlConnection(Configuracion.CadenaConexion);

        try
        {
            conexion.Open();
            return conexion;
        }
        catch
        {
            // Si no se pudo abrir, liberamos el objeto antes de propagar el error.
            conexion.Dispose();
            throw;
        }
    }
}
