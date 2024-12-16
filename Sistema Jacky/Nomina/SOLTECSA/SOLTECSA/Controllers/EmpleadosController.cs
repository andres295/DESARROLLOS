using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SOLTECSA.Models;

namespace SOLTECSA.Controllers
{
    public class EmpleadosController : Controller
    {
        private readonly SoltecsaContext _soltecsaContext;
        public EmpleadosController(SoltecsaContext soltecsaContext)
        {
            _soltecsaContext = soltecsaContext;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _soltecsaContext.Empleados.ToListAsync());
        }
        // POST: Empleados/Create

        public IActionResult Create()
        {
            ViewBag.EstadoCivilList = GetEstadoCivilList();
            ViewBag.HijosList = GetHijosList();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdEmpleado,Nombre,FechaNacimiento,Dirección,EstadoCivil,Padre,Madre,Hijos,EstudiosPrimaria,EstudiosSecundaria,EstudiosUniversitario,EstudiosPostgrado,EstudiosTecnicos,EstudiosCertificaciones,EstudiosDiplomado,EstudiosDoctorado,Salario,Cedula")] Empleado empleado)
        {
            if (ModelState.IsValid)
            {
                empleado.Edad = CalculateAge(empleado.FechaNacimiento);
                _soltecsaContext.Add(empleado);
                await _soltecsaContext.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewBag.EstadoCivilList = GetEstadoCivilList();
            ViewBag.HijosList = GetHijosList();// En caso de error, recargar la lista
            return View(empleado);
        }

        // GET: Empleados/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var empleado = await _soltecsaContext.Empleados.FindAsync(id);
            if (empleado == null)
            {
                return NotFound();
            }

            ViewBag.EstadoCivilList = GetEstadoCivilList();
            ViewBag.HijosList = GetHijosList();
            return View(empleado);
        }

        // POST: Empleados/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdEmpleado,Nombre,FechaNacimiento,Dirección,EstadoCivil,Padre,Madre,Hijos,EstudiosPrimaria,EstudiosSecundaria,EstudiosUniversitario,EstudiosPostgrado,EstudiosTecnicos,EstudiosCertificaciones,EstudiosDiplomado,EstudiosDoctorado,Salario,Cedula")] Empleado empleado)
        {
            if (id != empleado.IdEmpleado)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    empleado.Edad = CalculateAge(empleado.FechaNacimiento);
                    _soltecsaContext.Update(empleado);
                    await _soltecsaContext.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EmpleadoExists(empleado.IdEmpleado))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewBag.EstadoCivilList = GetEstadoCivilList();
            ViewBag.HijosList = GetHijosList();// En caso de error, recargar la lista
            return View(empleado);
        }

        //Eliminar

        // Método GET para mostrar la vista de confirmación de eliminación
        public async Task<IActionResult> Delete(int id)
        {
            // Buscar el artículo por su ID
            var emp = await _soltecsaContext.Empleados.FindAsync(id);

            // Si no se encuentra el artículo, devuelve un error 404
            if (emp == null)
            {
                return NotFound();
            }

            // Si el artículo existe, se pasa al modelo de la vista
            return View(emp);
        }

        // Método POST para realizar la eliminación
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            // Buscar el artículo por su ID
            var emp = await _soltecsaContext.Empleados.FindAsync(id);

            // Si el artículo no existe, devuelve un error 404
            if (emp == null)
            {
                return NotFound();
            }

            // Eliminar el artículo de la base de datos
            _soltecsaContext.Empleados.Remove(emp);
            await _soltecsaContext.SaveChangesAsync();

            // Redirigir al índice (lista de artículos) después de la eliminación
            return RedirectToAction(nameof(Index));
        }
        // Helper method to calculate age
        private int CalculateAge(DateOnly fechaNacimiento)
        {
            var today = DateOnly.FromDateTime(DateTime.Now);
            int age = today.Year - fechaNacimiento.Year;

            if (fechaNacimiento > today.AddYears(-age))
                age--;

            return age;
        }

        private bool EmpleadoExists(int id)
        {
            return _soltecsaContext.Empleados.Any(e => e.IdEmpleado == id);
        }

        //Listado para seleccionar estado civil
        private List<SelectListItem> GetEstadoCivilList()
        {
            return new List<SelectListItem>
    {
        new SelectListItem { Value = "Soltero", Text = "Soltero" },
        new SelectListItem { Value = "Casado", Text = "Casado" },
        new SelectListItem { Value = "Divorciado", Text = "Divorciado" }
    };
        }

        private List<SelectListItem> GetHijosList()
        {
            return new List<SelectListItem>
    {
        new SelectListItem { Value = "SI", Text = "SI" },
        new SelectListItem { Value = "NO", Text = "NO" }
    };
        }

    }
}
