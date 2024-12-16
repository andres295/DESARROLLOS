using System;
using System.Collections.Generic;

namespace BACKEND_SCM.MODEL;

public partial class BuzonPedido
{
    public string? Id { get; set; }

    public string? Producto { get; set; }

    public string? Presentacion { get; set; }

    public string? Laboratorio { get; set; }

    public double? Cantidad { get; set; }

    public double? Pvf { get; set; }

    public double? Subtotal { get; set; }

    public string? Fraccion { get; set; }

    public long? Contiene { get; set; }

    public DateOnly? FechaRegistro { get; set; }

    public TimeOnly? HoraRegistro { get; set; }
}
