using System;
using System.Collections.Generic;

namespace Sistema_TiendaBBB.Models;

public partial class TbCatPresentacionArt
{
    public int IdPresentacion { get; set; }

    public string DescripcionPresentacion { get; set; } = null!;

    public DateTime? FechaRegistro { get; set; }

    public virtual ICollection<TbCatArticulo> TbCatArticulos { get; set; } = new List<TbCatArticulo>();
}
