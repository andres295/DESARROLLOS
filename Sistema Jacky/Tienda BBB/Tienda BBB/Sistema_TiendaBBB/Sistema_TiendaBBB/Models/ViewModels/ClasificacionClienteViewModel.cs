using System.ComponentModel.DataAnnotations;

namespace Sistema_TiendaBBB.Models.ViewModels
{
    public class ClasificacionClienteViewModel
    {
        public int IdClasificacion { get; set; }

        [Required]
        [Display(Name = "Descripción")]
        public string DescripcionClasificacion { get; set; } = null!;
    }
}
