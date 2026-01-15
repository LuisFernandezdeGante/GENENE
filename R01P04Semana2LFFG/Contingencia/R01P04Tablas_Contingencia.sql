USE GeNe
GO


-------CONTINGENCIA TABLAS01
TRUNCATE TABLE RUTAS;
GO
DROP TABLE Rutas; 
GO

TRUNCATE TABLE Camiones;
GO
DROP TABLE Camiones;
GO

TRUNCATE TABLE RUTAS;
GO
DROP TABLE Rutas;
GO


----------- Contingencia 5 primeros registros Rutas
DELETE FROM Rutas
WHERE IdRutas<=5;

GO


----------- Contingencia 5 primeros registros Camiones
DELETE FROM Camiones
WHERE IdCamion<=5;

GO
------------Contingencia 5 primeros registros Choferes
DELETE FROM Choferes
WHERE IdChofer<=5;

GO


-- Contingenica para borrar ultimo dato insertado
--Recuerad que existen llaves foraneas po lo que si quieres borrar 
--un registaro con una llave foranea y esta esta en uso no se podra eliminar.

--Rutas
DELETE FROM Rutas
WHERE IdRutas=SCOPE_IDENTITY();

GO
--Camiones
DELETE FROM Camiones
WHERE IdCamion<=SCOPE_IDENTITY();

GO
--Choferes
DELETE FROM Choferes
WHERE IdChofer<=SCOPE_IDENTITY();

GO
-----

