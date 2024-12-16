using System;
using System.Collections.Generic;

namespace BACKEND_SCM.MODEL;

public partial class TpmExamenFormularioPaciente
{
    public int Id { get; set; }

    public int IdPaciente { get; set; }

    public int IdFormulario { get; set; }

    public string? DescripcionValor { get; set; }

    public bool Estado { get; set; }

    public DateTime FechaRegistro { get; set; }

    public string? UsuarioCrea { get; set; }

    public int? IdAtecedenteFamiliar { get; set; }

    public int? IdTipoPatologiaCp { get; set; }

    public int? IdTipoPatologiaSp { get; set; }

    public int? IdSignosVitalesMediciones { get; set; }

    public int? IdExamenFisicoCp { get; set; }

    public int? IdExamenFisicoSp { get; set; }

    public int? IdDiagnosticoPresuntivoCie { get; set; }

    public int? IdDiagnosticoDefinitivoCie { get; set; }

    public string? Medicamento { get; set; }

    public string? Prescripcion { get; set; }
}
