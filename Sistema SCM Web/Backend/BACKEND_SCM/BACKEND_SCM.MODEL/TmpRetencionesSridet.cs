using System;
using System.Collections.Generic;

namespace BACKEND_SCM.MODEL;

public partial class TmpRetencionesSridet
{
    public int Id { get; set; }

    public string ImpuestoRetener { get; set; } = null!;

    public int ValorImpuesto { get; set; }

    public decimal BaseImponible { get; set; }

    public decimal PorcRetencion { get; set; }

    public decimal ValorRetenido { get; set; }

    public int IdUsuario { get; set; }
}
