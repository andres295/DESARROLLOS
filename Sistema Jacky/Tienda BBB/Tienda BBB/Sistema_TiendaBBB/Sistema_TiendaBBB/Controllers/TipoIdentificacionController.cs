using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Sistema_TiendaBBB.Models.ViewModels;
using Sistema_TiendaBBB.Models;

namespace Sistema_TiendaBBB.Controllers
{
    public class TipoIdentificacionController : Controller
    {
        private readonly BdBbbContext _context;
        public TipoIdentificacionController(BdBbbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.TbCatTipoIdentificacions.ToListAsync());
        }

        //CREAR CLASIFICACION
        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(TipoIdentificacionViewModel model)
        {
            if (ModelState.IsValid)
            {
                var identificacion = new TbCatTipoIdentificacion()
                {
                    DescripcionIdentificacion = model.DescripcionIdentificacion
                };
                _context.Add(identificacion);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            ViewData["identificación"] = new SelectList(_context.TbCatTipoIdentificacions, "IdIdentificacion", "DescripcionIdentificacion", model.IdIdentificacion);
            return View(model);
        }

        //Editar
        public async Task<IActionResult> Edit(int id)
        {
            var identificacion = await _context.TbCatTipoIdentificacions.FindAsync(id);
            if (identificacion == null)
            {
                return NotFound();
            }

            var model = new TipoIdentificacionViewModel
            {
                IdIdentificacion = identificacion.IdIdentificacion,
                DescripcionIdentificacion = identificacion.DescripcionIdentificacion
            };
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, TipoIdentificacionViewModel model)
        {
            if (id != model.IdIdentificacion)
            {
                return BadRequest();
            }

            if (ModelState.IsValid)
            {
                var identificacion = await _context.TbCatTipoIdentificacions.FindAsync(id);
                if (identificacion == null)
                {
                    return NotFound();
                }

                // Asignar los nuevos valores
                identificacion.DescripcionIdentificacion = model.DescripcionIdentificacion;
                try
                {
                    _context.Update(identificacion);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!_context.TbCatTipoIdentificacions.Any(e => e.IdIdentificacion == id))
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
            var identificacion = await _context.TbCatTipoIdentificacions.FindAsync(id);

            // Si no se encuentra el artículo, devuelve un error 404
            if (identificacion == null)
            {
                return NotFound();
            }

            // Si el artículo existe, se pasa al modelo de la vista
            return View(identificacion);
        }

        // Método POST para realizar la eliminación
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            // Buscar el artículo por su ID
            var identificacion = await _context.TbCatTipoIdentificacions.FindAsync(id);

            // Si el artículo no existe, devuelve un error 404
            if (identificacion == null)
            {
                return NotFound();
            }

            // Eliminar el artículo de la base de datos
            _context.TbCatTipoIdentificacions.Remove(identificacion);
            await _context.SaveChangesAsync();

            // Redirigir al índice (lista de artículos) después de la eliminación
            return RedirectToAction(nameof(Index));
        }
    }
}
