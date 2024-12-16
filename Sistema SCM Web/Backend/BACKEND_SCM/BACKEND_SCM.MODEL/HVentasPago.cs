using System;
using System.Collections.Generic;

namespace BACKEND_SCM.MODEL;

public partial class HVentasPago
{
    public long IdVenta { get; set; }

    public decimal? MontoEfectivo { get; set; }

    public string? Cheque { get; set; }

    public DateOnly? FechaCobro { get; set; }

    public int? IdBanco { get; set; }

    public decimal? ChequeMonto { get; set; }

    public string? ImagenCheque { get; set; }

    public string? Tranf { get; set; }

    public decimal? MontoTranf { get; set; }

    public string? ImagenTranf { get; set; }

    public decimal? MontoTc { get; set; }

    public decimal? MontoTd { get; set; }

    public string? Adquirente { get; set; }

    public decimal? TcInteres { get; set; }

    public int? TipoPago { get; set; }
}
