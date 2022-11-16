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