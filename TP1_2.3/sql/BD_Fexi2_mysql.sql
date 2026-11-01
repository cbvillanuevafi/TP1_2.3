-- ============================================================
--  BD_Fexi2 - version MySQL / MariaDB
--
--  Como usarlo:
--    1. Abrir el cliente MySQL (MySQL Workbench, DBeaver,
--       phpMyAdmin o la consola de Aiven) con el usuario
--       administrador de la instancia.
--    2. Pegar todo este archivo y ejecutar.
--
--
--  ATENCION: borra la base si ya existe (es re-ejecutable).
-- ============================================================

-- [NOMBRE DE LA BASE]
DROP DATABASE IF EXISTS BD_Fexi2;

-- [NOMBRE DE LA BASE]
CREATE DATABASE BD_Fexi2
    CHARACTER SET utf8mb4
    COLLATE utf8mb4_unicode_ci;

-- [NOMBRE DE LA BASE]
USE BD_Fexi2;

-- ------------------------------------------------------------
-- Tablas
-- ------------------------------------------------------------

CREATE TABLE generos (
    id_genero INT          NOT NULL AUTO_INCREMENT,
    nombre    VARCHAR(30)  NOT NULL,
    PRIMARY KEY (id_genero),
    UNIQUE KEY uq_generos_nombre (nombre)
) ENGINE = InnoDB
  DEFAULT CHARSET = utf8mb4
  COLLATE = utf8mb4_unicode_ci;

CREATE TABLE tipos_usuario (
    id_tipo_usuario INT          NOT NULL AUTO_INCREMENT,
    nombre          VARCHAR(30)  NOT NULL,
    PRIMARY KEY (id_tipo_usuario),
    UNIQUE KEY uq_tipos_usuario_nombre (nombre)
) ENGINE = InnoDB
  DEFAULT CHARSET = utf8mb4
  COLLATE = utf8mb4_unicode_ci;

CREATE TABLE usuarios (
    id_usuario      INT          NOT NULL AUTO_INCREMENT,
    nombre          VARCHAR(50)  NOT NULL,
    apellido        VARCHAR(50)  NOT NULL,
    dni             VARCHAR(20)  NOT NULL,
    telefono        VARCHAR(20)  NULL,
    email           VARCHAR(100) NOT NULL,
    domicilio       VARCHAR(200) NULL,
    id_genero       INT          NOT NULL,
    fecha_nacimiento DATE        NOT NULL,
    id_tipo_usuario INT          NOT NULL,
    primer_ingreso  TINYINT(1)   NOT NULL DEFAULT 1,
    PRIMARY KEY (id_usuario),
    UNIQUE KEY uq_usuarios_dni (dni),
    KEY ix_usuarios_id_genero (id_genero),
    KEY ix_usuarios_id_tipo_usuario (id_tipo_usuario),
    CONSTRAINT fk_usuarios_generos
        FOREIGN KEY (id_genero) REFERENCES generos (id_genero),
    CONSTRAINT fk_usuarios_tipos_usuario
        FOREIGN KEY (id_tipo_usuario) REFERENCES tipos_usuario (id_tipo_usuario)
) ENGINE = InnoDB
  DEFAULT CHARSET = utf8mb4
  COLLATE = utf8mb4_unicode_ci;

CREATE TABLE credenciales (
    id_credencial  INT          NOT NULL AUTO_INCREMENT,
    id_usuario     INT          NOT NULL,
    nombre_usuario VARCHAR(50)  NOT NULL,
    contrasena     VARCHAR(255) NOT NULL,
    PRIMARY KEY (id_credencial),
    UNIQUE KEY uq_credenciales_id_usuario (id_usuario),
    UNIQUE KEY uq_credenciales_nombre_usuario (nombre_usuario),
    CONSTRAINT fk_credenciales_usuarios
        FOREIGN KEY (id_usuario) REFERENCES usuarios (id_usuario)
        ON DELETE CASCADE
) ENGINE = InnoDB
  DEFAULT CHARSET = utf8mb4
  COLLATE = utf8mb4_unicode_ci;

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
     '1990-05-20',
     (SELECT id_tipo_usuario FROM tipos_usuario WHERE nombre = 'Administrador'),
     1),
    ('Juan', 'Perez', '30123456', '1198765432', 'juan@gmail.com', NULL,
     (SELECT id_genero FROM generos WHERE nombre = 'Masculino'),
     '1998-08-15',
     (SELECT id_tipo_usuario FROM tipos_usuario WHERE nombre = 'Empleado'),
     1);

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
       t.nombre AS tipo_usuario,
       u.primer_ingreso
FROM usuarios u
INNER JOIN credenciales c ON c.id_usuario = u.id_usuario
INNER JOIN tipos_usuario t ON t.id_tipo_usuario = u.id_tipo_usuario
ORDER BY u.id_usuario;
