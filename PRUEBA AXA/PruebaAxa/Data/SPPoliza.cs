using apiWeb.DataConnection;
using Microsoft.Data.SqlClient;
using PruebaAxa.Models;
using System.Data;
using System.Globalization;
using System.Reflection.PortableExecutable;


namespace PruebaAxa.Data
{
    public class SPPoliza
    {
        //Método para listar la la información de la póliza, consultando la placa
        public IEnumerable<Poliza> Listar(string placa)
        {
            List<Poliza> polizaList = new List<Poliza>();
            string mensaje = "";

            using (SqlConnection conexion = new Conexion().getcn)
            {
                try
                {
                    conexion.Open();
                    SqlCommand sqlCommand = new SqlCommand("ConsultarPoliza", conexion);
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.Add(new SqlParameter("@placa_vehiculo", placa));
                    //sqlCommand.ExecuteNonQuery();
                    SqlDataReader dataReader = sqlCommand.ExecuteReader();
                    while (dataReader.Read())
                    {
                        polizaList.Add(new Poliza()
                        {
                            primerNombre = dataReader.GetString(0),
                            segundoNombre = dataReader.GetString(1),
                            primerApellido = dataReader.GetString(2),
                            segundoApellido = dataReader.GetString(3),
                            tipoDocumento = dataReader.GetString(4),
                            identificacionCliente = dataReader.GetString(5),
                            numeroTelefono = dataReader.GetString(6),


                            marcaVehiculo = dataReader.GetString(7),
                            modeloVehiculo = dataReader.GetString(8),
                            tipoServicio = dataReader.GetString(9),
                            colorVehiculo = dataReader.GetString(10),
                            serialMotor = dataReader.GetString(11),

                            fechaInicio = dataReader.GetDateTime(12),
                            fechaFin = dataReader.GetDateTime(13),
                            fechaVencimiento = dataReader.GetDateTime(14),

                            nombreCiudad = dataReader.GetString(15),
                        });
                    }                
                }
                catch (Exception ex) { mensaje = ex.Message; }
                finally { conexion.Close(); }

            }
            return polizaList;
        }

        //Método para  mostrar si se puede o no vender la poliza segun la fecha de vencimiento, consultando la placa
        public string FechaVencimiento(string placa)
        {
            List<Poliza> polizaList = new List<Poliza>();
            string mensaje = "";
            string results = "";
            using (SqlConnection cn = new Conexion().getcn)
            {
                try
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand("VencimientoPoliza1", cn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@placa_vehiculo", placa));
                    // cmd.ExecuteNonQuery();
                    SqlDataReader dataReader = cmd.ExecuteReader();
                    while (dataReader.Read())
                    {
                        results = String.Format("{0}", dataReader[0]);
                    }
                    
                }
                catch (Exception ex) { mensaje = ex.Message; }
                finally { cn.Close(); }
            }
            return results;
        }

    }
}
