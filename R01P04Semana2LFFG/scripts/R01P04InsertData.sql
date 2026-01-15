USE GeNe
GO


--INSERTAR 5 REGISTROS TABLA CAMIONES
INSERT INTO dbo.Camiones
           (
           Matricula,
		   TipoCamion,
		   Modelo,
		   Marca,
		   Capacidad,
		   Kilometraje,
		   Disponibilidad,
		   UrlFoto
		   
		   )
     VALUES
			
			(
			'XWB-46-99',
			'Rigido',
			1994,
			'Kenworth',
			10,
			5357.125,
			1,
			'//img/kenworth1/img.png'

			),
			(
			'RSD-45-90',
			'Articulado',
			1987,
			'Freightliner',
			11,
			5357.125,
			1,
			'//img/Freightliner1/img.png'

			),

			(
			'ERF-35-14',
			'Trailer',
			1988,
			'Volvo',
			14,
			8798.253,
			0,
			'//img/volvo/img.png'

			),

			(
			'DSF-24-89',
			'Articulado',
			1996,
			'Kenworth',
			14,
			5298.223,
			1,
			'//img/ken2/img.png'

			),

			(
			'ASD-22-45',
			'Rígido',
			1983,
			'Peterblit',
			10,
			9735.345,
			0,
			'//img/peterblit/img.png'

			)


GO
--INSERTA 5 REGISTROS TABLA CHOFERES
INSERT INTO dbo.Choferes
           (
           Nombre,
		   ApPaterno,
		   ApMaterno,
		   Telefono,
		   FechaNacimiento,
		   Licencia,
		   UrlFoto,
		   Disponibilidad
		   
		   
		   )
     VALUES
	       (
			'Carlos',
			'Herrera',
			'Perez',
			247123451,
			'2000-01-10',
			'C1',
			'//img/peterblit/img.png',
			0
			),

			(
			'Miguel',
			'Juarez',
			'Gomez',
			2471123245,
			'1998-09-10',
			'C1',
			'//img/MJG/img.png',
			1
			),
			(
			'Juan',
			'Herrera',
			'Martinez',
			551123451,
			'1990-01-11',
			'C1',
			'//img/JHM/img.png',
			0
			),
			(
			'Jose',
			'Ortiz',
			'Ramirez',
			221123451,
			'1989-02-07',
			'C1',
			'//img/JOR/img.png',
			0
			),
			(
			'Pedro',
			'Herrera',
			'Lopez',
			247342451,
			'2001-01-03',
			'C1',
			'//img/PHL/img.png',
			0
			)
GO
--INSERTA 5 REGISTROS TABLA rutas
INSERT INTO dbo.Rutas
           (
           IdChofer,
		   IdCamion,
		   Origen,
		   Destino,
		   FechaSalida,
		   FechaLlegada,
		   ATiempo,
		   Distancia
		   )
VALUES(
			5,
			4,
			'Sinaloa',
			'México',
			'2026-01-10',
			'2026-01-11',
			1,
			3000
),
(
			2,
			4,
			'Veracuz',
			'México',
			'2026-01-08',
			'2026-01-09',
			1,
			8000
),
(
			3,
			2,
			'Puebla',
			'México',
			'2026-01-08',
			'2026-01-08',
			1,
			3000
),
(
			3,
			3,
			'Yucatán',
			'México',
			'2026-01-07',
			'2026-01-06',
			1,
			16500
),
(
			4,
			4,
			'Tabasco',
			'México',
			'2026-01-04',
			'2026-01-06',
			1,
			12000
)

GO
--------------


---Ver toda la informacion de las tablas
SELECT * FROM Rutas
SELECT * FROM Camiones
SELECT * FROM Choferes


--Insertar solo un dato en las tablas
--Camiones
INSERT INTO dbo.Camiones
           (
           Matricula,
		   TipoCamion,
		   Modelo,
		   Marca,
		   Capacidad,
		   Kilometraje,
		   Disponibilidad,
		   UrlFoto
		   
		   )
     VALUES
			
			(
			'XWB-46-99',
			'Rigido',
			1994,
			'Kenworth',
			10,
			5357.125,
			1,
			'//img/kenworth1/img.png'

			)
GO

--Choferes
INSERT INTO dbo.Choferes
           (
           Nombre,
		   ApPaterno,
		   ApMaterno,
		   Telefono,
		   FechaNacimiento,
		   Licencia,
		   UrlFoto,
		   Disponibilidad
		   
		   
		   )
     VALUES
	       (
			'Carlos',
			'Herrera',
			'Perez',
			247123451,
			'2000-01-10',
			'C1',
			'//img/peterblit/img.png',
			0
			)
GO

--Rutas
INSERT INTO dbo.Rutas
           (
           IdChofer,
		   IdCamion,
		   Origen,
		   Destino,
		   FechaSalida,
		   FechaLlegada,
		   ATiempo,
		   Distancia
		   )
VALUES(
			7,					--Recuerda verificar que los Id de camiones y choferes existan.
			10,
			'Sinaloa',
			'México',
			'2026-01-10',
			'2026-01-11',
			1,
			3000
)
GO


sp_help 'Camiones'
sp_help 'Choferes'
sp_help 'Rutas'


--Create tabla de auditoria

CREATE TABLE AuditoriasChofer (
	IdAuditoria INT PRIMARY KEY IDENTITY,
	IdChofer INT FOREIGN KEY REFERENCES Choferes(IdChofer),
	Accion NVARCHAR(50),
	Fecha DATETIME DEFAULT GETDATE()
);

GO



--UPDATEs



UPDATE Choferes
SET Telefono = 2471005549
WHERE IdChofer = 7;
GO
use GeNe
Select * From Rutas

GO