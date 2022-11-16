SELECT * FROM CIUDADES;
SELECT * FROM DatosClientes;
SELECT * FROM VehiculosPersonas;
SELECT * FROM PolizaVehiculos;

SELECT db.primerNombre, db.segundoApellido, db.primerApellido, db.segundoApellido,db.tipoDocumento, db.idCliente, db.numeroTelefono,
vp.placaVehiculo, vp.marcaVehiculo, vp.modeloVehiculo, vp.tipoServicio, vp.colorVehiculo, vp.serialMotor,
pv.fechaInicio, pv.fechaFin, pv.fechaVencimiento,
c.nombreCiudad
FROM DatosClientes db
INNER JOIN VehiculosPersonas vp
ON db.idCliente = vp.DatosClienteIdCliente
INNER JOIN PolizaVehiculos pv
ON vp.idVehiculo = pv.VehiculosPersonaidVehiculo
INNER JOIN Ciudades c
ON pv.CiudadidCiudad = c.idCiudad
WHERE vp.placaVehiculo = 'EPM322'
	IF pv.fechaVencimiento <= GETDATE()
		BEGIN
			PRINT 'NO SE PUEDE VENDER POLIZA' 
		END
	ELSE 
		BEGIN
			PRINT 'SE PUEDE VENDER POLIZA' 
		END
--WHERE vp.placaVehiculo = 'EPM322'
----------------------------------------------------------------------------------

CREATE PROCEDURE ConsultarPoliza(
@placa_vehiculo nvarchar(255)
)
AS
BEGIN
DECLARE @mensaje nvarchar(255) ;
DECLARE @fecha_actual as date
SET @fecha_actual = GetDate();

	SELECT db.primerNombre, db.segundoNombre, db.primerApellido, db.segundoApellido,db.tipoDocumento, db.identificacionCliente, db.numeroTelefono,
	 vp.marcaVehiculo, vp.modeloVehiculo, vp.tipoServicio, vp.colorVehiculo, vp.serialMotor,
	pv.fechaInicio, pv.fechaFin, pv.fechaVencimiento,
	c.nombreCiudad
		FROM DatosClientes db
			INNER JOIN VehiculosPersonas vp
			ON db.idCliente = vp.DatosClienteIdCliente
			INNER JOIN PolizaVehiculos pv
			ON vp.idVehiculo = pv.VehiculosPersonaidVehiculo
			INNER JOIN Ciudades c
			ON pv.CiudadidCiudad = c.idCiudad
			WHERE vp.placaVehiculo = @placa_vehiculo			
END


-------------------------------------------------------------------------------------

CREATE PROCEDURE VencimientoPoliza1(
@placa_vehiculo nvarchar(255)
)
AS
BEGIN
DECLARE @fecha_vencimiento DATETIME;
DECLARE @mensaje nvarchar(255) ;
DECLARE @fecha_actual as date
SET @fecha_actual = GETDATE();

	SELECT 	@fecha_vencimiento = pv.fechaVencimiento
		FROM DatosClientes db
			INNER JOIN VehiculosPersonas vp
			ON db.idCliente = vp.DatosClienteIdCliente
			INNER JOIN PolizaVehiculos pv
			ON vp.idVehiculo = pv.VehiculosPersonaidVehiculo
			INNER JOIN Ciudades c
			ON pv.CiudadidCiudad = c.idCiudad
			WHERE vp.placaVehiculo = @placa_vehiculo		
				IF (@fecha_vencimiento <= @fecha_actual )
					BEGIN
						SELECT Mensaje FROM [dbo].[Mensajes]
						WHERE ID = 1
					END
				ELSE 
					BEGIN
						--SET @mensaje ='SE PUEDE VENDER POLIZA';
						--PRINT @mensaje
						SELECT Mensaje FROM [dbo].[Mensajes]
						WHERE ID = 2
					END
END


select GetDate();
select SYSDATETIME();
--2021-11-08 00:00:00.0000000 esta es la que traigo
--2022-11-09 10:33:37.773 y esta es la actual

EXEC ConsultarPoliza 'EPM322';
EXEC VencimientoPoliza 'EPM322';
EXEC VencimientoPoliza2 'EPM322';

EXEC VencimientoPoliza1 'EPM322';


CREATE PROCEDURE VencimientoPoliza2(
@placa_vehiculo nvarchar(255)
)
AS
BEGIN
DECLARE @fecha_actual as date
SET @fecha_actual = GETDATE();

	SELECT 	 pv.fechaVencimiento
		FROM DatosClientes db
			INNER JOIN VehiculosPersonas vp
			ON db.idCliente = vp.DatosClienteIdCliente
			INNER JOIN PolizaVehiculos pv
			ON vp.idVehiculo = pv.VehiculosPersonaidVehiculo
			INNER JOIN Ciudades c
			ON pv.CiudadidCiudad = c.idCiudad
			WHERE vp.placaVehiculo = @placa_vehiculo	
				
END