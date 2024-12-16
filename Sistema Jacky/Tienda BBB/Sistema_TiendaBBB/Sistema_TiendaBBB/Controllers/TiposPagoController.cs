using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Sistema_TiendaBBB.Models.ViewModels;
using Sistema_TiendaBBB.Models;

namespace Sistema_TiendaBBB.Controllers
{
    public class TiposPagoController : Controller
    {
        private readonly BdBbbContext _context;
        public TiposPagoController(BdBbbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.TbCatMetodoPagos.ToListAsync());
        }

        //CREAR CLASIFICACION
        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(TiposPagoViewModel model)
        {
            if (ModelState.IsValid)
            {
                var pago = new TbCatMetodoPago()
                {
                    DescripcionPago = model.DescripcionPago
                };
                _context.Add(pago);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            ViewData["pago"] = new SelectList(_context.TbCatMetodoPagos, "IdPago", "DescripcionPago", model.IdPago);
            return View(model);
        }

        //Editar
        public async Task<IActionResult> Edit(int id)
        {
            var pago = await _context.TbCatMetodoPagos.FindAsync(id);
            if (pago == null)
            {
                return NotFound();
            }

            var model = new TiposPagoViewModel
            {
                IdPago = pago.IdPago,
                DescripcionPago = pago.DescripcionPago
            };
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, TiposPagoViewModel model)
        {
            if (id != model.IdPago)
            {
                return BadRequest();
            }

            if (ModelState.IsValid)
            {
                var pago = await _context.TbCatMetodoPagos.FindAsync(id);
                if (pago == null)
                {
                    return NotFound();
                }

                // Asignar los nuevos valores
                pago.DescripcionPago = model.DescripcionPago;
                try
                {
                    _context.Update(pago);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!_context.TbCatMetodoPagos.Any(e => e.IdPago == id))
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
            var pago = await _context.TbCatMetodoPagos.FindAsync(id);

            // Si no se encuentra el artículo, devuelve un error 404
            if (pago == null)
            {
                return NotFound();
            }

            // Si el artículo existe, se pasa al modelo de la vista
            return View(pago);
        }

        // Método POST para realizar la eliminación
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            // Buscar el artículo por su ID
            var pago = await _context.TbCatMetodoPagos.FindAsync(id);

            // Si el artículo no existe, devuelve un error 404
            if (pago == null)
            {
                return NotFound();
            }

            // Eliminar el artículo de la base de datos
            _context.TbCatMetodoPagos.Remove(pago);
            await _context.SaveChangesAsync();

            // Redirigir al índice (lista de artículos) después de la eliminación
            return RedirectToAction(nameof(Index));
        }
    }
}
