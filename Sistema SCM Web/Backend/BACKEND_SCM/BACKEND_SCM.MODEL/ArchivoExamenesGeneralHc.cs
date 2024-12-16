using System;
using System.Collections.Generic;

namespace BACKEND_SCM.MODEL;

public partial class ArchivoExamenesGeneralHc
{
    public int Id { get; set; }

    public int IdExamenGeneralHc { get; set; }

    public byte[]? ArchivoResultado { get; set; }

    public string? NombreArchivo { get; set; }

    public string? ExtArchivo { get; set; }

    public DateTime FechaRegistro { get; set; }

    public bool Estado { get; set; }
}
