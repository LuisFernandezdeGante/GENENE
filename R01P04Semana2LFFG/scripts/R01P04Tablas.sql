CREATE DATABASE GeNe;
go

use GeNe;
go


-- =====================================================================
-- Author:		Luis Fernando Fernández de Gante
-- Create date: 10/01/2026
-- Description: Se crean tablas en BD GeNe Proyecto3.
-- =====================================================================
IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Camiones')
	BEGIN
		CREATE TABLE Camiones(
			IdCamion INT PRIMARY KEY IDENTITY(1,1),
			Matricula NVARCHAR(50),
			TipoCamion NVARCHAR(50),
			Modelo INT,
			Marca NVARCHAR(50),
			Capacidad INT,
			Kilometraje FLOAT,
			Disponibilidad BIT,
			UrlFoto NVARCHAR(225),
			FechaRegistro DATETIME DEFAULT GETDATE()
	
		);
	END
GO

IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Choferes')
	BEGIN
		CREATE TABLE Choferes(
			IdChofer INT PRIMARY KEY IDENTITY(1,1),
			Nombre NVARCHAR(100),
			ApPaterno NVARCHAR(100),
			ApMaterno NVARCHAR(100),
			Telefono NVARCHAR(15),
			FechaNacimiento DATE,
			Licencia NVARCHAR(50),
			UrlFoto NVARCHAR(225),
			Disponibilidad bit,
			FechaRegistro DATETIME DEFAULT GETDATE()
	
		);
	END
GO

IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Rutas')
	BEGIN
		CREATE TABLE Rutas(
			IdRutas INT PRIMARY KEY IDENTITY(1,1),
			IdChofer INT FOREIGN KEY REFERENCES Choferes(IdChofer),
			IdCamion INT FOREIGN KEY REFERENCES Camiones(IdCamion),
			Origen NVARCHAR(200),
			Destino NVARCHAR(200),
			FechaSalida DATETIME,
			FechaLlegada DATETIME,
			ATiempo bit,
			Distancia FLOAT,
			FechaRegistro DATETIME DEFAULT GETDATE()
	
		);
	END
GO