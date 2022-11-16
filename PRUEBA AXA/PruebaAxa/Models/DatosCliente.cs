using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PruebaAxa.Models
{
    public class DatosCliente
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("idCliente")]
        [Display(Name = "Id Cliente")]
        [Required(ErrorMessage = "Este Campo Es Obligatorio")]
        public int IdCliente { get; set; }
        [Column("primerNombre")]
        [StringLength(255)]
        [Display(Name = "Primer Nombre")]
        [Required(ErrorMessage = "Este Campo Es Obligatorio")]
        public string? primerNombre { get; set; }
        [Column("segundoNombre")]
        [StringLength(255)]
        [Display(Name = "Segundo Nombre")]
        public string? segundoNombre { get; set; }
        [Column("primerApellido")]
        [StringLength(255)]
        [Display(Name = "Primer Apellido")]
        [Required(ErrorMessage = "Este Campo Es Obligatorio")]
        public string? primerApellido { get; set; }
        [Column("segundoApellido")]
        [StringLength(255)]
        [Display(Name = "Segundo Apellido")]
        public string? segundoApellido { get; set; }
        [Column("tipoDocumento")]
        [StringLength(3)]
        [Display(Name = "Tipo De Documento")]
        [Required(ErrorMessage = "Este Campo Es Obligatorio")]
        public string? tipoDocumento { get; set; }
        [Column("identificacionCliente")]
        [StringLength(255)]
        [MaxLength(3, ErrorMessage = "El tipo de documento debe ser de 3 caracteres"), MinLength(3, ErrorMessage = "El tipo de documento debe ser de 3 caracteres")]
        [Display(Name = "Cedula")]
        [Required(ErrorMessage = "Este Campo Es Obligatorio")]
        public string? identificacionCliente { get; set; }
        [Column("numeroTelefono")]
        [StringLength(255)]
        [Display(Name = "Numero De Telefono")]
        [Required(ErrorMessage = "Este Campo Es Obligatorio")]
        public string? numeroTelefono { get; set; }
        [Timestamp]
        [Column("fechaGrabacion")]
        [Display(Name = "Fecha De Grabacion")]
        public Byte[]? fechaGrabacion { get; set; }

        public List<VehiculosPersona>? VehiculosPersona { get; set; }
      

    }
}
