USE GeNe
GO

-- trigger para agregar actualizado a la tablas auditorias

CREATE TRIGGER trg_AfterUpdate_Chofer --AQUI PUEDE CAMBIAR AFTER POR BEFORE Y UPDATE POR DELETE O INSERT U OTRO
ON Choferes
AFTER UPDATE
AS
BEGIN
	INSERT INTO AuditoriasChofer(IdChofer, Accion)
	SELECT IdChofer, 'actualizado'
	FROM inserted;
END;

GO 