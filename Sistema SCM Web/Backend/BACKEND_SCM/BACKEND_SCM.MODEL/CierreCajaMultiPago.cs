using System;
using System.Collections.Generic;

namespace BACKEND_SCM.MODEL;

public partial class CierreCajaMultiPago
{
    public int Id { get; set; }

    public string? TipoPago { get; set; }

    public int? IdMultiPago { get; set; }

    public decimal? Monto { get; set; }

    public int? IdApertura { get; set; }
}
