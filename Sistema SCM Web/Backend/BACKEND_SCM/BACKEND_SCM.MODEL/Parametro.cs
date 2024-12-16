using System;
using System.Collections.Generic;

namespace BACKEND_SCM.MODEL;

public partial class Parametro
{
    public int Id { get; set; }

    public string? NombreEmpresa { get; set; }

    public string? Telefono { get; set; }

    public string? Correo { get; set; }

    public string? Direccion { get; set; }

    public string? Ruc { get; set; }

    public string? Alias { get; set; }

    public string? RutaImagen { get; set; }

    public string? RutaBackup { get; set; }

    public int? NumItem { get; set; }

    public string? AltoPrintFactura { get; set; }

    public bool? BkAutomatico { get; set; }

    public DateOnly? BkDesde { get; set; }

    public DateOnly? BkHasta { get; set; }

    public int? StockProducto { get; set; }

    public int? DiaVencimiento { get; set; }

    public int? NumVentanaVenta { get; set; }

    public string? Nvia { get; set; }

    public string? Nvib { get; set; }

    public string? NotaAvisoCm { get; set; }

    public string? Especialidades { get; set; }

    public string? RegistroSanitario { get; set; }
}
