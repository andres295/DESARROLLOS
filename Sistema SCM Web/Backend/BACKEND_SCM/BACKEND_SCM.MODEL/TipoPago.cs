using System;
using System.Collections.Generic;

namespace BACKEND_SCM.MODEL;

public partial class TipoPago
{
    public int Id { get; set; }

    public string? Tipo { get; set; }

    public bool Estado { get; set; }

    public DateTime FechaRegistro { get; set; }

    public string? CodigoSri { get; set; }
}
