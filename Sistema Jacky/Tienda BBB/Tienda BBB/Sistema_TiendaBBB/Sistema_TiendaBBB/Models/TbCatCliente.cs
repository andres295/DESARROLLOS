﻿using System;
using System.Collections.Generic;

namespace Sistema_TiendaBBB.Models;

public partial class TbCatCliente
{
    public int IdCliente { get; set; }

    public int IdClasificacion { get; set; }

    public int IdPago { get; set; }

    public int IdIdentificacion { get; set; }

    public int IdPais { get; set; }

    public int IdCiudad { get; set; }

    public string NombreCliente { get; set; } = null!;

    public string NumeroIdentificacion { get; set; } = null!;

    public string Direccion { get; set; } = null!;

    public DateTime? FechaRegistro { get; set; }

    public virtual TbCatCiudad IdCiudadNavigation { get; set; } = null!;

    public virtual TbCatClasificacionCte IdClasificacionNavigation { get; set; } = null!;

    public virtual TbCatTipoIdentificacion IdIdentificacionNavigation { get; set; } = null!;

    public virtual TbCatMetodoPago IdPagoNavigation { get; set; } = null!;

    public virtual TbCatPai IdPaisNavigation { get; set; } = null!;

    public virtual ICollection<TbVenta> TbVenta { get; set; } = new List<TbVenta>();
}