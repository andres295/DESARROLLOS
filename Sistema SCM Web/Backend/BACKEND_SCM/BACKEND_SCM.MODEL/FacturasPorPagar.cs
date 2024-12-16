using System;
using System.Collections.Generic;

namespace BACKEND_SCM.MODEL;

public partial class FacturasPorPagar
{
    public string? Factura { get; set; }

    public long? IdProveedor { get; set; }

    public DateOnly? FechaEmision { get; set; }

    public int? DiasPago { get; set; }

    public DateOnly? FechaVencimiento { get; set; }

    public decimal? MontoFact { get; set; }

    public decimal? MontoNc { get; set; }

    public decimal? MontoTotalPagar { get; set; }

    public string? Estado { get; set; }

    public decimal? MontoRetencion { get; set; }

    public virtual Proveedore? IdProveedorNavigation { get; set; }
}
