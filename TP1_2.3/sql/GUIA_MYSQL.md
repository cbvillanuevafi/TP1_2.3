# Base de datos MySQL / MariaDB

El proyecto usa **MySQL** a través de `MySqlConnector`. La base se llama `BD_Fexi2`
y se crea con el script [`BD_Fexi2_mysql.sql`](BD_Fexi2_mysql.sql).

## 1. Crear la base en un hosting gratuito (Aiven)

1. Entrar a <https://aiven.io/free-mysql-database> y registrarse con GitHub o Google
   (no pide tarjeta ni teléfono).
2. Crear un servicio **MySQL** con el plan **Free**.
3. Cuando el servicio esté en estado *Running*, abrir **Connection information**
   y anotar:
   - Host
   - Port (normalmente `3306` o el que indique Aiven)
   - User (`avnadmin`)
   - Password
   - Database (`defaultdb` en el plan gratuito)

## 2. Ejecutar el script

Desde **MySQL Workbench**, **DBeaver** o la consola de Aiven:

- En Aiven el usuario `avnadmin` puede crear bases, así que el script se puede
  ejecutar tal cual: crea `BD_Fexi2` con las tablas y los datos iniciales
  (probado contra MySQL 8.4 en el plan gratuito).
- Si preferís usar la base `defaultdb`, reemplazar `BD_Fexi2` por `defaultdb`
  en las 3 líneas marcadas con `[NOMBRE DE LA BASE]` y ejecutar.

Al final el script muestra una consulta de verificación que debe devolver 2 filas:
`admin001` (Administrador) y `empleado001` (Empleado).

## 3. Cadena de conexión

La cadena real ya está en `TP1_2.3/appsettings.json`, que se copia junto al `.exe`.
Por eso el proyecto funciona al clonarlo, sin configurar nada.

Si hace falta usar otra base (por ejemplo para pruebas locales), crear
`TP1_2.3/appsettings.local.json` con la misma estructura; ese archivo está en
`.gitignore` y sus valores pisan a los de `appsettings.json`:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=HOST;Port=PUERTO;Database=BD_Fexi2;User ID=avnadmin;Password=CLAVE;SslMode=Required;Connection Timeout=30;"
  }
}
```

> La cadena de `appsettings.json` queda visible en el repositorio. El usuario
> `fexi_app` solo tiene permisos de datos (`SELECT`, `INSERT`, `UPDATE`, `DELETE`)
> sobre `BD_Fexi2`: no puede borrar tablas ni la base. La cuenta administradora
> `avnadmin` no se publica y se usa solo para ejecutar el script.

## 4. Usuarios iniciales

| Usuario       | Contraseña | Tipo          |
|---------------|------------|---------------|
| `admin001`    | `admin123` | Administrador |
| `empleado001` | `1234`     | Empleado      |

Ambos quedan con `primer_ingreso = 1`, por lo que la aplicación pide cambiar la
contraseña en el primer inicio de sesión.

## Notas del plan gratuito

- 1 GB de almacenamiento y 1 GB de RAM.
- El servicio puede apagarse tras un período de inactividad; se vuelve a encender
  desde la consola de Aiven.
- Usar siempre `SslMode=Required` porque el servidor exige TLS.
