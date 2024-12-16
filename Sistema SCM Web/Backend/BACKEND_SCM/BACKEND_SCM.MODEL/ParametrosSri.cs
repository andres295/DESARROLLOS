using System;
using System.Collections.Generic;

namespace BACKEND_SCM.MODEL;

public partial class ParametrosSri
{
    public int Id { get; set; }

    public bool ServicioSractivo { get; set; }

    public string Ambiente { get; set; } = null!;

    public string TipoEmision { get; set; } = null!;

    public string TipoDocumentoFactura { get; set; } = null!;

    public string RazonSocial { get; set; } = null!;

    public string NombreComercial { get; set; } = null!;

    public string Codestablecimiento { get; set; } = null!;

    public string Codpuntoemision { get; set; } = null!;

    public string DirMatri { get; set; } = null!;

    public string DirEstablecimiento { get; set; } = null!;

    public string ObligadoContabilidad { get; set; } = null!;

    public string CodigoNumerico { get; set; } = null!;

    public string Moneda { get; set; } = null!;

    public DateOnly? VigenciaLicenciaDesde { get; set; }

    public DateOnly? VigenciaLicenciaHasta { get; set; }

    public string? Regimen { get; set; }

    public string? CorreoSmtp { get; set; }

    public string? ContrasenaSmtp { get; set; }

    public string? RutaXml { get; set; }

    public string? ImpresoraTickets { get; set; }

    public string? UrlSriLocal { get; set; }

    public string? TipoDocumentoRetencion { get; set; }

    public bool EsAgenteRetencion { get; set; }

    public string? CodigoAgenteRetencion { get; set; }

    public string? NumContribuyente { get; set; }

    public decimal? MontoMinimoConsumidorFinal { get; set; }

    public string? CodDocSustento { get; set; }
}
