-- ============================================================
--  BD_Fexi2 - version PostgreSQL para Neon
--
--  Como usarlo:
--    1. Entrar al proyecto en https://console.neon.tech
--    2. Abrir "SQL Editor"
--    3. Pegar todo este archivo y ejecutar
--
--  ATENCION: borra las tablas si ya existen (es re-ejecutable).
-- ============================================================

DROP TABLE IF EXISTS credenciales;
DROP TABLE IF EXISTS usuarios;
DROP TABLE IF EXISTS generos;
DROP TABLE IF EXISTS tipos_usuario;

-- ------------------------------------------------------------
-- Tablas
-- ------------------------------------------------------------

CREATE TABLE generos (
    id_genero integer GENERATED ALWAYS AS IDENTITY PRIMARY KEY,
    nombre    varchar(30) NOT NULL UNIQUE
);

CREATE TABLE tipos_usuario (
    id_tipo_usuario integer GENERATED ALWAYS AS IDENTITY PRIMARY KEY,
    nombre          varchar(30) NOT NULL UNIQUE
);

CREATE TABLE usuarios (
    id_usuario      integer GENERATED ALWAYS AS IDENTITY PRIMARY KEY,
    nombre          varchar(50)  NOT NULL,
    apellido        varchar(50)  NOT NULL,
    dni             varchar(20)  NOT NULL UNIQUE,
    telefono        varchar(20)  NULL,
    email           varchar(100) NOT NULL,
    domicilio       varchar(200) NULL,
    id_genero       integer      NOT NULL REFERENCES generos (id_genero),
    fecha_nacimiento date        NOT NULL,
    id_tipo_usuario integer      NOT NULL REFERENCES tipos_usuario (id_tipo_usuario),
    primer_ingreso  boolean      NOT NULL DEFAULT TRUE
);

CREATE TABLE credenciales (
    id_credencial  integer GENERATED ALWAYS AS IDENTITY PRIMARY KEY,
    id_usuario     integer      NOT NULL UNIQUE REFERENCES usuarios (id_usuario),
    nombre_usuario varchar(50)  NOT NULL UNIQUE,
    contrasena     varchar(255) NOT NULL
);

-- ------------------------------------------------------------
-- Datos iniciales
-- ------------------------------------------------------------

INSERT INTO generos (nombre) VALUES
    ('Masculino'),
    ('Femenino'),
    ('Otro'),
    ('No binario'),
    ('Prefiero no decirlo');

INSERT INTO tipos_usuario (nombre) VALUES
    ('Administrador'),
    ('Empleado');

INSERT INTO usuarios
    (nombre, apellido, dni, telefono, email, domicilio,
     id_genero, fecha_nacimiento, id_tipo_usuario, primer_ingreso)
VALUES
    ('Administrador', 'Sistema', '12345678', '1123456789', 'admin@fexi.com', NULL,
     (SELECT id_genero FROM generos WHERE nombre = 'Masculino'),
     DATE '1990-05-20',
     (SELECT id_tipo_usuario FROM tipos_usuario WHERE nombre = 'Administrador'),
     TRUE),
    ('Juan', 'Perez', '30123456', '1198765432', 'juan@gmail.com', NULL,
     (SELECT id_genero FROM generos WHERE nombre = 'Masculino'),
     DATE '1998-08-15',
     (SELECT id_tipo_usuario FROM tipos_usuario WHERE nombre = 'Empleado'),
     TRUE);

INSERT INTO credenciales (id_usuario, nombre_usuario, contrasena)
SELECT id_usuario, 'admin001', 'admin123'
FROM usuarios
WHERE dni = '12345678';

INSERT INTO credenciales (id_usuario, nombre_usuario, contrasena)
SELECT id_usuario, 'empleado001', '1234'
FROM usuarios
WHERE dni = '30123456';

-- ------------------------------------------------------------
-- Verificacion: deben aparecer 2 filas
-- ------------------------------------------------------------

SELECT u.id_usuario,
       u.nombre,
       u.apellido,
       c.nombre_usuario,
       t.nombre AS tipo_usuario
FROM usuarios u
INNER JOIN credenciales c ON c.id_usuario = u.id_usuario
INNER JOIN tipos_usuario t ON t.id_tipo_usuario = u.id_tipo_usuario
ORDER BY u.id_usuario;
