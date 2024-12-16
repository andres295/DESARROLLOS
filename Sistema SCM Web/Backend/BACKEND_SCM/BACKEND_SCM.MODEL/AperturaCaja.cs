using System;
using System.Collections.Generic;

namespace BACKEND_SCM.MODEL;

public partial class AperturaCaja
{
    public int Id { get; set; }

    public DateOnly FechaApertura { get; set; }

    public decimal MontoApertura { get; set; }

    public int IdUsuario { get; set; }

    public DateTime FechaHoraRegistro { get; set; }

    public virtual Usuario IdUsuarioNavigation { get; set; } = null!;
}
