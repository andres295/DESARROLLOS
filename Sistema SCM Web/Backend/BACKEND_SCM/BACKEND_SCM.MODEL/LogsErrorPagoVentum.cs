using System;
using System.Collections.Generic;

namespace BACKEND_SCM.MODEL;

public partial class LogsErrorPagoVentum
{
    public int Id { get; set; }

    public DateTime FechaRegistro { get; set; }

    public int IdVenta { get; set; }

    public string? ErrorMessage { get; set; }

    public int? ErrorSeverity { get; set; }

    public int? ErrorState { get; set; }
}
