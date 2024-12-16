using System;
using System.Collections.Generic;

namespace BACKEND_SCM.MODEL;

public partial class EgresosCaja
{
    public int Id { get; set; }

    public int IdAperturaCaja { get; set; }

    public string Descripcion { get; set; } = null!;

    public decimal MontoEgreso { get; set; }

    public int IdUsuario { get; set; }

    public DateTime FechaHoraRegistro { get; set; }

    public virtual AperturaCaja IdAperturaCajaNavigation { get; set; } = null!;

    public virtual Usuario IdUsuarioNavigation { get; set; } = null!;
}
