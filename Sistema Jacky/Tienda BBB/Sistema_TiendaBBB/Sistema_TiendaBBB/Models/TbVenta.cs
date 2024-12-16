using System;
using System.Collections.Generic;

namespace Sistema_TiendaBBB.Models;

public partial class TbVenta
{
    public int IdVenta { get; set; }

    public int? IdArticulo { get; set; }

    public int? IdCliente { get; set; }

    public int? Cantidad { get; set; }

    public decimal? PrecioUnitario { get; set; }

    public decimal? Subtotal { get; set; }

    public decimal? Total { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public virtual TbCatArticulo? IdArticuloNavigation { get; set; }

    public virtual TbCatCliente? IdClienteNavigation { get; set; }
}
