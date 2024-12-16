using System.ComponentModel.DataAnnotations;

namespace Sistema_TiendaBBB.Models.ViewModels
{
    public class TiposPagoViewModel
    {
        public int IdPago { get; set; }

        [Required]
        [Display(Name ="Pago")]
        public string DescripcionPago { get; set; } = null!;
    }
}
