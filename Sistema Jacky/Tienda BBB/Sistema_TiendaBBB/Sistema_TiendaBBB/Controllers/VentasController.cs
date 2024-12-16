using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Sistema_TiendaBBB.Models;
using System.Linq;

namespace Sistema_TiendaBBB.Controllers
{
    public class VentasController : Controller
    {
        private readonly BdBbbContext _context;

        public VentasController(BdBbbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            // Obtener todas las ventas con la información del artículo y el cliente
            var ventas = _context.TbVentas
                .Include(v => v.IdArticuloNavigation)  // Incluye la relación con el artículo
                .Include(v => v.IdClienteNavigation)   // Incluye la relación con el cliente
                .ToList();

            return View(ventas);  // Pasar la lista de ventas a la vista
        }


        public IActionResult CrearVenta()
        {
            ViewBag.Articulos = new SelectList(_context.TbCatArticulos.ToList(), "IdArticulo", "DescripcionArticulo");
            ViewBag.Clientes = new SelectList(_context.TbCatClientes.ToList(), "IdCliente", "NombreCliente");

            return View(new VentaViewModel());
        }

        [HttpPost]
        public IActionResult CrearVenta(VentaViewModel model)
        {
            if (ModelState.IsValid)
            {
                var venta = new TbVenta
                {
                    IdArticulo = model.IdArticulo,
                    IdCliente = model.IdCliente,
                    Cantidad = model.Cantidad,
                    PrecioUnitario = model.PrecioUnitario,
                    Subtotal = model.Subtotal,
                    Total = model.Total,
                    FechaRegistro = model.FechaRegistro
                };

                _context.TbVentas.Add(venta);
                _context.SaveChanges();

                return RedirectToAction("Index");
            }

            ViewBag.Articulos = new SelectList(_context.TbCatArticulos.ToList(), "IdArticulo", "DescripcionArticulo");
            ViewBag.Clientes = new SelectList(_context.TbCatClientes.ToList(), "IdCliente", "NombreCliente");
            return View(model);
        }

        [HttpGet]
        public IActionResult GetPrecioUnitario(int id)
        {
            var articulo = _context.TbCatArticulos.FirstOrDefault(a => a.IdArticulo == id);
            if (articulo == null) return Json(new { precioUnitario = 0 });

            return Json(new { precioUnitario = articulo.PrecioVenta });
        }
    }
}
