using System;
using System.Collections.Generic;

namespace BACKEND_SCM.MODEL;

public partial class CargoCompra
{
    public string? Factura { get; set; }

    public int? IdProveedor { get; set; }

    public DateOnly? FechaDocumento { get; set; }

    public int? DiasPago { get; set; }

    public DateOnly? FechaPago { get; set; }

    public decimal? Iva { get; set; }

    public decimal? DescPorc { get; set; }

    public string? Observacion { get; set; }

    public string? Estado { get; set; }

    public DateTime? FechaHoraReg { get; set; }

    public int Id { get; set; }
}
