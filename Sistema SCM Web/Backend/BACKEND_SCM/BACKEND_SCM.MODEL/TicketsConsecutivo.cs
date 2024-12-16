using System;
using System.Collections.Generic;

namespace BACKEND_SCM.MODEL;

public partial class TicketsConsecutivo
{
    public long Id { get; set; }

    public int NumeroTickets { get; set; }

    public int IdVenta { get; set; }

    public DateTime Fecha { get; set; }
}
