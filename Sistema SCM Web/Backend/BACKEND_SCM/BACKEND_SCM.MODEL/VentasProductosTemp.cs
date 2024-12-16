using System;
using System.Collections.Generic;

namespace BACKEND_SCM.MODEL;

public partial class VentasProductosTemp
{
    public long? IdVenta { get; set; }

    public string? IdProducto { get; set; }

    public string? Producto { get; set; }

    public string? Presentacion { get; set; }

    public string? Laboratorio { get; set; }

    public long? Vendio { get; set; }

    public decimal? Pvp { get; set; }

    public decimal? Subtotal { get; set; }

    public decimal? Iva { get; set; }

    public decimal? Descuento { get; set; }

    public decimal? TotalPagar { get; set; }

    public decimal? Ganancia { get; set; }

    public long? Contiene { get; set; }

    public long? Disponible { get; set; }

    public decimal? Parcial { get; set; }

    public string? Lote { get; set; }

    public string? VencimientoTexto { get; set; }

    public decimal? SubtotalDp { get; set; }

    public decimal? SubtotalCp { get; set; }

    public long Id { get; set; }

    public int? IdCombo { get; set; }

    public int? IdPrecioEspecial { get; set; }
}
