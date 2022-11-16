using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PruebaAxa.Models
{
    public class VehiculosPersona
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("idVehiculo")]
        [Display(Name = "Id Vehiculo")]
        [Required(ErrorMessage = "Este Campo Es Obligatorio")]
        public int idVehiculo { get; set; }
        [Column("placaVehiculo")]
        [StringLength(255)]
        [Display(Name = "Plascas Del Vehiculo")]
        [Required(ErrorMessage = "Este Campo Es Obligatorio")]
        public string? placaVehiculo { get; set; }
        [Column("marcaVehiculo")]
        [StringLength(255)]
        [Display(Name = "Marca del Vehiculo")]
        [Required(ErrorMessage = "Este Campo Es Obligatorio")]
        public string? marcaVehiculo { get; set; }
        [Column("modeloVehiculo")]
        [StringLength(255)]
        [Display(Name = "Modelo Del Vehiculo")]
        [Required(ErrorMessage = "Este Campo Es Obligatorio")]
        public string? modeloVehiculo { get; set; }
        [Column("tipoServicio")]
        [StringLength(255)]
        [Display(Name = "Tipo De Servicio")]
        [Required(ErrorMessage = "Este Campo Es Obligatorio")]
        public string? tipoServicio { get; set; }
        [Column("colorVehiculo")]
        [StringLength(255)]
        [Display(Name = "Color Del Vehiculo")]
        [Required(ErrorMessage = "Este Campo Es Obligatorio")]
        public string? colorVehiculo { get; set; }
        [Column("serialMotor")]
        [StringLength(255)]
        [Display(Name = "Serial Del Motor")]
        [Required(ErrorMessage = "Este Campo Es Obligatorio")]
        public string? serialMotor { get; set; }
        [Timestamp]
        [Column("fechaGrabacion")]
        [Display(Name = "Fecha De Grabacion")]
        public Byte[]? fechaGrabacion { get; set; }
        
        
        /// <summary>
        /// Foreing key to datosCliente
        /// </summary>       
        public DatosCliente? DatosCliente { get; set; }
       // [ForeignKey("IdCliente")]
        [Column("IdCliente")]
        [Display(Name = "Id Cliente")]
        public int IdCliente { get; set; }
        // public ICollection<DatosCliente>? DatosClientes { get; set; }

        public List<PolizaVehiculos> PolizaVehiculos { get; set; }
    }
}
