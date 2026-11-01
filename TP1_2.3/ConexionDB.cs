using MySqlConnector;

/// <summary>
/// Punto único de acceso a la base de datos MySQL / MariaDB.
/// La cadena está fija en el código para que la aplicación siempre use
/// la misma base, sin archivos de configuración externos.
/// Usar siempre dentro de un using para liberar la conexión.
/// </summary>
public static class ConexionDB
{
    private const string CadenaConexion =
        "Server=mysql-226b8f42-fexi-db.i.aivencloud.com;Port=26903;Database=BD_Fexi2;" +
        "User ID=fexi_app;Password=Fexi_TP2026_Demo;SslMode=Required;Connection Timeout=30;";

    public static MySqlConnection AbrirConexion()
    {
        MySqlConnection conexion = new MySqlConnection(CadenaConexion);

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
