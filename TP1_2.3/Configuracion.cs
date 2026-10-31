using System;
using System.IO;
using System.Text.Json;

/// <summary>
/// Lee la cadena de conexión desde appsettings.json (junto al ejecutable).
/// Si existe appsettings.local.json, sus valores pisan a los de appsettings.json.
/// </summary>
public static class Configuracion
{
    private sealed class ArchivoConfig
    {
        public SeccionConnectionStrings? ConnectionStrings { get; set; }
    }

    private sealed class SeccionConnectionStrings
    {
        public string? DefaultConnection { get; set; }
    }

    private static readonly JsonSerializerOptions Opciones = new()
    {
        PropertyNameCaseInsensitive = true
    };

    public static string CadenaConexion { get; } = CargarCadenaConexion();

    private static string CargarCadenaConexion()
    {
        string rutaBase = Path.Combine(AppContext.BaseDirectory, "appsettings.json");
        string rutaLocal = Path.Combine(AppContext.BaseDirectory, "appsettings.local.json");

        if (!File.Exists(rutaBase))
        {
            throw new FileNotFoundException(
                "No se encontró appsettings.json junto al ejecutable.", rutaBase);
        }

        string? cadena = LeerCadena(rutaBase);

        if (File.Exists(rutaLocal))
        {
            cadena = LeerCadena(rutaLocal) ?? cadena;
        }

        if (string.IsNullOrWhiteSpace(cadena))
        {
            throw new InvalidOperationException(
                "La cadena de conexión 'DefaultConnection' está vacía. Revisá appsettings.json.");
        }

        if (cadena.Contains("HOST") || cadena.Contains("NOMBRE_DB"))
        {
            throw new InvalidOperationException(
                "Configurá la cadena de conexión real en appsettings.json " +
                "(o en appsettings.local.json).");
        }

        return cadena;
    }

    private static string? LeerCadena(string ruta)
    {
        ArchivoConfig? config = JsonSerializer.Deserialize<ArchivoConfig>(
            File.ReadAllText(ruta), Opciones);

        return config?.ConnectionStrings?.DefaultConnection;
    }
}
