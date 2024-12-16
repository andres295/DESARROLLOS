using System;
using System.Collections.Generic;

namespace BACKEND_SCM.MODEL;

public partial class DescuentoComboProducto
{
    public int Id { get; set; }

    public int IdDescuentoCombo { get; set; }

    public long? IdProducto { get; set; }

    public virtual DescuentoCombo IdDescuentoComboNavigation { get; set; } = null!;
}
