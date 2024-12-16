using System;
using System.Collections.Generic;

namespace BACKEND_SCM.MODEL;

public partial class AdminRegistroGasto
{
    public int Id { get; set; }

    public int IdGasto { get; set; }

    public decimal? Monto { get; set; }

    public DateOnly? Fecha { get; set; }

    public string CreateUser { get; set; } = null!;

    public bool Estado { get; set; }

    public DateTime CreateDate { get; set; }

    public DateOnly? FechaElimina { get; set; }

    public string? UserElimina { get; set; }
}
