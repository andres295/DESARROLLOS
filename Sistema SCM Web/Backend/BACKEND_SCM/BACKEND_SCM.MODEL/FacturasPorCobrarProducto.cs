using System;
using System.Collections.Generic;

namespace BACKEND_SCM.MODEL;

public partial class FacturasPorCobrarProducto
{
    public long? IdVenta { get; set; }

    public string? IdProducto { get; set; }

    public string? Producto { get; set; }

    public string? Presentacion { get; set; }

    public int? Cantidad { get; set; }

    public int? Bonificacion { get; set; }

    public decimal? Pvf { get; set; }

    public decimal? Pvp { get; set; }

    public decimal? Subtotal { get; set; }

    public decimal? Iva { get; set; }

    public decimal? Descuento { get; set; }

    public decimal? Total { get; set; }

    public long? Contiene { get; set; }

    public DateOnly? FechaRegistro { get; set; }

    public TimeOnly? HoraRegistro { get; set; }

    public int? IdUsuario { get; set; }

    public long? Disponible { get; set; }

    public decimal? Pur { get; set; }

    public decimal? UtilidadPorc { get; set; }

    public DateOnly? FechaVencimiento { get; set; }

    public string? Lote { get; set; }

    public virtual Usuario? IdUsuarioNavigation { get; set; }
}
