using System;
using System.Collections.Generic;

namespace BACKEND_SCM.MODEL;

public partial class Producto
{
    public long Id { get; set; }

    public string? CodigoBarra { get; set; }

    public string? Producto1 { get; set; }

    public long? IdPresentacion { get; set; }

    public long? IdProveedor { get; set; }

    public decimal? Pvf { get; set; }

    public decimal? Pvp { get; set; }

    public int? Contiene { get; set; }

    public DateOnly? Vencimiento { get; set; }

    public string? Estado { get; set; }

    public decimal? Descuento { get; set; }

    public DateOnly? DescuentoDesde { get; set; }

    public DateOnly? DescuentoHasta { get; set; }

    public long? Disponible { get; set; }

    public string? Lote { get; set; }

    public string? Foto { get; set; }

    public decimal? Iva { get; set; }

    public decimal? Pur { get; set; }

    public decimal? Utilidad { get; set; }

    public long? IdEspecificacion { get; set; }

    public int? IdComposicion { get; set; }

    public bool? PvpIva { get; set; }

    public string? RegistroSanitario { get; set; }

    public virtual ICollection<DescuentoCategorium> DescuentoCategoria { get; set; } = new List<DescuentoCategorium>();

    public virtual ICollection<DescuentoLineaProductoDet> DescuentoLineaProductoDets { get; set; } = new List<DescuentoLineaProductoDet>();

    public virtual ICollection<IdDetalleVentum> IdDetalleVenta { get; set; } = new List<IdDetalleVentum>();

    public virtual Especificacione? IdEspecificacionNavigation { get; set; }

    public virtual Presentacione? IdPresentacionNavigation { get; set; }

    public virtual Proveedore? IdProveedorNavigation { get; set; }
}
