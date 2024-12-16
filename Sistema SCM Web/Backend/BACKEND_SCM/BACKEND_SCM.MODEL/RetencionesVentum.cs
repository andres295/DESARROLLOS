using System;
using System.Collections.Generic;

namespace BACKEND_SCM.MODEL;

public partial class RetencionesVentum
{
    public int Id { get; set; }

    public DateTime Fecha { get; set; }

    public int IdCliente { get; set; }

    public DateTime FechaEmision { get; set; }

    public string TipoDocumento { get; set; } = null!;

    public string NumDocumento { get; set; } = null!;

    public DateTime PeriodoFiscal { get; set; }

    public decimal? TotalValorRetenido { get; set; }

    public int NumConsecutivoSri { get; set; }

    public bool Estado { get; set; }

    public DateTime FechaRegistro { get; set; }

    public int IdUsuarioRegistro { get; set; }

    public string? ClaveAcceso { get; set; }

    public decimal? TotalValorRetenidoIva { get; set; }
}
