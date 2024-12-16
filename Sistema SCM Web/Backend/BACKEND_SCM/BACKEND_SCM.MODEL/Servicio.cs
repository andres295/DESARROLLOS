using System;
using System.Collections.Generic;

namespace BACKEND_SCM.MODEL;

public partial class Servicio
{
    public int Id { get; set; }

    public string? Servicio1 { get; set; }

    public decimal? Costo { get; set; }

    public long? TiempoEjecucion { get; set; }

    public string? Descripcion { get; set; }

    public DateTime FechaRegistro { get; set; }

    public bool Estado { get; set; }
}
