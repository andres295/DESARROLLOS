using System;
using System.Collections.Generic;

namespace BACKEND_SCM.MODEL;

public partial class CierreCaja
{
    public int Id { get; set; }

    public int IdAperturaCaja { get; set; }

    public decimal MontoApertura { get; set; }

    public decimal MontoSistema { get; set; }

    public decimal MontoIngresos { get; set; }

    public decimal MontoEgresos { get; set; }

    public decimal MontoTotalCierre { get; set; }

    public decimal MontoFaltante { get; set; }

    public int CantidadEfectivoMoneda1 { get; set; }

    public int CantidadEfectivoMoneda2 { get; set; }

    public int CantidadEfectivoMoneda3 { get; set; }

    public int CantidadEfectivoMoneda4 { get; set; }

    public int CantidadEfectivoMoneda5 { get; set; }

    public int CantidadEfectivoMoneda6 { get; set; }

    public int CantidadEfectivoBillete1 { get; set; }

    public int CantidadEfectivoBillete2 { get; set; }

    public int CantidadEfectivoBillete3 { get; set; }

    public int CantidadEfectivoBillete4 { get; set; }

    public int CantidadEfectivoBillete5 { get; set; }

    public int CantidadEfectivoBillete6 { get; set; }

    public int CantidadEfectivoBillete7 { get; set; }

    public decimal MontoTotalEfectivoMoneda { get; set; }

    public decimal MontoTotalEfectivoBillete { get; set; }

    public decimal MontoTotalUsuario { get; set; }

    public int IdUsuario { get; set; }

    public DateTime FechaHoraRegistro { get; set; }

    public decimal? MontoSobrante { get; set; }

    public virtual AperturaCaja IdAperturaCajaNavigation { get; set; } = null!;

    public virtual Usuario IdUsuarioNavigation { get; set; } = null!;
}
