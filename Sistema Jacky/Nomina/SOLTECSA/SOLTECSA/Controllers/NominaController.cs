using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SOLTECSA.Models;
using System.Linq;

namespace SOLTECSA.Controllers
{
    public class NominaController : Controller
    {
        private readonly SoltecsaContext _context;

        public NominaController(SoltecsaContext context)
        {
            _context = context;
        }

        // GET: Nomina/Create
        public IActionResult Create()
        {
            // Obtener lista de empleados desde la base de datos
            ViewData["Empleados"] = new SelectList(_context.Empleados, "IdEmpleado", "Nombre");

            return View();
        }


        // POST: Nomina/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(NominaViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                // Crear el modelo Nomina con los datos del ViewModel
                var nomina = new Nomina
                {
                    IdEmpleado = viewModel.IdEmpleado,
                    Salario = viewModel.Salario,
                    Inns = viewModel.Inns,
                    Ir = viewModel.Ir,
                    Quincena = viewModel.Quincena
                };

                // Guardar la nómina en la base de datos
                _context.Add(nomina);
                _context.SaveChanges();

                // Redirigir a la vista de índice o a la vista deseada
                return RedirectToAction(nameof(Index));
            }

            // Si el modelo no es válido, retornar a la vista con el modelo
            return View(viewModel);
        }

        // GET: Nomina/Index
        public IActionResult Index()
        {
            // Obtener las nóminas de la base de datos para mostrarlas en la vista
            var nominas = _context.Nominas.Include(n => n.IdEmpleadoNavigation).ToList();
            return View(nominas);
        }
    }
}
