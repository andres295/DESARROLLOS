using System;
using System.Collections.Generic;

namespace SOLTECSA.Models;

public partial class Empleado
{
    public int IdEmpleado { get; set; }

    public string Nombre { get; set; } = null!;

    public DateOnly FechaNacimiento { get; set; }

    public int? Edad { get; set; }

    public string Dirección { get; set; } = null!;

    public string? EstadoCivil { get; set; }

    public string Padre { get; set; } = null!;

    public string? Madre { get; set; }

    public string? Hijos { get; set; }

    public string? EstudiosPrimaria { get; set; }

    public string? EstudiosSecundaria { get; set; }

    public string? EstudiosUniversitario { get; set; }

    public string? EstudiosPostgrado { get; set; }

    public string? EstudiosTecnicos { get; set; }

    public string? EstudiosCertificaciones { get; set; }

    public string? EstudiosDiplomado { get; set; }

    public string? EstudiosDoctorado { get; set; }

    public decimal Salario { get; set; }

    public string? Cedula { get; set; }

    public virtual ICollection<Nomina> Nominas { get; set; } = new List<Nomina>();
}
