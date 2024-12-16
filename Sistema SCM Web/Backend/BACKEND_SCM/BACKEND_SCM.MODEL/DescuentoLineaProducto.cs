using System;
using System.Collections.Generic;

namespace BACKEND_SCM.MODEL;

public partial class DescuentoLineaProducto
{
    public int Id { get; set; }

    public string? Descripcion { get; set; }

    public decimal? Porcentaje { get; set; }

    public DateOnly? VenceDesde { get; set; }

    public DateOnly? VenceHasta { get; set; }

    public string CreateUser { get; set; } = null!;

    public bool Estado { get; set; }

    public DateTime CreateDate { get; set; }

    public virtual ICollection<DescuentoLineaProductoDet> DescuentoLineaProductoDets { get; set; } = new List<DescuentoLineaProductoDet>();
}
