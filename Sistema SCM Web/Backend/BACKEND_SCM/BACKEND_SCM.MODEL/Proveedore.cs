using System;
using System.Collections.Generic;

namespace BACKEND_SCM.MODEL;

public partial class Proveedore
{
    public long Id { get; set; }

    public string? Proveedor { get; set; }

    public string? Matriz { get; set; }

    public string? Direccion { get; set; }

    public string? Telefono { get; set; }

    public string? Ruc { get; set; }

    public string? Gerente { get; set; }

    public string? Autorizacion { get; set; }

    public string? Datos { get; set; }

    public int? TipoIdentifiacion { get; set; }

    public string? Correo { get; set; }

    public string? NombreComercial { get; set; }

    public string? Tipocontribuyente { get; set; }

    public string? AgenteRetencion { get; set; }

    public virtual ICollection<CargoAjuste> CargoAjustes { get; set; } = new List<CargoAjuste>();

    public virtual ICollection<CargoCompraProducto> CargoCompraProductos { get; set; } = new List<CargoCompraProducto>();

    public virtual ICollection<DescargoAjuste> DescargoAjustes { get; set; } = new List<DescargoAjuste>();

    public virtual ICollection<NotasCredito> NotasCreditos { get; set; } = new List<NotasCredito>();

    public virtual ICollection<Producto> Productos { get; set; } = new List<Producto>();

    public virtual ICollection<StockProducto> StockProductos { get; set; } = new List<StockProducto>();
}
