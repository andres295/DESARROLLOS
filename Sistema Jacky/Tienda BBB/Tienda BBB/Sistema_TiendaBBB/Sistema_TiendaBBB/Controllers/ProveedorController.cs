using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Sistema_TiendaBBB.Models;
using Sistema_TiendaBBB.Models.ViewModels;

namespace Sistema_TiendaBBB.Controllers
{
    public class ProveedorController : Controller
    {
        private readonly BdBbbContext _context;

        public ProveedorController(BdBbbContext context)
        {
            _context = context;
        }
        //LISTA DE PROVEEDORES
        public async Task<IActionResult> Index()
        {
            var prov = _context.TbCatProveedors
                .Include(c => c.IdClasificacionNavigation)
                .Include(p => p.IdPagoNavigation)
                .Include(i => i.IdIdentificacionNavigation)
                .Include(p => p.IdPaisNavigation)
                .Include(c => c.IdCiudadNavigation);



            return View(await prov.ToListAsync());
        }
        //CREAR ARTICULO
        public IActionResult Create()
        {
            ViewData["Clasificacion"] = new SelectList(_context.TbCatClasificacionProvs, "IdClasificacion", "DescripcionClasificacion");
            ViewData["Pago"] = new SelectList(_context.TbCatMetodoPagos, "IdPago", "DescripcionPago");
            ViewData["Identificación"] = new SelectList(_context.TbCatTipoIdentificacions, "IdIdentificacion", "DescripcionIdentificacion");
            ViewData["Pais"] = new SelectList(_context.TbCatPais, "IdPais", "DescripcionPais");
            ViewData["Ciudad"] = new SelectList(_context.TbCatCiudads, "IdCiudad", "DescripcionCiudad");

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ProveedorViewModel model)
        {
            if (ModelState.IsValid)
            {
                var prov = new TbCatProveedor()
                {
                    NombreProveedor = model.NombreProveedor,
                    IdClasificacion = model.IdClasificacion,
                    IdPago = model.IdPago,
                    IdIdentificacion = model.IdIdentificacion,
                    IdPais = model.IdPais,
                    IdCiudad = model.IdCiudad,
                    NumeroIdentificacion = model.NumeroIdentificacion,
                    Direccion = model.Direccion
                };
                _context.Add(prov);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            ViewData["Clasificacion"] = new SelectList(_context.TbCatClasificacionProvs, "IdClasificacion", "DescripcionClasificacion", model.IdClasificacion);
            ViewData["Pago"] = new SelectList(_context.TbCatMetodoPagos, "IdPago", "DescripcionPago", model.IdPago);
            ViewData["Identificación"] = new SelectList(_context.TbCatTipoIdentificacions, "IdIdentificacion", "DescripcionIdentificacion", model.IdIdentificacion);
            ViewData["Pais"] = new SelectList(_context.TbCatPais, "IdPais", "DescripcionPais", model.IdPais);
            ViewData["Ciudad"] = new SelectList(_context.TbCatCiudads, "IdCiudad", "DescripcionCiudad", model.IdCiudad);
            return View(model);
        }

        //EDITAR
        public async Task<IActionResult> Edit(int id)
        {
            var prov = await _context.TbCatProveedors.FindAsync(id);
            if (prov == null)
            {
                return NotFound();
            }

            var model = new ProveedorViewModel
            {
                IdProveedor = prov.IdProveedor,
                NombreProveedor = prov.NombreProveedor,
                IdClasificacion = prov.IdClasificacion,
                IdPago = prov.IdPago,
                IdIdentificacion = prov.IdIdentificacion,
                IdPais = prov.IdPais,
                IdCiudad = prov.IdCiudad,
                NumeroIdentificacion = prov.NumeroIdentificacion,
                Direccion = prov.Direccion
            };

            // Llenar las listas desplegables
            ViewData["Clasificacion"] = new SelectList(_context.TbCatClasificacionProvs, "IdClasificacion", "DescripcionClasificacion", model.IdClasificacion);
            ViewData["Pago"] = new SelectList(_context.TbCatMetodoPagos, "IdPago", "DescripcionPago", model.IdPago);
            ViewData["Identificación"] = new SelectList(_context.TbCatTipoIdentificacions, "IdIdentificacion", "DescripcionIdentificacion", model.IdIdentificacion);
            ViewData["Pais"] = new SelectList(_context.TbCatPais, "IdPais", "DescripcionPais", model.IdPais);
            ViewData["Ciudad"] = new SelectList(_context.TbCatCiudads, "IdCiudad", "DescripcionCiudad", model.IdCiudad);

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, ProveedorViewModel model)
        {
            if (id != model.IdProveedor)
            {
                return BadRequest();
            }

            if (ModelState.IsValid)
            {
                var prov = await _context.TbCatProveedors.FindAsync(id);
                if (prov == null)
                {
                    return NotFound();
                }

                // Asignar los nuevos valores
                prov.NombreProveedor = model.NombreProveedor;
                prov.IdClasificacion = model.IdClasificacion;
                prov.IdPago = model.IdPago;
                prov.IdIdentificacion = model.IdIdentificacion;
                prov.IdPais = model.IdPais;
                prov.IdCiudad = model.IdCiudad;
                prov.NumeroIdentificacion = model.NumeroIdentificacion;
                prov.Direccion = model.Direccion;

                try
                {
                    _context.Update(prov);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!_context.TbCatProveedors.Any(e => e.IdProveedor == id))
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

            // Si el modelo no es válido, volver a cargar las listas desplegables
            ViewData["Clasificacion"] = new SelectList(_context.TbCatClasificacionProvs, "IdClasificacion", "DescripcionClasificacion", model.IdClasificacion);
            ViewData["Pago"] = new SelectList(_context.TbCatMetodoPagos, "IdPago", "DescripcionPago", model.IdPago);
            ViewData["Identificación"] = new SelectList(_context.TbCatTipoIdentificacions, "IdIdentificacion", "DescripcionIdentificacion", model.IdIdentificacion);
            ViewData["Pais"] = new SelectList(_context.TbCatPais, "IdPais", "DescripcionPais", model.IdPais);
            ViewData["Ciudad"] = new SelectList(_context.TbCatCiudads, "IdCiudad", "DescripcionCiudad", model.IdCiudad);

            return View(model);
        }


        //Eliminar

        // Método GET para mostrar la vista de confirmación de eliminación
        public async Task<IActionResult> Delete(int id)
        {
            // Buscar el artículo por su ID
            var prov = await _context.TbCatProveedors.FindAsync(id);

            // Si no se encuentra el artículo, devuelve un error 404
            if (prov == null)
            {
                return NotFound();
            }

            // Si el artículo existe, se pasa al modelo de la vista
            return View(prov);
        }

        // Método POST para realizar la eliminación
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            // Buscar el artículo por su ID
            var prov = await _context.TbCatProveedors.FindAsync(id);

            // Si el artículo no existe, devuelve un error 404
            if (prov == null)
            {
                return NotFound();
            }

            // Eliminar el artículo de la base de datos
            _context.TbCatProveedors.Remove(prov);
            await _context.SaveChangesAsync();

            // Redirigir al índice (lista de artículos) después de la eliminación
            return RedirectToAction(nameof(Index));
        }

    }
}
