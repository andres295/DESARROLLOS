using System;
using System.Collections.Generic;

namespace BACKEND_SCM.MODEL;

public partial class NotasCredito
{
    public string? Nc { get; set; }

    public string? IdFacturaAfec { get; set; }

    public long? IdProveedor { get; set; }

    public string? Proveedor { get; set; }

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

    public virtual Proveedore? IdProveedorNavigation { get; set; }
}
