using System.ComponentModel.DataAnnotations;

namespace PruebaAxa.Models
{
    public class Poliza
    {
       
        [Display(Name = "Id Ciudad")]       
        public int idCiudad { get; set; }
       
        [Display(Name = "Nombre Ciudad")]       
        public string? nombreCiudad { get; set; }
       
        [Display(Name = "Id Cliente")]       
        public int IdCliente { get; set; }
        
        [Display(Name = "Primer Nombre")]       
        public string? primerNombre { get; set; }    
        
        [Display(Name = "Segundo Nombre")]
        public string? segundoNombre { get; set; }       
        [Display(Name = "Primer Apellido")]      
        public string? primerApellido { get; set; }
       
        [Display(Name = "Segundo Apellido")]
        public string? segundoApellido { get; set; }
        
        [Display(Name = "Tipo De Documento")]
        public string? tipoDocumento { get; set; }       
       
        [Display(Name = "Cedula")]
        public string? identificacionCliente { get; set; }
        
        [Display(Name = "Numero De Telefono")]
        public string? numeroTelefono { get; set; }
       
        [Display(Name = "Fecha De Grabacion")]
        public Byte[]? fechaGrabacion { get; set; }

       
        [Display(Name = "Id Poliza")]
        public int idPoliza { get; set; }
       
        [Display(Name = "Fecha Inicio")]
        public DateTime fechaInicio { get; set; }
        
        [Display(Name = "Fecha Fin")]
        public DateTime fechaFin { get; set; }
       
        [Display(Name = "Fecha Expedicion")]
        public DateTime fechaExpedicion { get; set; }
        
        [Display(Name = "Fecha Vencimiento")]
        public DateTime fechaVencimiento { get; set; }
        
       
        [Display(Name = "Id Vehiculo")]
        public int idVehiculo { get; set; }
       
        [Display(Name = "Plascas Del Vehiculo")]
        public string? placaVehiculo { get; set; }
        
        [Display(Name = "Marca del Vehiculo")]
        public string? marcaVehiculo { get; set; }
       
        [Display(Name = "Modelo Del Vehiculo")]
        public string? modeloVehiculo { get; set; }
        
        [Display(Name = "Tipo De Servicio")]
        public string? tipoServicio { get; set; }
       
        [Display(Name = "Color Del Vehiculo")]
        public string? colorVehiculo { get; set; }
       
        [Display(Name = "Serial Del Motor")]
        public string? serialMotor { get; set; }
       
    }
}
