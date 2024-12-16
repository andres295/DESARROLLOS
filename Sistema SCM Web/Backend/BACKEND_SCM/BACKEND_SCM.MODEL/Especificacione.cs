using System;
using System.Collections.Generic;

namespace BACKEND_SCM.MODEL;

public partial class Especificacione
{
    public long Id { get; set; }

    public string? Especificacion { get; set; }

    public virtual ICollection<Producto> Productos { get; set; } = new List<Producto>();
}
