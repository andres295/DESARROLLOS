using System;
using System.Collections.Generic;

namespace BACKEND_SCM.MODEL;

public partial class Permiso
{
    public int Id { get; set; }

    public string NumVentana { get; set; } = null!;

    public string Ventanas { get; set; } = null!;

    public DateTime FechaSistema { get; set; }

    public bool Estado { get; set; }

    public virtual ICollection<UsuarioPermiso> UsuarioPermisos { get; set; } = new List<UsuarioPermiso>();
}
