using System;
using System.Collections.Generic;

namespace Sistema_TiendaBBB.Models;

public partial class TbCatClasificacionArt
{
    public int IdClasificacion { get; set; }

    public string DescripcionClasificacion { get; set; } = null!;

    public DateTime? FechaRegistro { get; set; }

    public virtual ICollection<TbCatArticulo> TbCatArticulos { get; set; } = new List<TbCatArticulo>();
}
