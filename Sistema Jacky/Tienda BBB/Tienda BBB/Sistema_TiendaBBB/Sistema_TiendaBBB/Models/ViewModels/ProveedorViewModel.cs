using System.ComponentModel.DataAnnotations;

namespace Sistema_TiendaBBB.Models.ViewModels
{
    public class ProveedorViewModel
    {
        public int IdProveedor { get; set; }

        [Required]
        [Display(Name = "Clasificación")]
        public int IdClasificacion { get; set; }

        [Required]
        [Display(Name = "Tipo De Pago")]
        public int IdPago { get; set; }

        [Required]
        [Display(Name = "Tipo De Identificación")]
        public int IdIdentificacion { get; set; }

        [Required]
        [Display(Name = "País")]
        public int IdPais { get; set; }

        [Required]
        [Display(Name = "Ciudad")]
        public int IdCiudad { get; set; }

        [Required]
        [Display(Name = "Nombre Del Proveedor")]
        public string NombreProveedor { get; set; } = null!;

        [Required]
        [Display(Name = "Identificación")]
        public string NumeroIdentificacion { get; set; } = null!;

        [Required]
        [Display(Name = "Dirección")]
        public string Direccion { get; set; } = null!;
    }
}
