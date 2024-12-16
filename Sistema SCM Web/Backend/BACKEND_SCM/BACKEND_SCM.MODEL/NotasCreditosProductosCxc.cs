using System;
using System.Collections.Generic;

namespace BACKEND_SCM.MODEL;

public partial class NotasCreditosProductosCxc
{
    public string? IdNc { get; set; }

    public long? IdVenta { get; set; }

    public string? IdProducto { get; set; }

    public string? Producto { get; set; }

    public int? Cantidad { get; set; }

    public int? Bonificacion { get; set; }

    public decimal? Pvf { get; set; }

    public decimal? Subtotal { get; set; }

    public decimal? Iva { get; set; }

    public decimal? Descuento { get; set; }

    public int? Contiene { get; set; }
}
