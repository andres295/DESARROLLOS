using Microsoft.AspNetCore.Mvc.Rendering;

public class NominaViewModel
{
    public int IdEmpleado { get; set; }
    public decimal Salario { get; set; }
    public decimal Inns { get; set; }
    public decimal Ir { get; set; }
    public decimal Quincena { get; set; }

    public List<SelectListItem> Empleados { get; set; }
}
