using System;
using System.Collections.Generic;

namespace BACKEND_SCM.MODEL;

public partial class TblcatalogosGenerale
{
    public int Id { get; set; }

    public int TipoCatalogo { get; set; }

    public string? Descripcion { get; set; }

    public decimal? PorcRetencion { get; set; }

    public string? CodAnexo { get; set; }

    public bool Estado { get; set; }

    public DateTime FechaRegistro { get; set; }
}
