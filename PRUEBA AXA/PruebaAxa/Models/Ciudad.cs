using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PruebaAxa.Models
{
    public class Ciudad
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("idCiudad")]
        [Display(Name = "Id Ciudad")]
        [Required(ErrorMessage = "Este Campo Es Obligatorio")]
        public int idCiudad { get; set; }
        [Column("nombreCiudad")]
        [StringLength(255)]
        [Display(Name = "Nombre Ciudad")]
        [Required(ErrorMessage = "Este Campo Es Obligatorio")]
        public string? nombreCiudad { get; set; }

        public List<PolizaVehiculos>? PolizaVehiculos { get; set; }
    }
}
