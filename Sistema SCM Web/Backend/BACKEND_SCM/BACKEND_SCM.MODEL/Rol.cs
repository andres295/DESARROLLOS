using System;
using System.Collections.Generic;

namespace BACKEND_SCM.MODEL;

public partial class Rol
{
    public int IdRol { get; set; }

    public string? Nombre { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public virtual ICollection<MenuRol> MenuRols { get; set; } = new List<MenuRol>();

    public virtual ICollection<UsuariosWeb> UsuariosWebs { get; set; } = new List<UsuariosWeb>();
}
