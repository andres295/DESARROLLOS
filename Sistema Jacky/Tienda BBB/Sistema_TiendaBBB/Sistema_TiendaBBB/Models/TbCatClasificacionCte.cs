using System;
using System.Collections.Generic;

namespace Sistema_TiendaBBB.Models;

public partial class TbCatClasificacionCte
{
    public int IdClasificacion { get; set; }

    public string DescripcionClasificacion { get; set; } = null!;

    public DateTime? FechaRegistro { get; set; }

    public virtual ICollection<TbCatCliente> TbCatClientes { get; set; } = new List<TbCatCliente>();
}
