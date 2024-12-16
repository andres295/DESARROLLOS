using System.ComponentModel.DataAnnotations;

namespace Sistema_TiendaBBB.Models.ViewModels
{
    public class CiudadViewModel
    {

      
        public int IdCiudad { get; set; }

        [Required]
        [Display(Name = "Ciudad")]
        public string DescripcionCiudad { get; set; } = null!;
    }
}
