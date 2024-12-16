using System;
using System.ComponentModel.DataAnnotations;

namespace Sistema_TiendaBBB.Models
{
    public class VentaViewModel
    {
        public int IdVenta { get; set; }

        [Required]
        public int IdArticulo { get; set; }

        [Required]
        public int IdCliente { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "La cantidad debe ser mayor a 0")]
        public int Cantidad { get; set; }

        public decimal PrecioUnitario { get; set; }

        public decimal Subtotal => PrecioUnitario * Cantidad;

        public decimal Total { get; set; }

        public DateTime FechaRegistro { get; set; } = DateTime.Now;
    }
}
