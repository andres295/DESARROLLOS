using System;
using System.Collections.Generic;

namespace BACKEND_SCM.MODEL;

public partial class DescuentoLineaProductoDet
{
    public int Id { get; set; }

    public int? IdDescuentoLinea { get; set; }

    public long? IdProducto { get; set; }

    public virtual DescuentoLineaProducto? IdDescuentoLineaNavigation { get; set; }

    public virtual Producto? IdProductoNavigation { get; set; }
}
