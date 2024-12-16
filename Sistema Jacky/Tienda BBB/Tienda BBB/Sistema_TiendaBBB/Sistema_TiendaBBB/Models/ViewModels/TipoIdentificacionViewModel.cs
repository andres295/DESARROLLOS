using System.ComponentModel.DataAnnotations;

namespace Sistema_TiendaBBB.Models.ViewModels
{
    public class TipoIdentificacionViewModel
    {
        public int IdIdentificacion { get; set; }

        [Required]
        [Display(Name =("Identificación"))]
        public string DescripcionIdentificacion { get; set; } = null!;
    }
}
