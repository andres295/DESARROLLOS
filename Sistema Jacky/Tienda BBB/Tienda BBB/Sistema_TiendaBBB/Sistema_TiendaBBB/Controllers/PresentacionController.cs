using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Sistema_TiendaBBB.Models.ViewModels;
using Sistema_TiendaBBB.Models;

namespace Sistema_TiendaBBB.Controllers
{
    public class PresentacionController : Controller
    {
        private readonly BdBbbContext _context;
        public PresentacionController(BdBbbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.TbCatPresentacionArts.ToListAsync());
        }

        //CREAR CLASIFICACION
        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(PresentacionViewModel model)
        {
            if (ModelState.IsValid)
            {
                var presentacion = new TbCatPresentacionArt()
                {
                    DescripcionPresentacion = model.DescripcionPresentacion
                };
                _context.Add(presentacion);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            ViewData["presentacion"] = new SelectList(_context.TbCatPais, "IdPresentacion", "DescripcionPresentacion", model.IdPresentacion);
            return View(model);
        }

        //Editar
        public async Task<IActionResult> Edit(int id)
        {
            var presentacion = await _context.TbCatPresentacionArts.FindAsync(id);
            if (presentacion == null)
            {
                return NotFound();
            }

            var model = new PresentacionViewModel
            {
                IdPresentacion = presentacion.IdPresentacion,
                DescripcionPresentacion = presentacion.DescripcionPresentacion,
            };
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, PresentacionViewModel model)
        {
            if (id != model.IdPresentacion)
            {
                return BadRequest();
            }

            if (ModelState.IsValid)
            {
                var presentacion = await _context.TbCatPresentacionArts.FindAsync(id);
                if (presentacion == null)
                {
                    return NotFound();
                }

                // Asignar los nuevos valores
                presentacion.DescripcionPresentacion = model.DescripcionPresentacion;
                try
                {
                    _context.Update(presentacion);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!_context.TbCatPresentacionArts.Any(e => e.IdPresentacion == id))
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
            var presentacion = await _context.TbCatPresentacionArts.FindAsync(id);

            // Si no se encuentra el artículo, devuelve un error 404
            if (presentacion == null)
            {
                return NotFound();
            }

            // Si el artículo existe, se pasa al modelo de la vista
            return View(presentacion);
        }

        // Método POST para realizar la eliminación
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            // Buscar el artículo por su ID
            var presentacion = await _context.TbCatPresentacionArts.FindAsync(id);

            // Si el artículo no existe, devuelve un error 404
            if (presentacion == null)
            {
                return NotFound();
            }

            // Eliminar el artículo de la base de datos
            _context.TbCatPresentacionArts.Remove(presentacion);
            await _context.SaveChangesAsync();

            // Redirigir al índice (lista de artículos) después de la eliminación
            return RedirectToAction(nameof(Index));
        }

    }
}

