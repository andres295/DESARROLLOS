using System;
using System.Collections.Generic;

namespace BACKEND_SCM.MODEL;

public partial class FacturasPorCobrar
{
    public long Id { get; set; }

    public long? NumVenta { get; set; }

    public string? Factura { get; set; }

    public long? IdCliente { get; set; }

    public DateOnly? FechaEmision { get; set; }

    public int? DiasPago { get; set; }

    public DateOnly? FechaVencimiento { get; set; }

    public decimal? MontoFact { get; set; }

    public decimal? MontoNc { get; set; }

    public decimal? MontoRet { get; set; }

    public decimal? MontoTotalPagar { get; set; }

    public decimal? MontoAbonado { get; set; }

    public decimal? MontoSaldo { get; set; }

    public string? Estado { get; set; }

    public bool? RetencionRenta { get; set; }

    public bool? RetencionIva { get; set; }

    public string? OrigenFactura { get; set; }

    public decimal? MontoRetIva { get; set; }

    public virtual Cliente? IdClienteNavigation { get; set; }
}
