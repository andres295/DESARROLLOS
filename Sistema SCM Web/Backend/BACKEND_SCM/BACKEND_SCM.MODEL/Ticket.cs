using System;
using System.Collections.Generic;

namespace BACKEND_SCM.MODEL;

public partial class Ticket
{
    public long Id { get; set; }

    public int IdVenta { get; set; }

    public int IdCliente { get; set; }

    public int IdEspecialista { get; set; }

    public DateTime FechaAtencion { get; set; }

    public int NumeroTickets { get; set; }
}
