﻿using System;
using System.Collections.Generic;

namespace BACKEND_SCM.MODEL;

public partial class TmpFacturasPorPagarAbono
{
    public long Id { get; set; }

    public int? IdUsuario { get; set; }

    public string? Factura { get; set; }

    public DateOnly? FechaCobro { get; set; }

    public decimal? MontoEfectivo { get; set; }

    public DateTime? FechaHoraReg { get; set; }

    public int? TipoPago { get; set; }

    public string? NumDoc { get; set; }

    public int? IdBanco { get; set; }

    public decimal? MontoMultipago { get; set; }

    public string? ImagenDoc { get; set; }

    public string? Adquirente { get; set; }

    public decimal? InteresMultiPago { get; set; }
}