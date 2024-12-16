using System;
using System.Collections.Generic;

namespace BACKEND_SCM.MODEL;

public partial class ExamenPaciente
{
    public int Id { get; set; }

    public int? IdCita { get; set; }

    public int IdPaciente { get; set; }

    public DateOnly FechaAtencion { get; set; }

    public DateTime Hora { get; set; }

    public DateTime FechaRegistro { get; set; }

    public bool Estado { get; set; }

    public string? UsuarioCrea { get; set; }
}
