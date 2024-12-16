using System;
using System.Collections.Generic;

namespace BACKEND_SCM.MODEL;

public partial class PorcentajeIva
{
    public int Id { get; set; }

    public string Descripcion { get; set; } = null!;

    public decimal Porcentaje { get; set; }

    public string Codigo { get; set; } = null!;

    public bool Estado { get; set; }

    public DateTime FechaRegistro { get; set; }
}
