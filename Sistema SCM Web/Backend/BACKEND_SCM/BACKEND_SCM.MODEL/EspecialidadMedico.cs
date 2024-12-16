using System;
using System.Collections.Generic;

namespace BACKEND_SCM.MODEL;

public partial class EspecialidadMedico
{
    public int Id { get; set; }

    public int IdEspecialidad { get; set; }

    public long IdMedico { get; set; }

    public DateTime FechaSistema { get; set; }

    public virtual Especialidad IdEspecialidadNavigation { get; set; } = null!;

    public virtual Especialistum IdMedicoNavigation { get; set; } = null!;
}
