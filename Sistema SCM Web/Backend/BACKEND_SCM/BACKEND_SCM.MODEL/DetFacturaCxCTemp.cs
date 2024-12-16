using System;
using System.Collections.Generic;

namespace BACKEND_SCM.MODEL;

public partial class DetFacturaCxCTemp
{
    public long Id { get; set; }

    public int IdVenta { get; set; }

    public int IdOrden { get; set; }

    public int Cantidad { get; set; }

    public decimal Descuento { get; set; }

    public decimal TotalPagar { get; set; }

    public decimal Subtotal { get; set; }

    public int IdUsuario { get; set; }

    public int? IdContrato { get; set; }

    public bool Estado { get; set; }

    public string? Concepto { get; set; }
}
