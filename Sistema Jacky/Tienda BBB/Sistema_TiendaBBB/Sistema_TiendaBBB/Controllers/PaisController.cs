using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Sistema_TiendaBBB.Models;
using Sistema_TiendaBBB.Models.ViewModels;

namespace Sistema_TiendaBBB.Controllers
{
    public class PaisController : Controller
    {

        private readonly BdBbbContext _context;
        public PaisController(BdBbbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.TbCatPais.ToListAsync());
        }

        //CREAR CLASIFICACION
        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(PaisViewModel model)
        {
            if (ModelState.IsValid)
            {
                var pais = new TbCatPai()
                {
                    DescripcionPais = model.DescripcionPais
                };
                _context.Add(pais);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            ViewData["pais"] = new SelectList(_context.TbCatPais, "IdPais", "DescripcionPais", model.IdPais);
            return View(model);
        }

        //Editar
        public async Task<IActionResult> Edit(int id)
        {
            var pais = await _context.TbCatPais.FindAsync(id);
            if (pais == null)
            {
                return NotFound();
            }

            var model = new PaisViewModel
            {
                IdPais = pais.IdPais,
                DescripcionPais = pais.DescripcionPais,
            };
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, PaisViewModel model)
        {
            if (id != model.IdPais)
            {
                return BadRequest();
            }

            if (ModelState.IsValid)
            {
                var pais = await _context.TbCatPais.FindAsync(id);
                if (pais == null)
                {
                    return NotFound();
                }

                // Asignar los nuevos valores
                pais.DescripcionPais = model.DescripcionPais;
                try
                {
                    _context.Update(pais);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!_context.TbCatPais.Any(e => e.IdPais == id))
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
            var pais = await _context.TbCatPais.FindAsync(id);

            // Si no se encuentra el artículo, devuelve un error 404
            if (pais == null)
            {
                return NotFound();
            }

            // Si el artículo existe, se pasa al modelo de la vista
            return View(pais);
        }

        // Método POST para realizar la eliminación
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            // Buscar el artículo por su ID
            var pais = await _context.TbCatPais.FindAsync(id);

            // Si el artículo no existe, devuelve un error 404
            if (pais == null)
            {
                return NotFound();
            }

            // Eliminar el artículo de la base de datos
            _context.TbCatPais.Remove(pais);
            await _context.SaveChangesAsync();

            // Redirigir al índice (lista de artículos) después de la eliminación
            return RedirectToAction(nameof(Index));
        }

    }
}
