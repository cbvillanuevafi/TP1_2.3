using Microsoft.Data.SqlClient;

/// <summary>
/// Punto único de acceso a la base de datos.
/// Usar siempre dentro de un using para liberar la conexión.
/// </summary>
public static class ConexionDB
{
    public static SqlConnection AbrirConexion()
    {
        SqlConnection conexion = new SqlConnection(Configuracion.CadenaConexion);
        conexion.Open();
        return conexion;
    }
}
