using System;
using System.Collections.Generic;

namespace BACKEND_SCM.MODEL;

public partial class ExamenesGeneralHc
{
    public int Id { get; set; }

    public int IdExamen { get; set; }

    public int IdPaciente { get; set; }

    public int IdEspecialista { get; set; }

    public string? Observacion { get; set; }

    public decimal Costo { get; set; }

    public DateOnly FechaAtencion { get; set; }

    public DateTime FechaRegistro { get; set; }

    public bool Estado { get; set; }

    public string UsuarioCrea { get; set; } = null!;
}
