using System;
using System.Collections.Generic;

namespace BACKEND_SCM.MODEL;

public partial class Paciente
{
    public long Id { get; set; }

    public string Cedula { get; set; } = null!;

    public string? Ruc { get; set; }

    public string? NombresApellidos { get; set; }

    public string? Telefono { get; set; }

    public string? Direccion { get; set; }

    public string? Correo { get; set; }

    public decimal? Saldo { get; set; }

    public long? Edad { get; set; }

    public DateOnly? Nacimiento { get; set; }

    public string? Genero { get; set; }

    public string? Padre { get; set; }

    public int? IdTipoSangre { get; set; }

    public int? IdEstadoCivil { get; set; }

    public int? IdNacionalidad { get; set; }

    public string? Convencional { get; set; }

    public int? IdInstruccion { get; set; }

    public string? Foto { get; set; }
}
