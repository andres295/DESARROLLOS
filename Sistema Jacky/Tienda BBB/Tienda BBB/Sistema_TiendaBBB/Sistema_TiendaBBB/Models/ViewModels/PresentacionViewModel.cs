using System.ComponentModel.DataAnnotations;

namespace Sistema_TiendaBBB.Models.ViewModels
{
    public class PresentacionViewModel
    {

        public int IdPresentacion { get; set; }
        [Required]
        [Display(Name ="Presentación")]
        public string DescripcionPresentacion { get; set; } = null!;
    }
}
