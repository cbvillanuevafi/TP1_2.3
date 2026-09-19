using Microsoft.Data.SqlClient;

public static class ConexionDB
{
    private const string CadenaConexion =
        "Server=DESKTOP-7GJVOD3\\SQLEXPRESS01;Database=Fexi;Integrated Security=True;TrustServerCertificate=True;";

    public static SqlConnection ObtenerConexion()
    {
        var conexion = new SqlConnection(CadenaConexion);
        conexion.Open();
        return conexion;
    }
}