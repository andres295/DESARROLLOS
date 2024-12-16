using System;
using System.Collections.Generic;

namespace Sistema_TiendaBBB.Models;

public partial class TbDetalleVenta
{
    public int IdDetalleVenta { get; set; }

    public int? IdVenta { get; set; }

    public int? IdArticulo { get; set; }

    public int? Cantidad { get; set; }

    public decimal? PrecioUnitario { get; set; }

    public decimal? Subtotal { get; set; }

    public virtual TbCatArticulo? IdArticuloNavigation { get; set; }

    public virtual TbVenta? IdVentaNavigation { get; set; }
}
