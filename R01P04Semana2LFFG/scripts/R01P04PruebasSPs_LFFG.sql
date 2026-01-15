USE GeNe
GO

--PRUEBAS FUNCIONAMIENTO SPs


--insert camion

EXEC Insert_Camion 
	
	@Matricula = 'RSE-34-56',
	@TipoCamion = 'Trailer',
	@Modelo = 1987,
	@Marca = 'Kenworth',
	@Capacidad = 11,
	@Kilometraje = 7854.245,
	@UrlFoto = '//img/ken3/img.png'

	

--insert chofer

EXEC Insert_Chofer

	@Nombre = 'Alberto',
	@ApPaterno = 'Gonzales',
	@ApMaterno = 'Lopez',
	@Telefono = 2272560907,
	@FechaNacimiento = '2003-03-26',
	@Licencia	= C1,
	@UrlFoto = '/img/AGL/img.png'
	


--Insert ruta

EXEC Insert_Ruta

	@IdChofer= 4 ,
	@IdCamion = 2,
	@Origen = 'Veracruz',
	@Destino = 'México',
	@FechaSalida = '2026-01-04',
	@FechaLlegada ='2026-01-05',
	@ATiempo = 1,
	@Distancia =12000


--LISTAR Choferes

EXEC Listar_Choferes @Disponibilidad = 1

--Listar Camiones 
use GeNe

EXEC Listar_Camiones @Disponibilidad = NULL

--Lista Rutas

EXEC ListarRutas


--Update Camiones

EXEC Update_Camion @IdCamion=4,

	
	@Matricula = 'SYG-87-90',
	@TipoCamion = 'Rigido',
	@Modelo = 1988,
	@Marca = 'Freightliner',
	@Capacidad = 14,
	@Kilometraje = 6574.456,
	@Disponibilidad =1,
	@UrlFoto ='//img/Freightliner2/img.png'

--Update chofer

EXEC Update_Chofer @IdChofer=4,

	@Nombre= 'José',
	@ApPaterno= 'Ramirez',
	@ApMaterno ='Ortiz',
	@Telefono =2471008990,
	@FechaNacimiento= '1989-02-02',
	@Licencia =C1,
	@UrlFoto ='//img/JRO/img.png',
	@Disponibilidad= 0



--Update Rutas

EXEC Update_Ruta 

	@IdRutas=3,
	@IdChofer = 3,
	@IdCamion =4,
	@Origen ='Tlaxcala',
	@Destino ='México',
	@FechaSalida = '2026-01-05',
	@FechaLlegada = '2026-01-05',
	@ATiempo =0,
	@Distancia= 300

--Delete Camiones
EXEC Delete_Camion @IdCamion=6

--Delete Choferes
EXEC Delete_Chofer @IdChofer=6

--Delete Rutas
EXEC Delete_Ruta @IdRuta=3

--Existe Licencia
EXEC Existe_Licencia @Licencia = 'C1'

--Existe Matricula
EXEC Existe_Matricula @Matricula= 'RSD-45-90'

--Obtener camion por ID
EXEC Obtener_Camion_PorID @IdCamion = 4

select*from rutas
use GeNe
SELECT COUNT(*) from Camiones
 

SELECT MAX(IdCamion) from Camiones

