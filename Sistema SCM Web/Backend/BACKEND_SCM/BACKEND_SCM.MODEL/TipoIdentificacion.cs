using System;
using System.Collections.Generic;

namespace BACKEND_SCM.MODEL;

public partial class TipoIdentificacion
{
    public int Id { get; set; }

    public string? TipoIdentificacion1 { get; set; }

    public string? Codigo { get; set; }

    public bool Estado { get; set; }

    public DateTime FechaRegistro { get; set; }
}
