using System;
using System.Collections.Generic;

namespace Sistema_TiendaBBB.Models;

public partial class TbCatPai
{
    public int IdPais { get; set; }

    public string DescripcionPais { get; set; } = null!;

    public DateTime? FechaRegistro { get; set; }

    public virtual ICollection<TbCatCliente> TbCatClientes { get; set; } = new List<TbCatCliente>();

    public virtual ICollection<TbCatProveedor> TbCatProveedors { get; set; } = new List<TbCatProveedor>();
}
