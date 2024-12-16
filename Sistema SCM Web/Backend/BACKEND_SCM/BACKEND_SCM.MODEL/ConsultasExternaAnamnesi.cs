using System;
using System.Collections.Generic;

namespace BACKEND_SCM.MODEL;

public partial class ConsultasExternaAnamnesi
{
    public int Id { get; set; }

    public DateTime FechaSistema { get; set; }

    public bool EstadoConsulta { get; set; }

    public long IdPaciente { get; set; }

    public DateOnly FechaAtencion { get; set; }

    public TimeOnly Hora { get; set; }

    public string? HitoriaClinica { get; set; }

    public string? TxtMotivoConsultaA { get; set; }

    public string? TxtMotivoConsultaB { get; set; }

    public string? TxtMotivoConsultaC { get; set; }

    public string? TxtMotivoConsultaD { get; set; }

    public string? TxtAntecedentesPersonalesA { get; set; }

    public string? TxtAntecedentesPersonalesB { get; set; }

    public string? TxtAntecedentesPersonalesC { get; set; }

    public string? TxtAntecedentesPersonalesD { get; set; }

    public string? TxtAntecedentesFamiliaresA { get; set; }

    public string? TxtAntecedentesFamiliaresB { get; set; }

    public string? TxtAntecedentesFamiliaresC { get; set; }

    public string? TxtAntecedentesFamiliaresD { get; set; }

    public string? TxtEnfermedadProblemaActualA { get; set; }

    public string? TxtEnfermedadProblemaActualB { get; set; }

    public string? TxtEnfermedadProblemaActualC { get; set; }

    public string? TxtEnfermedadProblemaActualD { get; set; }

    public string? TxtRevisionOrganoSistemaA { get; set; }

    public string? TxtRevisionOrganoSistemaB { get; set; }

    public string? TxtRevisionOrganoSistemaC { get; set; }

    public string? TxtRevisionOrganoSistemaD { get; set; }

    public string? TxtSignoVitalMedicionTemporalBucal { get; set; }

    public string? TxtSignoVitalMedicionTemporalAuxiliar { get; set; }

    public string? TxtSignoVitalMedicionFrecuenciaRespitatoria { get; set; }

    public string? TxtSignoVitalMedicionCircunferenciaCuello { get; set; }

    public string? TxtSignoVitalMedicionPeso { get; set; }

    public string? TxtSignoVitalMedicionTalla { get; set; }

    public string? TxtSignoVitalMedicionPerimetroCintura { get; set; }

    public string? TxtSignoVitalMedicionPerimetroCadera { get; set; }

    public string? TxtSignoVitalMedicionPerimetroCefalico { get; set; }

    public string? TxtExamenFisicoA { get; set; }

    public string? TxtExamenFisicoB { get; set; }

    public string? TxtExamenFisicoC { get; set; }

    public string? TxtExamenFisicoD { get; set; }

    public string? TxtDiagnosticoPresuntivoDiagnostico { get; set; }

    public string? TxtDiagnosticoPresuntivoCie { get; set; }

    public string? TxtTratamientoPresuntivoA { get; set; }

    public string? TxtTratamientoPresuntivoB { get; set; }

    public DateOnly? DtFechaEvolucionMedicamentoA { get; set; }

    public DateOnly? DtFechaEvolucionMedicamentoB { get; set; }

    public string? TxtPrescipcion1 { get; set; }

    public string? TxtPrescipcion2 { get; set; }

    public string? TxtPrescipcion3 { get; set; }

    public string? TxtPrescipcion4 { get; set; }

    public string? TxtPrescipcion5 { get; set; }

    public string? TxtPrescipcion6 { get; set; }

    public string? TxtDiagnosticoDefinitivoDiagnostico { get; set; }

    public string? TxtDiagnosticoDefinitivoCie { get; set; }

    public string? TxtTratamientoDefinitivo { get; set; }
}
