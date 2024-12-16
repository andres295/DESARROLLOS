using System;
using System.Collections.Generic;

namespace BACKEND_SCM.MODEL;

public partial class Venta
{
    public long Id { get; set; }

    public int? Maquina { get; set; }

    public long? IdCliente { get; set; }

    public int? IdUsuario { get; set; }

    public DateTime? FechaHoraRegistro { get; set; }

    public int? Procesado { get; set; }

    public string? NameClienteTem { get; set; }

    public int? TipoVenta { get; set; }

    public string? NumDoc { get; set; }

    public int? NumeroComprobante { get; set; }

    public virtual Usuario? IdUsuarioNavigation { get; set; }

    public virtual Usuario? MaquinaNavigation { get; set; }
}
