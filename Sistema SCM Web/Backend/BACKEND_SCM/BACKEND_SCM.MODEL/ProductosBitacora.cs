using System;
using System.Collections.Generic;

namespace BACKEND_SCM.MODEL;

public partial class ProductosBitacora
{
    public long Id { get; set; }

    public string? CodigoBarra { get; set; }

    public string? Producto { get; set; }

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

    public string? Accion { get; set; }

    public DateTime CreateDate { get; set; }

    public string Usuario { get; set; } = null!;

    public string? RegistroSanitario { get; set; }
}
