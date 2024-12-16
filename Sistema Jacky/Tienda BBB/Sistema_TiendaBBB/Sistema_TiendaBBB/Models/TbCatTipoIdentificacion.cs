using System;
using System.Collections.Generic;

namespace Sistema_TiendaBBB.Models;

public partial class TbCatTipoIdentificacion
{
    public int IdIdentificacion { get; set; }

    public string DescripcionIdentificacion { get; set; } = null!;

    public DateTime? FechaRegistro { get; set; }

    public virtual ICollection<TbCatCliente> TbCatClientes { get; set; } = new List<TbCatCliente>();

    public virtual ICollection<TbCatProveedor> TbCatProveedors { get; set; } = new List<TbCatProveedor>();
}
