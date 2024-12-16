using System;
using System.Collections.Generic;

namespace BACKEND_SCM.MODEL;

public partial class Especialidad
{
    public int Id { get; set; }

    public string? Descripcion { get; set; }

    public bool Estado { get; set; }

    public DateTime FechaRegistro { get; set; }
}
