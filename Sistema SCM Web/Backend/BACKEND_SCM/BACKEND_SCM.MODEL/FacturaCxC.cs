using System;
using System.Collections.Generic;

namespace BACKEND_SCM.MODEL;

public partial class FacturaCxC
{
    public long Id { get; set; }

    public int IdVenta { get; set; }

    public int IdUsuario { get; set; }

    public string? Observacion { get; set; }

    public bool Estado { get; set; }

    public DateTime FechaHoraRegistro { get; set; }

    public decimal Subtotal { get; set; }

    public decimal Descuento { get; set; }

    public decimal Total { get; set; }

    public int IdCliente { get; set; }

    public int IdEspecialista { get; set; }

    public decimal Saldo { get; set; }

    public decimal Abono { get; set; }

    public string Moneda { get; set; } = null!;

    public int TipoVenta { get; set; }

    public decimal TipoCambio { get; set; }

    public int? Procesado { get; set; }

    public string? NumDoc { get; set; }

    public int? NumeroComprobante { get; set; }
}
