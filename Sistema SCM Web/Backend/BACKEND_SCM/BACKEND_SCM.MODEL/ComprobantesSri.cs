using System;
using System.Collections.Generic;

namespace BACKEND_SCM.MODEL;

public partial class ComprobantesSri
{
    public int Id { get; set; }

    public string ClaveAcceso { get; set; } = null!;

    public string TipoDocumento { get; set; } = null!;

    public string NumeroComprobante { get; set; } = null!;

    public DateOnly FechaDocumento { get; set; }

    public DateOnly FechaEmision { get; set; }

    public DateTime? FechaAutorizacion { get; set; }

    public DateOnly? FechaDevolucion { get; set; }

    public DateOnly? FechaRechazo { get; set; }

    public string UsuarioEnviaSri { get; set; } = null!;

    public string UsuarioGeneraDocumento { get; set; } = null!;

    public string EstadoEnvioSri { get; set; } = null!;

    public string IdGestor { get; set; } = null!;

    public decimal? TotalSinImpuestos { get; set; }

    public decimal? ImporteTotal { get; set; }

    public string MensajeRecepcionSri { get; set; } = null!;

    public string? NoFactura { get; set; }

    public string? Ambiente { get; set; }

    public string? Emision { get; set; }
}
