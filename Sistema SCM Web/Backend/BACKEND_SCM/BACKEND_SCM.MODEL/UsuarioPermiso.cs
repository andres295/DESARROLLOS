using System;
using System.Collections.Generic;

namespace BACKEND_SCM.MODEL;

public partial class UsuarioPermiso
{
    public int Id { get; set; }

    public int IdUsuario { get; set; }

    public int IdPermiso { get; set; }

    public DateTime FechaSistema { get; set; }

    public bool? HeredarPermiso { get; set; }

    public virtual Permiso IdPermisoNavigation { get; set; } = null!;

    public virtual Usuario IdUsuarioNavigation { get; set; } = null!;
}
