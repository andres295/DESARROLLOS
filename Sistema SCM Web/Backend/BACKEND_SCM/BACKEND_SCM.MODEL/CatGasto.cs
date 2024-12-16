using System;
using System.Collections.Generic;

namespace BACKEND_SCM.MODEL;

public partial class CatGasto
{
    public int Id { get; set; }

    public string? Descripcion { get; set; }

    public string CreateUser { get; set; } = null!;

    public bool Estado { get; set; }

    public DateTime CreateDate { get; set; }
}
