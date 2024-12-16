using System;
using System.Collections.Generic;

namespace BACKEND_SCM.MODEL;

public partial class DescargoTransferenciaProductosTemp
{
    public int? Maquina { get; set; }

    public long IdFactura { get; set; }

    public string IdProducto { get; set; } = null!;

    public string? Producto { get; set; }

    public string? Presentacion { get; set; }

    public int? Cantidad { get; set; }

    public decimal? Pvf { get; set; }

    public decimal? Pvp { get; set; }

    public decimal? Subtotal { get; set; }

    public int? Contiene { get; set; }

    public long? Disponible { get; set; }

    public string? CantidadTexto { get; set; }

    public string? DisponibleTexto { get; set; }

    public DateOnly? FechaVence { get; set; }

    public string? Lote { get; set; }

    public int Id { get; set; }
}
