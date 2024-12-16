using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Sistema_TiendaBBB.Models;
using Sistema_TiendaBBB.Models.ViewModels;
using System.Runtime.CompilerServices;

namespace Sistema_TiendaBBB.Controllers
{
    public class ClasificacionController : Controller
    {


        private readonly BdBbbContext _context;
        public ClasificacionController(BdBbbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _context.TbCatClasificacionArts.ToListAsync());
        }

        //CREAR CLASIFICACION
        public IActionResult Create()
        {

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ClasificacionViewModel model)
        {
            if (ModelState.IsValid)
            {
                var clasificacion = new TbCatClasificacionArt()
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
            var clasificacion = await _context.TbCatClasificacionArts.FindAsync(id);
            if (clasificacion == null)
            {
                return NotFound();
            }

            var model = new ClasificacionViewModel
            {
                IdClasificacion = clasificacion.IdClasificacion,
                DescripcionClasificacion = clasificacion.DescripcionClasificacion,
            };
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, ClasificacionViewModel model)
        {
            if (id != model.IdClasificacion)
            {
                return BadRequest();
            }

            if (ModelState.IsValid)
            {
                var clasificacion = await _context.TbCatClasificacionArts.FindAsync(id);
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
                    if (!_context.TbCatClasificacionArts.Any(e => e.IdClasificacion == id))
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
            var clasificacion = await _context.TbCatClasificacionArts.FindAsync(id);

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
            var clasificacion = await _context.TbCatClasificacionArts.FindAsync(id);

            // Si el artículo no existe, devuelve un error 404
            if (clasificacion == null)
            {
                return NotFound();
            }

            // Eliminar el artículo de la base de datos
            _context.TbCatClasificacionArts.Remove(clasificacion);
            await _context.SaveChangesAsync();

            // Redirigir al índice (lista de artículos) después de la eliminación
            return RedirectToAction(nameof(Index));
        }

    }
}
