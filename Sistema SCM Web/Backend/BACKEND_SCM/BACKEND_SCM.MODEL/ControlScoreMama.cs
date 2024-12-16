using System;
using System.Collections.Generic;

namespace BACKEND_SCM.MODEL;

public partial class ControlScoreMama
{
    public int Id { get; set; }

    public int IdPaciente { get; set; }

    public int? IdFormulario { get; set; }

    public DateOnly FechaAtencion { get; set; }

    public DateTime Hora { get; set; }

    public bool Estado { get; set; }

    public DateTime FechaRegistro { get; set; }

    public int? IdControScore1 { get; set; }

    public int? IdControScore2 { get; set; }

    public int? IdControScore3 { get; set; }

    public int? IdControScore4 { get; set; }

    public int? IdControScore5 { get; set; }

    public int? IdControScore6 { get; set; }

    public int? IdControScore7 { get; set; }

    public int? IdControScore8 { get; set; }

    public int? IdControScore9 { get; set; }

    public int? IdControScore10 { get; set; }

    public int? ValorScore1 { get; set; }

    public int? ValorScore2 { get; set; }

    public int? ValorScore3 { get; set; }

    public int? ValorScore4 { get; set; }

    public int? ValorScore5 { get; set; }

    public int? ValorScore6 { get; set; }

    public int? ValorScore7 { get; set; }

    public int? ValorScore8 { get; set; }

    public int? ValorScore9 { get; set; }

    public int? ValorScore10 { get; set; }

    public int? PuntajeScore1 { get; set; }

    public int? PuntajeScore2 { get; set; }

    public int? PuntajeScore3 { get; set; }

    public int? PuntajeScore4 { get; set; }

    public int? PuntajeScore5 { get; set; }

    public int? PuntajeScore6 { get; set; }

    public int? PuntajeScore7 { get; set; }

    public int? PuntajeScore8 { get; set; }

    public int? PuntajeScore9 { get; set; }

    public int? PuntajeScore10 { get; set; }

    public string? Responsable { get; set; }
}
