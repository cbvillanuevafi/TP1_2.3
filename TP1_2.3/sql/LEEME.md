# Base de datos MySQL / MariaDB

El proyecto usa **MySQL** a través de `MySqlConnector`. La base se llama `BD_Fexi2`
y se crea con el script [`BD_Fexi2_mysql.sql`](BD_Fexi2_mysql.sql).

## 1. Cadena de conexión

La cadena está fija en `TP1_2.3/ConexionDB.cs` (constante `CadenaConexion`).
No hay archivo de configuración externo, así que la aplicación siempre usa
`BD_Fexi2` en Aiven: no se puede apuntar a otra base sin recompilar.

> El usuario `fexi_app` solo tiene permisos de datos (`SELECT`, `INSERT`,
> `UPDATE`, `DELETE`) sobre `BD_Fexi2`: no puede borrar tablas ni la base. La
> cuenta administradora `avnadmin` no se publica y se usa solo para ejecutar el
> script.

## 2. Usuarios iniciales

| Usuario       | Contraseña | Tipo          |
|---------------|------------|---------------|
| `admin001`    | `admin123` | Administrador |
| `empleado001` | `1234`     | Empleado      |

Ambos quedan con `primer_ingreso = 1`, por lo que la aplicación pide cambiar la
contraseña en el primer inicio de sesión.

## Notas del plan gratuito del hosting

- 1 GB de almacenamiento y 1 GB de RAM.
- El servicio puede apagarse tras un período de inactividad; se vuelve a encender
  desde la consola de Aiven. **Informar a alumno Maximiliano Montiel si esto sucede.**
- Usar siempre `SslMode=Required` porque el servidor exige TLS.
