using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PruebaAxa.Models
{
    public class PolizaVehiculos
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("idPoliza")]
        [Display(Name = "Id Poliza")]
        [Required(ErrorMessage = "Este Campo Es Obligatorio")]
        public int idPoliza { get; set; }
        [Column("fechaInicio")]
        [Display(Name = "Fecha Inicio")]
        [Required(ErrorMessage = "Este Campo Es Obligatorio")]
        public DateTime fechaInicio { get; set; }
        [Column("fechaFin")]
        [Display(Name = "Fecha Fin")]
        [Required(ErrorMessage = "Este Campo Es Obligatorio")]
        public DateTime fechaFin { get; set; }
        [Column("fechaExpedicion")]
        [Display(Name = "Fecha Expedicion")]
        [Required(ErrorMessage = "Este Campo Es Obligatorio")]
        public DateTime fechaExpedicion { get; set; }
        [Column("fechaVencimiento")]
        [Display(Name = "Fecha Vencimiento")]
        [Required(ErrorMessage = "Este Campo Es Obligatorio")]
        public DateTime fechaVencimiento { get; set; }
        [Timestamp]
        [Column("fechaGrabacion")]
        [Display(Name = "Fecha De Grabacion")]
        public Byte[]? fechaGrabacion { get; set; }

        public VehiculosPersona? VehiculosPersona { get; set; }
        /// <summary>
        /// Foreing key to VehiculosPersona
        /// </summary>
        // [ForeignKey("idVehiculo")]
        [Column("idVehiculo")]
        [Display(Name = "Id Vehiculo")]
        public int idVehiculo { get; set; }


        public Ciudad? Ciudad { get; set; }
        //public ICollection<VehiculosPersona>? VehiculosPersonas { get; set; }
        /// <summary>
        /// Foreing key to Ciudad
        /// </summary>
       // [ForeignKey("idCiudad")]
       [Column("idCiudad")]
       [Display(Name = "Id Ciudad")]
       public int idCiudad { get; set; }
       
        //public ICollection<Ciudad>? Ciudades { get; set; }
    }
}
