using System;
using System.Collections.Generic;

namespace BACKEND_SCM.MODEL;

public partial class DescuentoCategorium
{
    public int Id { get; set; }

    public long? IdProducto { get; set; }

    public long? CantMin { get; set; }

    public long? CantMax { get; set; }

    public decimal? Descuento { get; set; }

    public DateOnly? DescuentoDesde { get; set; }

    public DateOnly? DescuentoHasta { get; set; }

    public virtual Producto? IdProductoNavigation { get; set; }
}
