using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Sistema_TiendaBBB.Models;
using Sistema_TiendaBBB.Models.ViewModels;

namespace Sistema_TiendaBBB.Controllers
{
    public class ClasificacionProveedorController : Controller
    {
        private readonly BdBbbContext _context;
        public ClasificacionProveedorController(BdBbbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.TbCatClasificacionProvs.ToListAsync());
        }

        //CREAR CLASIFICACION
        public IActionResult Create()
        {

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Clasificacion_Prov_View_Model model)
        {
            if (ModelState.IsValid)
            {
                var clasificacion = new TbCatClasificacionProv()
                {
                    DescripcionClasificacion = model.DescripcionClasificacion
                };
                _context.Add(clasificacion);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            ViewData["Clasificacion"] = new SelectList(_context.TbCatClasificacionArts, "IdClasificacion", "DescripcionClasificacion", model.IdClasificacion);
            return View(model);
        }

        //Editar
        public async Task<IActionResult> Edit(int id)
        {
            var clasificacion = await _context.TbCatClasificacionProvs.FindAsync(id);
            if (clasificacion == null)
            {
                return NotFound();
            }

            var model = new Clasificacion_Prov_View_Model
            {
                IdClasificacion = clasificacion.IdClasificacion,
                DescripcionClasificacion = clasificacion.DescripcionClasificacion,
            };
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Clasificacion_Prov_View_Model model)
        {
            if (id != model.IdClasificacion)
            {
                return BadRequest();
            }

            if (ModelState.IsValid)
            {
                var clasificacion = await _context.TbCatClasificacionProvs.FindAsync(id);
                if (clasificacion == null)
                {
                    return NotFound();
                }

                // Asignar los nuevos valores
                clasificacion.DescripcionClasificacion = model.DescripcionClasificacion;
                try
                {
                    _context.Update(clasificacion);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!_context.TbCatClasificacionProvs.Any(e => e.IdClasificacion == id))
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
            return View(model);
        }

        //Eliminar

        // Método GET para mostrar la vista de confirmación de eliminación
        public async Task<IActionResult> Delete(int id)
        {
            // Buscar el artículo por su ID
            var clasificacion = await _context.TbCatClasificacionProvs.FindAsync(id);

            // Si no se encuentra el artículo, devuelve un error 404
            if (clasificacion == null)
            {
                return NotFound();
            }

            // Si el artículo existe, se pasa al modelo de la vista
            return View(clasificacion);
        }

        // Método POST para realizar la eliminación
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            // Buscar el artículo por su ID
            var clasificacion = await _context.TbCatClasificacionProvs.FindAsync(id);

            // Si el artículo no existe, devuelve un error 404
            if (clasificacion == null)
            {
                return NotFound();
            }

            // Eliminar el artículo de la base de datos
            _context.TbCatClasificacionProvs.Remove(clasificacion);
            await _context.SaveChangesAsync();

            // Redirigir al índice (lista de artículos) después de la eliminación
            return RedirectToAction(nameof(Index));
        }


    }
}
