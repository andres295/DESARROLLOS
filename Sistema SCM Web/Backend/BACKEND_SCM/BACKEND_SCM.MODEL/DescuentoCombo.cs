using System;
using System.Collections.Generic;

namespace BACKEND_SCM.MODEL;

public partial class DescuentoCombo
{
    public int Id { get; set; }

    public string? Descripcion { get; set; }

    public decimal? PrecioCombo { get; set; }

    public long? CantMin { get; set; }

    public long? CantMax { get; set; }

    public DateOnly? VenceDesde { get; set; }

    public DateOnly? VenceHasta { get; set; }

    public string CreateUser { get; set; } = null!;

    public bool Estado { get; set; }

    public DateTime CreateDate { get; set; }

    public virtual ICollection<DescuentoComboProducto> DescuentoComboProductos { get; set; } = new List<DescuentoComboProducto>();
}
