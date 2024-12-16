using System;
using System.Collections.Generic;

namespace BACKEND_SCM.MODEL;

public partial class Usuario
{
    public int Id { get; set; }

    public string? Usuario1 { get; set; }

    public string? Contraseña { get; set; }

    public string? TipoUsuario { get; set; }

    public string? Estado { get; set; }

    public string? UsuarioSql { get; set; }

    public string? Nvia { get; set; }

    public string? Nvib { get; set; }

    public virtual ICollection<AperturaCaja> AperturaCajas { get; set; } = new List<AperturaCaja>();

    public virtual ICollection<CargoAjuste> CargoAjusteIdRespNavigations { get; set; } = new List<CargoAjuste>();

    public virtual ICollection<CargoAjuste> CargoAjusteMaquinaNavigations { get; set; } = new List<CargoAjuste>();

    public virtual ICollection<CargoAjusteProducto> CargoAjusteProductos { get; set; } = new List<CargoAjusteProducto>();

    public virtual ICollection<CargoCompraProducto> CargoCompraProductos { get; set; } = new List<CargoCompraProducto>();

    public virtual ICollection<CargoTransferenciaProducto> CargoTransferenciaProductos { get; set; } = new List<CargoTransferenciaProducto>();

    public virtual ICollection<DescargoAjuste> DescargoAjusteIdRespNavigations { get; set; } = new List<DescargoAjuste>();

    public virtual ICollection<DescargoAjuste> DescargoAjusteMaquinaNavigations { get; set; } = new List<DescargoAjuste>();

    public virtual ICollection<DescargoAjusteProducto> DescargoAjusteProductos { get; set; } = new List<DescargoAjusteProducto>();

    public virtual ICollection<DescargoTransferenciaProducto> DescargoTransferenciaProductos { get; set; } = new List<DescargoTransferenciaProducto>();

    public virtual ICollection<FacturasPorCobrarAbono> FacturasPorCobrarAbonos { get; set; } = new List<FacturasPorCobrarAbono>();

    public virtual ICollection<FacturasPorPagarAbono> FacturasPorPagarAbonos { get; set; } = new List<FacturasPorPagarAbono>();

    public virtual ICollection<StockProducto> StockProductos { get; set; } = new List<StockProducto>();

    public virtual ICollection<UsuarioPermiso> UsuarioPermisos { get; set; } = new List<UsuarioPermiso>();

    public virtual ICollection<Venta> VentaIdUsuarioNavigations { get; set; } = new List<Venta>();

    public virtual ICollection<Venta> VentaMaquinaNavigations { get; set; } = new List<Venta>();
}
