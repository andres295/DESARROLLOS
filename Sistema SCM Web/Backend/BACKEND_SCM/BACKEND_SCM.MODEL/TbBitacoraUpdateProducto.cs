using System;
using System.Collections.Generic;

namespace BACKEND_SCM.MODEL;

public partial class TbBitacoraUpdateProducto
{
    public int Id { get; set; }

    public int IdProducto { get; set; }

    public long Disponible { get; set; }

    public int? Contiene { get; set; }

    public string? CodigoBarra { get; set; }

    public string? Producto { get; set; }

    public string UserUpdate { get; set; } = null!;

    public DateTime DateLog { get; set; }
}
