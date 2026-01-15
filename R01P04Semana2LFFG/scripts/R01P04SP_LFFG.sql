USE GeNe
GO

-- SP INSERTAR CAMION


CREATE OR ALTER PROCEDURE dbo.Insert_Camion
	@Matricula VARCHAR(50),
	@TipoCamion VARCHAR(50),
	@Modelo INT,
	@Marca VARCHAR(50),
	@Capacidad INT,
	@Kilometraje FLOAT,
	@UrlFoto VARCHAR(50),
	@Disponibilidad
AS
BEGIN
	INSERT INTO Camiones (Matricula, TipoCamion, Modelo, Marca, Capacidad, Kilometraje, UrlFoto, Disponibilidad)
	VALUES (@Matricula, @TipoCamion, @Modelo, @Marca, @Capacidad, @Kilometraje, @UrlFoto,1)
END
GO


--SP: INSERTAR CHOFER


CREATE OR ALTER PROCEDURE dbo.Insert_Chofer
	@Nombre VARCHAR(100),
	@ApPaterno VARCHAR(100),
	@ApMaterno VARCHAR(100),
	@Telefono VARCHAR(15),
	@FechaNacimiento DATE,
	@Licencia	VARCHAR(50),
	@UrlFoto VARCHAR(225)
AS
BEGIN
	INSERT INTO Choferes (
		Nombre,
		ApPaterno,
		ApMaterno,
		Telefono,
		FechaNacimiento,
		Licencia,
		UrlFoto,
		Disponibilidad
	)
	VALUES(
		@Nombre,
		@ApPaterno,
		@ApMaterno,
		@Telefono,
		@FechaNacimiento,
		@Licencia,
		@UrlFoto,
		1
	)
END 
GO



--SP INSERTAR RUTA


CREATE OR ALTER PROCEDURE dbo.Insert_Ruta
	@IdChofer INT,
	@IdCamion INT,
	@Origen VARCHAR(200),
	@Destino VARCHAR(200),
	@FechaSalida DATETIME,
	@FechaLlegada DATETIME,
	@ATiempo BIT,
	@Distancia FLOAT
AS
BEGIN
	INSERT INTO Rutas (
		IdChofer,
		IdCamion, 
		Origen,
		Destino,
		FechaSalida ,
		FechaLlegada ,
		ATiempo ,
		Distancia 
	)
	VALUES(
		@IdChofer,
		@IdCamion, 
		@Origen,
		@Destino,
		@FechaSalida ,
		@FechaLlegada ,
		@ATiempo ,
		@Distancia 
	)
END 
GO

--SP: LISTAR CHOFERES

CREATE OR ALTER PROCEDURE dbo.Listar_Choferes
	@Disponibilidad BIT = NULL
AS
BEGIN
	IF @Disponibilidad IS NULL 
		SELECT * FROM Choferes 
		ORDER BY IdChofer ASC
	ELSE
		SELECT *  FROM Choferes
		WHERE Disponibilidad = @Disponibilidad 
		ORDER BY IdChofer ASC
END 
GO

--SP: LISTAR CAMIONES

CREATE OR ALTER PROCEDURE dbo.Listar_Camiones
	@Disponibilidad BIT = NULL
AS
BEGIN
	IF @Disponibilidad IS NULL
		SELECT * FROM Camiones 
		ORDER BY IdCamion ASC
	ELSE
		SELECT *  FROM CHOFERES 
		WHERE Disponibilidad = @Disponibilidad 
		ORDER BY IdCamion ASC
END 
GO



--SP: Listar Rutas



CREATE OR ALTER PROCEDURE dbo.ListarRutas
	@ATiempo BIT = NULL
AS
BEGIN

IF @ATiempo IS NULL
	SELECT
		r.IdRutas,
		r.IdChofer,
		r.IdCamion,
		CONCAT (ch.Nombre, ' ', ch.ApPaterno, ' ' , ch.ApMaterno) AS NombreChofer,
		ch.Licencia,
		ch.Telefono,
		ch.UrlFoto AS FotoCH,
		c.Matricula,
		c.UrlFoto AS FotoCamion,
		r.Origen,
		r.Destino,
		r.FechaSalida AS Salida,
		r.FechaLlegada AS Llegada,
		r.ATiempo,
		r.Distancia

	FROM Rutas AS r
	
	INNER JOIN Choferes AS ch ON r.IdChofer= ch.IdChofer
	INNER JOIN Camiones AS c ON r.IdCamion = c.IdCamion
	
	ORDER BY r.IdRutas ASC
