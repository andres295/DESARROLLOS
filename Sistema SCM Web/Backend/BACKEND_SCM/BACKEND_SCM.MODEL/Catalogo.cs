using System;
using System.Collections.Generic;

namespace BACKEND_SCM.MODEL;

public partial class Catalogo
{
    public int Id { get; set; }

    public string? Descripcion { get; set; }

    public int IdTipoCatalogo { get; set; }

    public bool Estado { get; set; }

    public DateTime FechaRegistro { get; set; }

    public string? Codigo { get; set; }
}
