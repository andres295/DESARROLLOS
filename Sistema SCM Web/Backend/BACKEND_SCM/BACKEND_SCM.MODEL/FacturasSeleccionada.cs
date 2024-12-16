using System;
using System.Collections.Generic;

namespace BACKEND_SCM.MODEL;

public partial class FacturasSeleccionada
{
    public int? Maquina { get; set; }

    public string? Factura { get; set; }

    public decimal? Monto { get; set; }

    public virtual Usuario? MaquinaNavigation { get; set; }
}
