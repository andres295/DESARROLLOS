using System;
using System.Collections.Generic;

namespace BACKEND_SCM.MODEL;

public partial class ComposicionQuimica
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public string? Composicion { get; set; }

    public DateTime FechaSistema { get; set; }

    public bool Estado { get; set; }

    public virtual ICollection<ComposicionProducto> ComposicionProductos { get; set; } = new List<ComposicionProducto>();
}
