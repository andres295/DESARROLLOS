using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Sistema_TiendaBBB.Models;
using Sistema_TiendaBBB.Models.ViewModels;

namespace Sistema_TiendaBBB.Controllers
{
    public class CiudadController : Controller
    {
        private readonly BdBbbContext _context;
        public CiudadController(BdBbbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.TbCatCiudads.ToListAsync());
        }

        //CREAR CLASIFICACION
        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CiudadViewModel model)
        {
            if (ModelState.IsValid)
            {
                var ciudad = new TbCatCiudad()
                {
                    DescripcionCiudad = model.DescripcionCiudad
                };
                _context.Add(ciudad);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            ViewData["ciudad"] = new SelectList(_context.TbCatCiudads, "IdCiudad", "DescripcionCiudad", model.IdCiudad);
            return View(model);
        }

        //Editar
        public async Task<IActionResult> Edit(int id)
        {
            var ciudad = await _context.TbCatCiudads.FindAsync(id);
            if (ciudad == null)
            {
                return NotFound();
            }

            var model = new CiudadViewModel
            {
                IdCiudad = ciudad.IdCiudad,
                DescripcionCiudad = ciudad.DescripcionCiudad,
            };
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, CiudadViewModel model)
        {
            if (id != model.IdCiudad)
            {
                return BadRequest();
            }

            if (ModelState.IsValid)
            {
                var ciudad = await _context.TbCatCiudads.FindAsync(id);
                if (ciudad == null)
                {
                    return NotFound();
                }

                // Asignar los nuevos valores
                ciudad.DescripcionCiudad = model.DescripcionCiudad;
                try
                {
                    _context.Update(ciudad);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!_context.TbCatCiudads.Any(e => e.IdCiudad == id))
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
            var ciudad = await _context.TbCatCiudads.FindAsync(id);

            // Si no se encuentra el artículo, devuelve un error 404
            if (ciudad == null)
            {
                return NotFound();
            }

            // Si el artículo existe, se pasa al modelo de la vista
            return View(ciudad);
        }

        // Método POST para realizar la eliminación
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            // Buscar el artículo por su ID
            var ciudad = await _context.TbCatCiudads.FindAsync(id);

            // Si el artículo no existe, devuelve un error 404
            if (ciudad == null)
            {
                return NotFound();
            }

            // Eliminar el artículo de la base de datos
            _context.TbCatCiudads.Remove(ciudad);
            await _context.SaveChangesAsync();

            // Redirigir al índice (lista de artículos) después de la eliminación
            return RedirectToAction(nameof(Index));
        }


    }
}
