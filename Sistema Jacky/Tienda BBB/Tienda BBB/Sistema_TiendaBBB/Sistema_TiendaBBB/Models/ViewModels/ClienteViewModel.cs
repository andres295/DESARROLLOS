using System.ComponentModel.DataAnnotations;

namespace Sistema_TiendaBBB.Models.ViewModels
{
    public class ClienteViewModel
    {
        public int IdCliente { get; set; }

        [Required]
        [Display(Name = "Clasificación")]
        public int IdClasificacion { get; set; }
        [Required]
        [Display(Name = "Pago")]
        public int IdPago { get; set; }

        [Required]
        [Display(Name = "Identificación")]
        public int IdIdentificacion { get; set; }
        [Required]
        [Display(Name = "País")]
        public int IdPais { get; set; }
        [Required]
        [Display(Name = "Ciudad")]
        public int IdCiudad { get; set; }
        [Required]
        [Display(Name = "Cliente")]
        public string NombreCliente { get; set; } = null!;
        [Required]
        [Display(Name = "Identificación")]
        public string NumeroIdentificacion { get; set; } = null!;
        [Required]
        [Display(Name = "Dirección")]
        public string Direccion { get; set; } = null!;

    }
}
