create database Practica;
use Practica;

CREATE TABLE dirección (
    idDireccion INT,
    Direccion VARCHAR(100),
    Ciudad VARCHAR(50),
    País VARCHAR(50)
);

CREATE TABLE cliente1 (
    id_cliente INT PRIMARY KEY,
    nombre VARCHAR(500),
    apellido VARCHAR(500),
    edad int,
    direccion_id INT
);

CREATE TABLE renta (
    idRenta INT,
    Fecha_Renta DATE,
    Fecha_Entrega DATE,
    Inventario_idCopiasPeliculas INT,
    Cliente_idCliente INT(11)
);

CREATE TABLE categoria (
    id_categoria INT PRIMARY KEY,
    Nombre VARCHAR(50)
);

CREATE TABLE películas (
    id_pelicula INT PRIMARY KEY,
    Nombre VARCHAR(100),
    Duracion INT,
    Descripcion VARCHAR(500),
    Año INT,
    Categoria_idCategoria INT
);

CREATE TABLE inventario1 (
    idCopiasPeliculas INT,
    Peliculas_idPelicuas INT,
    Disponible VARCHAR(100)
);

INSERT INTO dirección VALUES 
(001, 'Av. Reforma 10-2', 'Guatemala', 'Guatemala'),
(002, '8 Calle 4-55', 'San Salvador', 'El Salvador'),
(003, '9 Avenida 10', 'Villa Nueva', 'Guatemala'),
(004, 'Zona 1', 'San Jose Pinula', 'Guatemala'),
(005, 'Blvd. Liberación 93-3', 'Quetzaltenango', 'Guatemala');

INSERT INTO renta VALUES 
(1011, '2025-03-26', '2025-06-15', '301','9001'),
(1012, '2024-05-23', '2025-02-11', '302','9002'),
(1013, '2025-07-11', '2025-09-23', '303','9003'),
(1014, '2023-12-08', '2024-03-12', '305','9004'),
(1015, '2021-06-27', '2022-02-11', '304','9005');

INSERT INTO categoria VALUES 
(501, 'Acción'),
(502, 'Comedia'),
(503, 'Drama'),
(504, 'Aventura'),
(505, 'Animación');

INSERT INTO películas VALUES 
(1, 'POKEMON1', 120, 'Las aventuras de un ser de electricidad sacadas del videojuego exitoso.','2005','11'),
(2, 'Matrix', 100, 'Descubre qué sucede con la gente dentro de una simulación de la vida real.','1999','18'),
(3, 'La La Land', 60, 'La historia de amor de dos personas que peligra por su ambición.','2016','18'),
(4, 'Shrek', 90, 'Las aventuras de un ogro que descubre el significado de ser amado. ','2004','9'),
(5, 'Avengers', 72, 'Los vengadores se enfrentan a una amenaza contra la humanidad.','2011','15');

INSERT INTO inventario1 VALUES 
(6012, 1, 'Disponible'),
(6013, 2, 'Alquilado'),
(6015, 3, 'Disponible'),
(6012, 4, 'Mantenimiento'),
(6011, 5, 'Disponible');

INSERT INTO cliente1 VALUES 
(21, 'Juliana', 'Aguilar', '32', 223),
(22, 'Carter', 'León', '22', 889),
(23, 'Juliana', 'Rosales', '29', 992),
(24, 'Pilar', 'Ferres', '67', 299),
(25, 'Luis', 'Chavez', '44', 992);

select * from dirección;
select * from renta;
select * from categoria;
select * from películas;
select * from inventario1;
select * from cliente1;

SET SQL_SAFE_UPDATES=OFF;
SELECT * FROM cliente1 WHERE nombre = 'Juliana';
DELETE FROM películas WHERE Nombre = 'POKEMON1';
SELECT * FROM categoria ORDER BY Nombre ASC;
SELECT * FROM películas ORDER BY Año DESC;


