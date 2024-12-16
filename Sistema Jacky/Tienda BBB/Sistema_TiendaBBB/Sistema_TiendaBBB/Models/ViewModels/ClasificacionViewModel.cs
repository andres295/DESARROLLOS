using System.ComponentModel.DataAnnotations;

namespace Sistema_TiendaBBB.Models.ViewModels
{
    public class ClasificacionViewModel
    {

        public int IdClasificacion { get; set; }
        [Required]
        [Display(Name = "Descripción")]
        public string DescripcionClasificacion { get; set; } = null!;
    }
}
