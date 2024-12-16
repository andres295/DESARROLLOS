using System;
using System.Collections.Generic;

namespace BACKEND_SCM.MODEL;

public partial class CitaPaciente
{
    public long Id { get; set; }

    public long IdPaciente { get; set; }

    public long IdServicio { get; set; }

    public DateOnly FechaCita { get; set; }

    public TimeOnly HoraCita { get; set; }

    public TimeOnly HoraFinCita { get; set; }

    public string? Observacion { get; set; }

    public bool Estado { get; set; }

    public DateTime FechaSistema { get; set; }

    public bool Atendida { get; set; }

    public int? IdDoctor { get; set; }
}
