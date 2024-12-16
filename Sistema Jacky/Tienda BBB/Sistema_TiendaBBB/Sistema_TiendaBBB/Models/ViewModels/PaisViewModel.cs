using System.ComponentModel.DataAnnotations;

namespace Sistema_TiendaBBB.Models.ViewModels
{
    public class PaisViewModel
    {
        public int IdPais { get; set; }

        [Required]
        [Display (Name ="País")]
        public string DescripcionPais { get; set; } = null!;
    }
}
