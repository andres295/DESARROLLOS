using System;
using System.Collections.Generic;

namespace SOLTECSA.Models;

public partial class Nomina
{
    public int IdNomina { get; set; }

    public int IdEmpleado { get; set; }

    public decimal Inns { get; set; }

    public decimal Ir { get; set; }

    public decimal Salario { get; set; }

    public decimal Quincena { get; set; }

    public virtual Empleado IdEmpleadoNavigation { get; set; } = null!;
}
