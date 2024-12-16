using System;
using System.Collections.Generic;

namespace BACKEND_SCM.MODEL;

public partial class Cliente
{
    public long Id { get; set; }

    public string? Cedula { get; set; }

    public string? Ruc { get; set; }

    public string? NombresApellidos { get; set; }

    public string? Telefono { get; set; }

    public string? Direccion { get; set; }

    public string? Correo { get; set; }

    public string? Ciudad { get; set; }

    public int? TipoDocumento { get; set; }

    public virtual ICollection<FacturasPorCobrar> FacturasPorCobrars { get; set; } = new List<FacturasPorCobrar>();

    public virtual ICollection<NotasCreditosCxc> NotasCreditosCxcs { get; set; } = new List<NotasCreditosCxc>();
}
