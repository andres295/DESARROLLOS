using System;
using System.Collections.Generic;

namespace BACKEND_SCM.MODEL;

public partial class Presentacione
{
    public long Id { get; set; }

    public string? Presentacion { get; set; }

    public virtual ICollection<CargoCompraProducto> CargoCompraProductos { get; set; } = new List<CargoCompraProducto>();

    public virtual ICollection<Producto> Productos { get; set; } = new List<Producto>();
}
