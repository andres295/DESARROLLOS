using System;
using System.Collections.Generic;

namespace BACKEND_SCM.MODEL;

public partial class StockProducto
{
    public string? IdFactura { get; set; }

    public int? IdVenta { get; set; }

    public string? IdProducto { get; set; }

    public string? Producto { get; set; }

    public long? IdPresentacion { get; set; }

    public long? IdProveedor { get; set; }

    public int? Contiene { get; set; }

    public decimal? Pvf { get; set; }

    public int? Cantidad { get; set; }

    public int? Bonificacion { get; set; }

    public decimal? Subtotal { get; set; }

    public decimal? Iva { get; set; }

    public decimal? Descuento { get; set; }

    public decimal? TotalPagar { get; set; }

    public int? IdUsuario { get; set; }

    public decimal? Pur { get; set; }

    public decimal? Utilidad { get; set; }

    public DateOnly? Vencimiento { get; set; }

    public string? Lote { get; set; }

    public int? Stock { get; set; }

    public string? TipoMovimiento { get; set; }

    public int? IdStockCredito { get; set; }

    public bool Estado { get; set; }

    public DateTime FechaRegistro { get; set; }

    public DateTime? FechaAnula { get; set; }

    public long Id { get; set; }

    public virtual Proveedore? IdProveedorNavigation { get; set; }

    public virtual Usuario? IdUsuarioNavigation { get; set; }
}
