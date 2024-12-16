using System;
using System.Collections.Generic;

namespace BACKEND_SCM.MODEL;

public partial class ComposicionProducto
{
    public int Id { get; set; }

    public int IdComposicion { get; set; }

    public string IdProducto { get; set; } = null!;

    public DateTime FechaSistema { get; set; }

    public virtual ComposicionQuimica IdComposicionNavigation { get; set; } = null!;
}
