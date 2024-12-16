using System;
using System.Collections.Generic;

namespace BACKEND_SCM.MODEL;

public partial class Iva
{
    public decimal? Monto { get; set; }

    public string? CodigoSri { get; set; }

    public string? CodigoPorcIva { get; set; }
}
