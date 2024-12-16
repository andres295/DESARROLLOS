using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Sistema_TiendaBBB.Models;
using Sistema_TiendaBBB.Models.ViewModels;

namespace Sistema_TiendaBBB.Controllers
{
    public class ClienteController : Controller
    {

        private readonly BdBbbContext _context;

        public ClienteController(BdBbbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var cte = _context.TbCatClientes
                .Include(c => c.IdClasificacionNavigation)
                .Include(p => p.IdPagoNavigation)
                .Include(i => i.IdIdentificacionNavigation)
                .Include(p => p.IdPaisNavigation)
                .Include(c => c.IdCiudadNavigation);



            return View(await cte.ToListAsync());
        }
        //CREAR ARTICULO
        public IActionResult Create()
        {
            ViewData["Clasificacion"] = new SelectList(_context.TbCatClasificacionCtes, "IdClasificacion", "DescripcionClasificacion");
            ViewData["Pago"] = new SelectList(_context.TbCatMetodoPagos, "IdPago", "DescripcionPago");
            ViewData["Identificación"] = new SelectList(_context.TbCatTipoIdentificacions, "IdIdentificacion", "DescripcionIdentificacion");
            ViewData["Pais"] = new SelectList(_context.TbCatPais, "IdPais", "DescripcionPais");
            ViewData["Ciudad"] = new SelectList(_context.TbCatCiudads, "IdCiudad", "DescripcionCiudad");

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ClienteViewModel model)
        {
            if (ModelState.IsValid)
            {
                var cte = new TbCatCliente()
                {
                    NombreCliente = model.NombreCliente,
                    IdClasificacion = model.IdClasificacion,
                    IdPago = model.IdPago,
                    IdIdentificacion = model.IdIdentificacion,
                    IdPais = model.IdPais,
                    IdCiudad = model.IdCiudad,
                    NumeroIdentificacion = model.NumeroIdentificacion,
                    Direccion = model.Direccion
                };
                _context.Add(cte);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            ViewData["Clasificacion"] = new SelectList(_context.TbCatClasificacionCtes, "IdClasificacion", "DescripcionClasificacion", model.IdClasificacion);
            ViewData["Pago"] = new SelectList(_context.TbCatMetodoPagos, "IdPago", "DescripcionPago", model.IdPago);
            ViewData["Identificación"] = new SelectList(_context.TbCatTipoIdentificacions, "IdIdentificacion", "DescripcionIdentificacion", model.IdIdentificacion);
            ViewData["Pais"] = new SelectList(_context.TbCatPais, "IdPais", "DescripcionPais", model.IdPais);
            ViewData["Ciudad"] = new SelectList(_context.TbCatCiudads, "IdCiudad", "DescripcionCiudad", model.IdCiudad);
            return View(model);
        }

        //EDITAR
        public async Task<IActionResult> Edit(int id)
        {
            var cte = await _context.TbCatClientes.FindAsync(id);
            if (cte == null)
            {
                return NotFound();
            }

            var model = new ClienteViewModel
            {
                 IdCliente= cte.IdCliente,
                NombreCliente = cte.NombreCliente,
                IdClasificacion = cte.IdClasificacion,
                IdPago = cte.IdPago,
                IdIdentificacion = cte.IdIdentificacion,
                IdPais = cte.IdPais,
                IdCiudad = cte.IdCiudad,
                NumeroIdentificacion = cte.NumeroIdentificacion,
                Direccion = cte.Direccion
            };

            // Llenar las listas desplegables
            ViewData["Clasificacion"] = new SelectList(_context.TbCatClasificacionCtes, "IdClasificacion", "DescripcionClasificacion", model.IdClasificacion);
            ViewData["Pago"] = new SelectList(_context.TbCatMetodoPagos, "IdPago", "DescripcionPago", model.IdPago);
            ViewData["Identificación"] = new SelectList(_context.TbCatTipoIdentificacions, "IdIdentificacion", "DescripcionIdentificacion", model.IdIdentificacion);
            ViewData["Pais"] = new SelectList(_context.TbCatPais, "IdPais", "DescripcionPais", model.IdPais);
            ViewData["Ciudad"] = new SelectList(_context.TbCatCiudads, "IdCiudad", "DescripcionCiudad", model.IdCiudad);

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, ClienteViewModel model)
        {
            if (id != model.IdCliente)
            {
                return BadRequest();
            }

            if (ModelState.IsValid)
            {
                var cte = await _context.TbCatClientes.FindAsync(id);
                if (cte == null)
                {
                    return NotFound();
                }

                // Asignar los nuevos valores
                cte.NombreCliente = model.NombreCliente;
                cte.IdClasificacion = model.IdClasificacion;
                cte.IdPago = model.IdPago;
                cte.IdIdentificacion = model.IdIdentificacion;
                cte.IdPais = model.IdPais;
                cte.IdCiudad = model.IdCiudad;
                cte.NumeroIdentificacion = model.NumeroIdentificacion;
                cte.Direccion = model.Direccion;

                try
                {
                    _context.Update(cte);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!_context.TbCatClientes.Any(e => e.IdCliente == id))
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
            ViewData["Clasificacion"] = new SelectList(_context.TbCatClasificacionCtes, "IdClasificacion", "DescripcionClasificacion", model.IdClasificacion);
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
            var cte = await _context.TbCatClientes.FindAsync(id);

            // Si no se encuentra el artículo, devuelve un error 404
            if (cte == null)
            {
                return NotFound();
            }

            // Si el artículo existe, se pasa al modelo de la vista
            return View(cte);
        }

        // Método POST para realizar la eliminación
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            // Buscar el artículo por su ID
            var cte = await _context.TbCatClientes.FindAsync(id);

            // Si el artículo no existe, devuelve un error 404
            if (cte == null)
            {
                return NotFound();
            }

            // Eliminar el artículo de la base de datos
            _context.TbCatClientes.Remove(cte);
            await _context.SaveChangesAsync();

            // Redirigir al índice (lista de artículos) después de la eliminación
            return RedirectToAction(nameof(Index));
        }
    }
}
