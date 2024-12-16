using System;
using System.Collections.Generic;

namespace Sistema_TiendaBBB.Models;

public partial class TbCatArticulo
{
    public int IdArticulo { get; set; }

    public string DescripcionArticulo { get; set; } = null!;

    public int? IdClasificacion { get; set; }

    public int? IdPresentacion { get; set; }

    public int Disponible { get; set; }

    public decimal CostoUnitario { get; set; }

    public decimal PrecioVenta { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public int? IdProveedor { get; set; }

    public virtual TbCatClasificacionArt? IdClasificacionNavigation { get; set; }

    public virtual TbCatPresentacionArt? IdPresentacionNavigation { get; set; }

    public virtual TbCatProveedor? IdProveedorNavigation { get; set; }

    public virtual ICollection<TbVenta> TbVenta { get; set; } = new List<TbVenta>();
}
