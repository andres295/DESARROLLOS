using ApiInv.Data;
using ApiInv.Dtos;
using ApiInv.Entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiInv.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InventaController : BaseApiController
    {
        public InventaController(DataContext context):base(context)
        {

        }

        public async Task<IActionResult> Get()
        {
            var inventarios = await _context.Inventa.ToListAsync();

            

            var inventaToListDto = new List<InventoToListDto>();
            foreach (var inventa in inventarios)
            {
                inventaToListDto.Add(new InventoToListDto 
                { 
                    Codigo = inventa.Codigo,
                    Bodega = inventa.Bodega,
                    Lote = inventa.Bodega
                });
            }

            return Ok(inventaToListDto);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Articulo>> GetArticuloItem(string id)
        {
            var articuloItem = await _context.Articulo.FindAsync(id);
            if(articuloItem == null)
            {
                return NotFound();
            }

            return articuloItem;
        }




        // POST api/<InventaController>
        [HttpPost]
        public async Task<IActionResult> ActualizarConteoInventario([FromBody] ActualizarConteoInventarioDto conteoInventario)
        {
            int tipoConteo = conteoInventario.Conteo;
            string bodega = conteoInventario.Bodega;
            string descripcion = conteoInventario.Descripcion;
            string usuario = conteoInventario.User;
            
               

            if (tipoConteo <= 0 && tipoConteo > 15)
            {
                return BadRequest("Ingrese el conteo");
            }

            if (string.IsNullOrEmpty(bodega))
            {
                return BadRequest("Ingrese la bodega");
            }

            if (string.IsNullOrEmpty(descripcion))
            {
                return BadRequest("Ingrese la descripcion");
            }

            bool existeInventa = await _context.Inventa.AnyAsync(inv => inv.Lote == conteoInventario.Lote &&
            inv.Codigo == conteoInventario.Codigo && 
            inv.Bodega == conteoInventario.Bodega && 
            inv.Fecha == conteoInventario.Fecha   &&
            inv.Rack  == conteoInventario.Rack    &&
            inv.Ubicacion == conteoInventario.Ubicacion);

            if (!existeInventa)
            {
                var inventaToCreate = new Inventa
                {
                    Id = Guid.NewGuid(),
                    Bodega = conteoInventario.Bodega,
                    Cantidad = conteoInventario.Cantidad,
                    Fecha = conteoInventario.Fecha,
                    Codigo = conteoInventario.Codigo,
                    Conteo1 = 0,
                    Conteo2 = 0,
                    Conteo3 = 0,
                    Conteo4 = 0,
                    Conteo5 = 0,
                    Conteo6 = 0,
                    Conteo7 = 0,
                    Conteo8 = 0,
                    Conteo9 = 0,
                    Conteo10 = 0,
                    Conteo11 = 0,
                    Conteo12 = 0,
                    Conteo13 = 0,
                    Conteo14 = 0,
                    Conteo15 = 0,
                    User1 = null,
                    User2 = null,
                    User3 = null,
                    User4 = null,
                    User5 = null,
                    User6 = null,
                    User7 = null,
                    User8 = null,
                    User9 = null,
                    User10 = null,
                    User12 = null,
                    User13 = null,
                    User14 = null,
                    User15 = null,
                    Descripcion = conteoInventario.Descripcion,
                    Lote = conteoInventario.Lote,
                    Proveedor = conteoInventario.Proveedor,
                    Rack = conteoInventario.Rack,
                    Tipo = conteoInventario.Tipo,
                    Ubicacion = conteoInventario.Ubicacion,
                    Um = conteoInventario.Um
                };

                _context.Add(inventaToCreate);
                await _context.SaveChangesAsync();
            }

            var inventaToUpdate = await _context.Inventa
                .Where(inv => inv.Lote == conteoInventario.Lote &&
                    inv.Codigo == conteoInventario.Codigo &&
                    inv.Bodega == conteoInventario.Bodega &&
                    inv.Rack   == conteoInventario.Rack   &&
                    inv.Ubicacion == conteoInventario.Ubicacion &&
                    inv.Fecha == conteoInventario.Fecha).FirstOrDefaultAsync();

            if (inventaToUpdate != null)
            {
                decimal cantidad = conteoInventario.Cantidad;

                if (tipoConteo == 1)
                {
                    inventaToUpdate.Conteo1 = inventaToUpdate.Conteo1 + cantidad;
                    inventaToUpdate.Cantidad = inventaToUpdate.Conteo1;
                    inventaToUpdate.Host1 = Environment.MachineName;
                    inventaToUpdate.User1 = conteoInventario.User;
                }
                else if (tipoConteo == 2)
                {
                    inventaToUpdate.Conteo2 = inventaToUpdate.Conteo2 + cantidad;
                    inventaToUpdate.Cantidad = inventaToUpdate.Conteo2;
                    inventaToUpdate.Host2 = Environment.MachineName;
                    inventaToUpdate.User2 = conteoInventario.User;
                }
                else if (tipoConteo == 3)
                {
                    inventaToUpdate.Conteo3 = inventaToUpdate.Conteo3 + cantidad;
                    inventaToUpdate.Cantidad = inventaToUpdate.Conteo3;
                    inventaToUpdate.Host3 = Environment.MachineName;
                    inventaToUpdate.User3 = conteoInventario.User;
                }

                else if (tipoConteo == 4)
                {
                    inventaToUpdate.Conteo4 = inventaToUpdate.Conteo4 + cantidad;
                    inventaToUpdate.Cantidad = inventaToUpdate.Conteo4;
                    inventaToUpdate.Host4 = Environment.MachineName;
                    inventaToUpdate.User4 = conteoInventario.User;
                }

                else if (tipoConteo == 5)
                {
                    inventaToUpdate.Conteo5 = inventaToUpdate.Conteo5 + cantidad;
                    inventaToUpdate.Cantidad = inventaToUpdate.Conteo5;
                    inventaToUpdate.Host5 = Environment.MachineName;
                    inventaToUpdate.User5 = conteoInventario.User;
                }
                else if (tipoConteo == 6)
                {
                    inventaToUpdate.Conteo6 = inventaToUpdate.Conteo6 + cantidad;
                    inventaToUpdate.Cantidad = inventaToUpdate.Conteo6;
                    inventaToUpdate.Host6 = Environment.MachineName;
                    inventaToUpdate.User6 = conteoInventario.User;
                }
                else if (tipoConteo == 7)
                {
                    inventaToUpdate.Conteo7 = inventaToUpdate.Conteo7 + cantidad;
                    inventaToUpdate.Cantidad = inventaToUpdate.Conteo7;
                    inventaToUpdate.Host7 = Environment.MachineName;
                    inventaToUpdate.User7 = conteoInventario.User;
                }
                else if (tipoConteo == 8)
                {
                    inventaToUpdate.Conteo8 = inventaToUpdate.Conteo8 + cantidad;
                    inventaToUpdate.Cantidad = inventaToUpdate.Conteo8;
                    inventaToUpdate.Host8 = Environment.MachineName;
                    inventaToUpdate.User8 = conteoInventario.User;
                }
                else if (tipoConteo == 9)
                {
                    inventaToUpdate.Conteo9 = inventaToUpdate.Conteo9 + cantidad;
                    inventaToUpdate.Cantidad = inventaToUpdate.Conteo9;
                    inventaToUpdate.Host9 = Environment.MachineName;
                    inventaToUpdate.User9 = conteoInventario.User;
                }
                else if (tipoConteo == 10)
                {
                    inventaToUpdate.Conteo10 = inventaToUpdate.Conteo10 + cantidad;
                    inventaToUpdate.Cantidad = inventaToUpdate.Conteo10;
                    inventaToUpdate.Host10 = Environment.MachineName;
                    inventaToUpdate.User10 = conteoInventario.User;
                }
                else if (tipoConteo == 11)
                {
                    inventaToUpdate.Conteo11 = inventaToUpdate.Conteo11 + cantidad;
                    inventaToUpdate.Cantidad = inventaToUpdate.Conteo11;
                    inventaToUpdate.Host11 = Environment.MachineName;
                    inventaToUpdate.User11 = conteoInventario.User;
                }
                else if (tipoConteo == 12)
                {
                    inventaToUpdate.Conteo12 = inventaToUpdate.Conteo12 + cantidad;
                    inventaToUpdate.Cantidad = inventaToUpdate.Conteo12;
                    inventaToUpdate.Host12 = Environment.MachineName;
                    inventaToUpdate.User12 = conteoInventario.User;
                }
                else if (tipoConteo == 13)
                {
                    inventaToUpdate.Conteo13 = inventaToUpdate.Conteo13 + cantidad;
                    inventaToUpdate.Cantidad = inventaToUpdate.Conteo13;
                    inventaToUpdate.Host13 = Environment.MachineName;
                    inventaToUpdate.User13 = conteoInventario.User;
                }
                else if (tipoConteo == 14)
                {
                    inventaToUpdate.Conteo14 = inventaToUpdate.Conteo14 + cantidad;
                    inventaToUpdate.Cantidad = inventaToUpdate.Conteo14;
                    inventaToUpdate.Host14 = Environment.MachineName;
                    inventaToUpdate.User14 = conteoInventario.User;
                }
                else if (tipoConteo == 15)
                {
                    inventaToUpdate.Conteo15 = inventaToUpdate.Conteo15 + cantidad;
                    inventaToUpdate.Cantidad = inventaToUpdate.Conteo15;
                    inventaToUpdate.Host15 = Environment.MachineName;
                    inventaToUpdate.User15 = conteoInventario.User;
                }

                _context.Update(inventaToUpdate);
                await _context.SaveChangesAsync();
            }

            return NoContent();
        }

        // PUT api/<InventaController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<InventaController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
