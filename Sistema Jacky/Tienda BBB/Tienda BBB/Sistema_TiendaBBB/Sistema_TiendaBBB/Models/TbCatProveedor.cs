using System;
using System.Collections.Generic;

namespace Sistema_TiendaBBB.Models;

public partial class TbCatProveedor
{
    public int IdProveedor { get; set; }

    public int IdClasificacion { get; set; }

    public int IdPago { get; set; }

    public int IdIdentificacion { get; set; }

    public int IdPais { get; set; }

    public int IdCiudad { get; set; }

    public string NombreProveedor { get; set; } = null!;

    public string NumeroIdentificacion { get; set; } = null!;

    public string Direccion { get; set; } = null!;

    public DateTime? FechaRegistro { get; set; }

    public virtual TbCatCiudad IdCiudadNavigation { get; set; } = null!;

    public virtual TbCatClasificacionProv IdClasificacionNavigation { get; set; } = null!;

    public virtual TbCatTipoIdentificacion IdIdentificacionNavigation { get; set; } = null!;

    public virtual TbCatMetodoPago IdPagoNavigation { get; set; } = null!;

    public virtual TbCatPai IdPaisNavigation { get; set; } = null!;

    public virtual ICollection<TbCatArticulo> TbCatArticulos { get; set; } = new List<TbCatArticulo>();
}
