using System;
using System.Collections.Generic;

namespace BACKEND_SCM.MODEL;

public partial class VentaPrecioEspecial
{
    public int Id { get; set; }

    public int IdVenta { get; set; }

    public long? IdDetVenta { get; set; }

    public long? IdProducto { get; set; }

    public decimal? PrecioEspecial { get; set; }

    public decimal? Cantidad { get; set; }

    public string? Estado { get; set; }

    public int? UsuarioSolicita { get; set; }

    public int? UsuarioAprueba { get; set; }

    public int? UsuarioRechaza { get; set; }

    public DateTime CreateDate { get; set; }

    public DateTime? FechaAprueba { get; set; }

    public DateTime? FechaRechaza { get; set; }
}
