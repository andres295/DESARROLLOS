using System;
using System.Collections.Generic;

namespace BACKEND_SCM.MODEL;

public partial class SolicitudProducto
{
    public int Id { get; set; }

    public long? IdProducto { get; set; }

    public long? CantidadSolicita { get; set; }

    public decimal? Deposito { get; set; }

    public int? IdUsuario { get; set; }

    public DateTime FechaHoraRegistro { get; set; }

    public bool Estado { get; set; }

    public virtual Producto? IdProductoNavigation { get; set; }

    public virtual Usuario? IdUsuarioNavigation { get; set; }
}
