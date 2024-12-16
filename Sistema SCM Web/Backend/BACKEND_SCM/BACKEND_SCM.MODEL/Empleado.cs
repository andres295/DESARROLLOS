using System;
using System.Collections.Generic;

namespace BACKEND_SCM.MODEL;

public partial class Empleado
{
    public long Id { get; set; }

    public string? Cedula { get; set; }

    public string? NombresApellidos { get; set; }

    public string? Genero { get; set; }

    public DateOnly? Nacimiento { get; set; }

    public string? Profesion { get; set; }

    public string? Telefono { get; set; }

    public string? Direccion { get; set; }
}
