using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Sistema_TiendaBBB.Models;
using Sistema_TiendaBBB.Models.ViewModels;

namespace Sistema_TiendaBBB.Controllers
{
    public class ArticuloController : Controller
    {
        private readonly BdBbbContext _context;

        public ArticuloController(BdBbbContext context)
        {
            _context = context;     
        }

        //LISTA DE ARTICULOS
        public async Task<IActionResult> Index()
        {
            var articulo = _context.TbCatArticulos
                .Include(c => c.IdClasificacionNavigation)
                .Include(p => p.IdPresentacionNavigation)
                .Include(prov => prov.IdProveedorNavigation);


            return View(await articulo.ToListAsync());
        }

        //CREAR ARTICULO
        public IActionResult Create()
        {
            ViewData["Clasificacion"] = new SelectList(_context.TbCatClasificacionArts, "IdClasificacion", "DescripcionClasificacion");
            ViewData["Presentacion"] = new SelectList(_context.TbCatPresentacionArts, "IdPresentacion", "DescripcionPresentacion");
            ViewData["Proveedor"] = new SelectList(_context.TbCatProveedors, "IdProveedor", "NombreProveedor");

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public  async Task<IActionResult> Create(ArticuloViewModel model)
        {
            if (ModelState.IsValid)
            {
                var articulo = new TbCatArticulo()
                {
                    DescripcionArticulo= model.DescripcionArticulo,
                    IdProveedor=model.IdProveedor,
                    IdClasificacion=model.IdClasificacion,
                    IdPresentacion=model.IdPresentacion,
                    Disponible=model.Disponible,
                    CostoUnitario=model.CostoUnitario,
                    PrecioVenta=model.PrecioVenta
                };
                _context.Add(articulo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            ViewData["Clasificacion"] = new SelectList(_context.TbCatClasificacionArts, "IdClasificacion", "DescripcionClasificacion", model.IdClasificacion);
            ViewData["Presentacion"] = new SelectList(_context.TbCatPresentacionArts, "IdPresentacion", "DescripcionPresentacion", model.IdPresentacion);
            ViewData["Proveedor"] = new SelectList(_context.TbCatProveedors, "IdProveedor", "NombreProveedor", model.IdProveedor);
            return View(model);
        }

        //EDITAR
        public async Task<IActionResult> Edit(int id)
        {
            var articulo = await _context.TbCatArticulos.FindAsync(id);
            if (articulo == null)
            {
                return NotFound();
            }

            var model = new ArticuloViewModel
            {
                IdArticulo=articulo.IdArticulo,
                DescripcionArticulo = articulo.DescripcionArticulo,
                IdProveedor = articulo.IdProveedor,
                IdClasificacion = articulo.IdClasificacion,
                IdPresentacion = articulo.IdPresentacion,
                Disponible = articulo.Disponible,
                CostoUnitario = articulo.CostoUnitario,
                PrecioVenta = articulo.PrecioVenta
            };

            // Llenar las listas desplegables
            ViewData["Clasificacion"] = new SelectList(_context.TbCatClasificacionArts, "IdClasificacion", "DescripcionClasificacion", model.IdClasificacion);
            ViewData["Presentacion"] = new SelectList(_context.TbCatPresentacionArts, "IdPresentacion", "DescripcionPresentacion", model.IdPresentacion);
            ViewData["Proveedor"] = new SelectList(_context.TbCatProveedors, "IdProveedor", "NombreProveedor", model.IdProveedor);

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, ArticuloViewModel model)
        {
            if (id != model.IdArticulo)
            {
                return BadRequest();
            }

            if (ModelState.IsValid)
            {
                var articulo = await _context.TbCatArticulos.FindAsync(id);
                if (articulo == null)
                {
                    return NotFound();
                }

                // Asignar los nuevos valores
                articulo.DescripcionArticulo = model.DescripcionArticulo;
                articulo.IdProveedor = model.IdProveedor;
                articulo.IdClasificacion = model.IdClasificacion;
                articulo.IdPresentacion = model.IdPresentacion;
                articulo.Disponible = model.Disponible;
                articulo.CostoUnitario = model.CostoUnitario;
                articulo.PrecioVenta = model.PrecioVenta;

                try
                {
                    _context.Update(articulo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!_context.TbCatArticulos.Any(e => e.IdArticulo == id))
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
            ViewData["Clasificacion"] = new SelectList(_context.TbCatClasificacionArts, "IdClasificacion", "DescripcionClasificacion", model.IdClasificacion);
            ViewData["Presentacion"] = new SelectList(_context.TbCatPresentacionArts, "IdPresentacion", "DescripcionPresentacion", model.IdPresentacion);
            ViewData["Proveedor"] = new SelectList(_context.TbCatProveedors, "IdProveedor", "NombreProveedor", model.IdProveedor);

            return View(model);
        }

        //Eliminar

        // Método GET para mostrar la vista de confirmación de eliminación
        public async Task<IActionResult> Delete(int id)
        {
            // Buscar el artículo por su ID
            var articulo = await _context.TbCatArticulos.FindAsync(id);

            // Si no se encuentra el artículo, devuelve un error 404
            if (articulo == null)
            {
                return NotFound();
            }

            // Si el artículo existe, se pasa al modelo de la vista
            return View(articulo);
        }

        // Método POST para realizar la eliminación
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            // Buscar el artículo por su ID
            var articulo = await _context.TbCatArticulos.FindAsync(id);

            // Si el artículo no existe, devuelve un error 404
            if (articulo == null)
            {
                return NotFound();
            }

            // Eliminar el artículo de la base de datos
            _context.TbCatArticulos.Remove(articulo);
            await _context.SaveChangesAsync();

            // Redirigir al índice (lista de artículos) después de la eliminación
            return RedirectToAction(nameof(Index));
        }

    }

}
