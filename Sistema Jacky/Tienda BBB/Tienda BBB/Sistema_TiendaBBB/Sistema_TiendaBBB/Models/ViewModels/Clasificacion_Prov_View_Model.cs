using System.ComponentModel.DataAnnotations;

namespace Sistema_TiendaBBB.Models.ViewModels
{
    public class Clasificacion_Prov_View_Model
    {
        public int IdClasificacion { get; set; }


        [Required]
        [Display(Name = "Descripción")]
        public string DescripcionClasificacion { get; set; } = null!;

        public DateTime? FechaRegistro { get; set; }
    }
}
