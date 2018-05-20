CREATE DATABASE LibroDb
GO
USE LibroDb
GO
CREATE TABLE Libros
(
	LibroId int primary key identity,
	Nombre varchar(39),
	Siglas varchar(39),
	TipoId varchar(20),
	Descripcion varchar(max)
);
