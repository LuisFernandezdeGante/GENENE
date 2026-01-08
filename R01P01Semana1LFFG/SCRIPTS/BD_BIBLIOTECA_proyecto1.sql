CREATE DATABASE BD_BIBLIOTECA;
GO

USE BD_BIBLIOTECA;
GO

-- =====================================================================
-- Author:		Luis Fernando Fernández de Gante
-- Create date: 06/01/2026
-- Description: Se crea base de datos con tablas para proyecto: Biblioteca	
-- R01P01Semana1LFFG: BIBLIOTECA_proyecto.
-- =====================================================================


IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Socios')
BEGIN


--se crea la tabla para los socios de la biblioteca
CREATE TABLE Socios(
	SociosID INT PRIMARY KEY IDENTITY(1,1),
	Nombre NVARCHAR(100) NOT NULL,
	Email NVARCHAR(100),
	Telefono NVARCHAR(15),
	Direccion NVARCHAR(100),
	EnPrestamo INT
);
END
GO
--se agregan dos registros a la tabla
INSERT INTO [dbo].[Socios]
           ([Nombre]
           ,[Email]
           ,[Telefono]
		   ,[Direccion]
		   ,[EnPrestamo])
     VALUES
           ('Ana Pamela Gonzaga Peréz',
           'anPam66@gmail.com',
           5524523461,
		   'Emilio Sanchez Piedras #324 col el valle Puebla Puebla',
		   2
		   ),
		   ('Eder Cuatecontzi Jerez',
           'edercuateje@gmail.com',
           2354236234,
		   'Victoria Sur #413 colonia centro Huamantla Tlaxcala',
		   0
		   )
GO




IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'libros')
BEGIN
--se crea la tabla para los libros de la biblioteca
CREATE TABLE Libros(
	LibrosID INT PRIMARY KEY IDENTITY(1,1),
	Titulo NVARCHAR(100) NOT NULL,
	Autor NVARCHAR(100),
	Disponibles INT,
	Genero NVARCHAR(100)
);
END
GO

--se inserta el registro de dos libros a la tabla de Libros
INSERT INTO [dbo].[Libros]
           ([Titulo]
		   ,[Autor]
           ,[Disponibles]
           ,[Genero]
		   )
     VALUES
           ('El túnel',
           'Ernesto Sabato',
           4,
		   'Novela'
		   ),

		   ('El amor en los tiempos del colera',
           'Gabriel Garcia Marquez',
           1,
		   'Novela'
		   )
GO
--Tablas con primary key & foreign keys
CREATE TABLE Prestamos(
	PrestamosID INT PRIMARY KEY IDENTITY(1,1),
	LibrosID INT FOREIGN KEY REFERENCES Libros(LibrosID),
	SociosID INT FOREIGN KEY REFERENCES Socios(SociosID),
	Titulo NVARCHAR(100),
	Fecha DATETIME DEFAULT GETDATE()
);
GO

INSERT INTO [dbo].[Prestamos]
           ([LibrosID]
		   ,[SociosID]
           ,[Titulo]
           
		   
		   )
     VALUES
           (1,
		   2,
		   'El túnel'
           
		   )
GO

insert into Prestamos(LibrosID,SociosID,Titulo) 
values(1,1,'tunel')

select * from Prestamos
CREATE TABLE Devoluciones(
	DevolucionesID INT PRIMARY KEY IDENTITY(1,1),
	PrestamosID INT FOREIGN KEY REFERENCES Prestamos(PrestamosID),
	LibrosID INT FOREIGN KEY REFERENCES Libros(LibrosID),
	SociosID INT FOREIGN KEY REFERENCES Socios(SociosID),
	Titulo NVARCHAR(100),
	Fecha DATETIME DEFAULT GETDATE()
);
GO

INSERT INTO [dbo].[Devoluciones]
           ([Titulo]
		   
		   )
     VALUES
           ('El túnel'
           
		   )
GO