using System;
using System.Collections.Generic;

namespace BACKEND_SCM.MODEL;

public partial class ExamenesHistoriaClinica
{
    public int Id { get; set; }

    public int IdPaciente { get; set; }

    public int? IdFormulario { get; set; }

    public int? IdExamen { get; set; }

    public string? Comentario { get; set; }

    public byte[]? ArchivoResultado { get; set; }

    public string? NombreArchivo { get; set; }

    public string? ExtArchivo { get; set; }

    public DateTime FechaRegistro { get; set; }

    public bool Estado { get; set; }
}
