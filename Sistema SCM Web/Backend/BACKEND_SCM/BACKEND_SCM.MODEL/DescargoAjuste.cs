using System;
using System.Collections.Generic;

namespace BACKEND_SCM.MODEL;

public partial class DescargoAjuste
{
    public long Id { get; set; }

    public int? Maquina { get; set; }

    public string? Almacen { get; set; }

    public string? Movimiento { get; set; }

    public long? IdLaboratorio { get; set; }

    public string? Laboratorio { get; set; }

    public DateOnly? FechaDocumento { get; set; }

    public string? Observacion { get; set; }

    public DateTime? FechaHoraRegistro { get; set; }

    public int? IdResp { get; set; }

    public decimal? Subtotal { get; set; }

    public virtual Proveedore? IdLaboratorioNavigation { get; set; }

    public virtual Usuario? IdRespNavigation { get; set; }

    public virtual Usuario? MaquinaNavigation { get; set; }
}
