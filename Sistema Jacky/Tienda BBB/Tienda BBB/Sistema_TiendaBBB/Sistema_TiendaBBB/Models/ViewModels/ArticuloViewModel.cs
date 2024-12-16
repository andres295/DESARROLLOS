using System.ComponentModel.DataAnnotations;

namespace Sistema_TiendaBBB.Models.ViewModels
{
    public class ArticuloViewModel
    {

        public int IdArticulo { get; set; }

        [Required]
        [Display(Name ="Descripción")]
        public string DescripcionArticulo { get; set; } = null!;

        [Required]
        [Display(Name = "Proveedor")]
        public int? IdProveedor { get; set; }

        [Required]
        [Display(Name = "Clasificación")]
        public int? IdClasificacion { get; set; }
        [Required]
        [Display(Name = "Presentación")]
        public int? IdPresentacion { get; set; }
        [Required]
        [Display(Name = "Disponible")]
        public int Disponible { get; set; }
        [Required]
        [Display(Name = "Costo Unitario")]
        public decimal CostoUnitario { get; set; }
        [Required]
        [Display(Name = "Precio Venta")]
        public decimal PrecioVenta { get; set; }
    }
}
