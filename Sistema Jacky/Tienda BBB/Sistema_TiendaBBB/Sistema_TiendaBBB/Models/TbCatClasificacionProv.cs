using System;
using System.Collections.Generic;

namespace Sistema_TiendaBBB.Models;

public partial class TbCatClasificacionProv
{
    public int IdClasificacion { get; set; }

    public string DescripcionClasificacion { get; set; } = null!;

    public DateTime? FechaRegistro { get; set; }

    public virtual ICollection<TbCatProveedor> TbCatProveedors { get; set; } = new List<TbCatProveedor>();
}