ELSE 
	SELECT
		r.IdRutas,
		r.IdChofer,
		r.IdCamion,
		CONCAT (ch.Nombre, ' ', ch.ApPaterno, ' ' , ch.ApMaterno) AS NombreChofer,
		ch.Licencia,
		ch.Telefono,
		ch.UrlFoto AS FotoCH,
		c.Matricula,
		c.UrlFoto AS FotoCamion,
		r.Origen,
		r.Destino,
		r.FechaSalida AS Salida,
		r.FechaLlegada AS Llegada,
		r.ATiempo,
		r.Distancia

	FROM Rutas AS r
	
	INNER JOIN Choferes AS ch ON r.IdChofer= ch.IdChofer
	INNER JOIN Camiones AS c ON r.IdCamion = c.IdCamion
	WHERE ATiempo = @ATiempo
	ORDER BY r.IdRutas desc
	
END
GO

EXEC ListarRutas @ATiempo=false
EXEC Listar_Camiones @Disponibilidad=null
USE GeNe
select*from CAMIONES
--SP: UPDATE CAMIONES




CREATE OR ALTER PROCEDURE dbo.Update_Camion
	@IdCamion INT,
	@Matricula VARCHAR(50),
	@TipoCamion VARCHAR(50),
	@Modelo INT,
	@Marca VARCHAR(50),
	@Capacidad INT,
	@Kilometraje FLOAT,
	@Disponibilidad BIT,
	@UrlFoto VARCHAR(255)
AS
BEGIN
	UPDATE Camiones
	SET 
		Matricula=@Matricula,
		TipoCamion=@TipoCamion,
		Modelo=@Modelo,
		Marca=@Marca,
		Capacidad=@Capacidad,
		Kilometraje= @Kilometraje,
		Disponibilidad=@Disponibilidad,
		UrlFoto=@UrlFoto
	WHERE IdCamion = @IdCamion
END
GO

--SP: UPDATE CHOFERES




CREATE OR ALTER PROCEDURE dbo.Update_Chofer
	@IdChofer INT,
	@Nombre VARCHAR(100),
	@ApPaterno VARCHAR(100),
	@ApMaterno VARCHAR(100),
	@Telefono VARCHAR(15),
	@FechaNacimiento DATE,
	@Licencia VARCHAR(50),
	@UrlFoto VARCHAR(225),
	@Disponibilidad BIT
AS
BEGIN
	UPDATE Choferes
	SET 
		Nombre=@Nombre,
		ApPaterno=@ApPaterno,
		ApMaterno=@ApMaterno,
		Telefono=@Telefono,
		FechaNacimiento=@FechaNacimiento,
		Licencia=@Licencia,
		UrlFoto=@UrlFoto,
		Disponibilidad=@Disponibilidad
	WHERE IdChofer = @IdChofer
END
GO

--SP: UPDATE RUTAS

CREATE OR ALTER PROCEDURE dbo.Update_Ruta
	@IdRutas INT,
	@IdChofer INT,
	@IdCamion INT,
	@Origen VARCHAR(200),
	@Destino VARCHAR(200),
	@FechaSalida DATETIME,
	@FechaLlegada DATETIME,
	@ATiempo BIT,
	@Distancia FLOAT
AS
BEGIN
	UPDATE Rutas
	SET 
		
		IdChofer= @IdChofer,
		IdCamion=@IdCamion,
		Origen=@Origen,
		Destino= @Destino,
		FechaSalida=@FechaSalida,
		FechaLlegada=@FechaLlegada,
		ATiempo=@ATiempo,
		Distancia=@Distancia

	WHERE IdRutas = @IdRutas
END
GO

-- SP: Eliminar Camión (Eliminar físicamente)


CREATE OR ALTER PROCEDURE dbo.Delete_Camion
	@IdCamion INT
AS

BEGIN
	DELETE FROM Camiones 
	WHERE IdCamion = @IdCamion
END
GO

----SP: Eliminar Chofer


CREATE OR ALTER PROCEDURE dbo.Delete_Chofer
	@IdChofer INT
AS
BEGIN
	DELETE FROM Choferes 
	WHERE IdChofer = @IdChofer
END
GO

----- SP: Elimiinar ruta



CREATE OR ALTER PROCEDURE dbo.Delete_Ruta
	@IdRuta INT
AS
BEGIN
	DELETE FROM Rutas 
	WHERE IdRutas = @IdRuta
END
GO

-- SP_ Verificar si existe una licencia



CREATE OR ALTER PROCEDURE dbo.Existe_Licencia
	@Licencia VARCHAR(50)
AS
BEGIN
	SELECT COUNT(*) FROM Choferes 
	WHERE Licencia = @Licencia
END
GO

-----SP: Verificar si existe una matricula



CREATE OR ALTER PROCEDURE dbo.Existe_Matricula
	@Matricula VARCHAR(50)
AS
BEGIN
	SELECT COUNT (*) FROM Camiones 
	WHERE Matricula = @Matricula
END
GO






--SP: OBTENER CAMION POR ID



CREATE OR ALTER PROCEDURE dbo.Obtener_Camion_PorID
	@IdCamion INT
AS
BEGIN
	SELECT * FROM Camiones 
	WHERE IdCamion = @IdCamion
END
GO




SELECT * FROM Rutas

