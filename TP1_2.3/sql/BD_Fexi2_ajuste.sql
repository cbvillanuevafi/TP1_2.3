/* ============================================================
   Ajustes necesarios sobre la base BD_Fexi2 ya importada.
   Ejecutar UNA sola vez (SSMS o el editor T-SQL del hosting),
   conectado a la base BD_Fexi2.

   Motivo:
   - La app guarda el domicilio del usuario y la tabla Usuarios
     no tenía esa columna.
   - El combo de género de la app permite "No binario" y
     "Prefiero no decirlo", que no existían en dbo.Generos.
   ============================================================ */

IF COL_LENGTH('dbo.Usuarios', 'Domicilio') IS NULL
    ALTER TABLE dbo.Usuarios ADD Domicilio VARCHAR(200) NULL;
GO

INSERT INTO dbo.Generos (Nombre)
SELECT 'No binario'
WHERE NOT EXISTS (SELECT 1 FROM dbo.Generos WHERE Nombre = 'No binario');

INSERT INTO dbo.Generos (Nombre)
SELECT 'Prefiero no decirlo'
WHERE NOT EXISTS (SELECT 1 FROM dbo.Generos WHERE Nombre = 'Prefiero no decirlo');
GO
