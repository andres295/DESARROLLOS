using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BACKEND_SCM.DAL;
using BACKEND_SCM.DAL.Repositorios.Contrato;
using BACKEND_SCM.MODEL;
using Microsoft.IdentityModel.Abstractions;


namespace BACKEND_SCM.DAL.Repositorios
{
    public class VentaRepository:GenericRepository<Ventum>, IVentaRepository
    {

        private readonly ScmContext _dbcontext;

        public VentaRepository(ScmContext dbcontext):base(dbcontext) 
        {
            _dbcontext = dbcontext;
        }

        public async Task<Ventum> Registrar(Ventum modelo)
        {
            Ventum ventaGenerada = new Ventum();
            //ACA UTILIZAREMOS TRANSACCIONES.
            using(var transaction = _dbcontext.Database.BeginTransaction())
            {
                try
                {
                    //restar cada producto que esta dentro de la venta, restar stock de la tabla de productos.
                    foreach (IdDetalleVentum dv in modelo.IdDetalleVenta)
                    {
                        Producto producto_encontrado = _dbcontext.Productos.Where(p =>
                        p.Id == dv.IdProducto).First();

                        producto_encontrado.Disponible = producto_encontrado.Disponible - dv.Cantidad;
                        _dbcontext.Productos.Update(producto_encontrado);
                    }
                    await _dbcontext.SaveChangesAsync();

                    NumeroDocumento correlativo = _dbcontext.NumeroDocumentos.First();
                    correlativo.UltimoNumero = correlativo.UltimoNumero + 1;
                    correlativo.FechaRegistro = DateTime.Now;
                    _dbcontext.NumeroDocumentos.Update(correlativo);
                    await _dbcontext.SaveChangesAsync();

                    //generar formato de ventas 0001
                    int cantidadDigitos = 4;
                    string ceros = string.Concat(Enumerable.Repeat("0", cantidadDigitos));
                    string numeroVenta = ceros + correlativo.UltimoNumero.ToString();
                    numeroVenta = numeroVenta.Substring(numeroVenta.Length - cantidadDigitos, cantidadDigitos);

                    modelo.NumeroDocumento = numeroVenta;
                    await _dbcontext.Venta.AddAsync(modelo);
                    await _dbcontext.SaveChangesAsync();

                    ventaGenerada = modelo;
                    //se confirma el guardado.
                    transaction.Commit();
                }
                catch 
                {

                    transaction.Rollback();
                    throw;
                }
                return ventaGenerada;
            }
            
        }
    }
}
