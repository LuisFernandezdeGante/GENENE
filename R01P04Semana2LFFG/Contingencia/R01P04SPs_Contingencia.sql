USE GeNe
GO

----CONTINGENCIA SP INSERT_CAMION

IF(OBJECT_ID('dbo.Insert_Camion','P')IS NOT NULL)

DROP PROCEDURE [dbo].[Insert_Camion]

GO

----CONTINGENCIA SP INSERT_CHOFER

IF(OBJECT_ID('dbo.Insert_Chofer','P')IS NOT NULL)

DROP PROCEDURE [dbo].[Insert_Chofer]

GO

----CONTINGENCIA SP INSERT_RUTA

IF(OBJECT_ID('dbo.Insert_Ruta','P')IS NOT NULL)

DROP PROCEDURE [dbo].[Insert_Ruta]

GO

----CONTINGENCIA SP LISTAR_CAMION

IF(OBJECT_ID('dbo.Listar_Camiones','P')IS NOT NULL)

DROP PROCEDURE [dbo].[Listar_Camiones]

GO


----CONTINGENCIA SP LISTAR_Chofer

IF(OBJECT_ID('dbo.Listar_Choferes','P')IS NOT NULL)

DROP PROCEDURE [dbo].[Listar_Choferes]

GO

----CONTINGENCIA SP LISTAR_Rutas

IF(OBJECT_ID('dbo.ListarRutas','P')IS NOT NULL)

DROP PROCEDURE [dbo].[ListarRutas]

GO


----CONTINGENCIA SP Update_Chofer

IF(OBJECT_ID('dbo.Update_Chofer','P')IS NOT NULL)

DROP PROCEDURE [dbo].[Update_Chofer]

GO

----CONTINGENCIA SP Update_Camion

IF(OBJECT_ID('dbo.Update_Camion','P')IS NOT NULL)

DROP PROCEDURE [dbo].[Update_Camion]

GO

----CONTINGENCIA SP Update_Ruta

IF(OBJECT_ID('dbo.Update_Ruta','P')IS NOT NULL)

DROP PROCEDURE [dbo].[Update_Ruta]

GO


----CONTINGENCIA SP Delete_Camion

IF(OBJECT_ID('dbo.Delete_Camion','P')IS NOT NULL)

DROP PROCEDURE [dbo].[Delete_Camion]

GO

----CONTINGENCIA SP Delete_Chofer

IF(OBJECT_ID('dbo.Delete_Chofer','P')IS NOT NULL)

DROP PROCEDURE [dbo].[Delete_Chofer]

GO

----CONTINGENCIA SP Delete_Ruta

IF(OBJECT_ID('dbo.Delete_Ruta','P')IS NOT NULL)

DROP PROCEDURE [dbo].[Delete_Ruta]

GO

----CONTINGENCIA SP Existe Licencia

IF(OBJECT_ID('dbo.Existe_Licencia','P')IS NOT NULL)

DROP PROCEDURE [dbo].[Existe_Licencia]

GO

----CONTINGENCIA SP Existe Matricula

IF(OBJECT_ID('dbo.Existe_Matricula','P')IS NOT NULL)

DROP PROCEDURE [dbo].[Existe_Matricula]

GO


----CONTINGENCIA SP Obtener Camion por ID

IF(OBJECT_ID('dbo.Obtener_Camion_porID','P')IS NOT NULL)

DROP PROCEDURE [dbo].[Obtener_Camion_porID]

GO



sp_help 'rutas'