using System;
using System.Collections.Generic;

namespace BACKEND_SCM.MODEL;

public partial class NotasCreditosCxc
{
    public string? Nc { get; set; }

    public long? IdVentaAfec { get; set; }

    public long? IdCliente { get; set; }

    public string? Cliente { get; set; }

    public DateOnly? FechaEmision { get; set; }

    public string? Matriz { get; set; }

    public string? Ruc { get; set; }

    public string? Direccion { get; set; }

    public string? Telefono { get; set; }

    public string? Observacion { get; set; }

    public DateTime? FechaHoraRegistro { get; set; }

    public int Id { get; set; }

    public string? TipoNc { get; set; }

    public decimal? Monto { get; set; }

    public virtual Cliente? IdClienteNavigation { get; set; }
}
