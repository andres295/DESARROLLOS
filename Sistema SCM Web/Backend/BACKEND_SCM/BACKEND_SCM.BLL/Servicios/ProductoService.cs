using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BACKEND_SCM.BLL.Servicios.Contrato;
using BACKEND_SCM.DAL.Repositorios.Contrato;
using BACKEND_SCM.DTO;
using BACKEND_SCM.MODEL;
using Microsoft.EntityFrameworkCore;

namespace BACKEND_SCM.BLL.Servicios
{
    public class ProductoService :IProductoService
    {
        private readonly IGenericRepository<Producto> _productosRepositorio;
        private readonly IMapper _mapper;

        public ProductoService(IGenericRepository<Producto> productosRepositorio, IMapper mapper)
        {
            _productosRepositorio = productosRepositorio;
            _mapper = mapper;
        }


        public async Task<List<ProductoDTO>> Lista()
        {

            #region CodigoAnterior
            /*try
            {
                var queryProducto = await _productosRepositorio.Consultar();
                var lisProductos = queryProducto.Include(e => e.IdEspecificacionNavigation)
                    .Include(e => e.IdProveedorNavigation)
                    .Include(e => e.IdPresentacionNavigation).ToList();

                return _mapper.Map<List<ProductoDTO>>(lisProductos.ToList());
                  
            }
            catch 
            {

                throw;
            }
        }*/
            #endregion

            //Codigo Mejorado
            try
            {
                var queryProducto = await _productosRepositorio.Consultar();
                var lisProductos = await queryProducto
                    .Include(e => e.IdEspecificacionNavigation)
                    .Include(e => e.IdProveedorNavigation)
                    .Include(e => e.IdPresentacionNavigation)
                    .ToListAsync();

                if (lisProductos == null || !lisProductos.Any())
                {
                    // Manejo de caso sin productos
                    return new List<ProductoDTO>();
                }

                return _mapper.Map<List<ProductoDTO>>(lisProductos);
            }
            catch (Exception ex)
            {
                // Manejo de excepciones
                throw new TaskCanceledException("An error occurred while fetching products.", ex);
            }
        }

            public async Task<ProductoDTO> Crear(ProductoDTO modelo)
        {
            try
            {
                var productoCreado = await _productosRepositorio.Crear(_mapper.Map<Producto>(modelo));
                if (productoCreado.Id == 0)
                    throw new TaskCanceledException("No se pudo crear el producto");
                return _mapper.Map<ProductoDTO>(productoCreado);
            }
            catch 
            {

                throw;
            }
        }

        public async Task<bool> Editar(ProductoDTO modelo)
        {
            try
            {
                var productoModelo = _mapper.Map<Producto>(modelo);
                var productoEncontrado = await _productosRepositorio.Obtener(u => u.Id == productoModelo.Id);
                if (productoEncontrado == null)
                    throw new TaskCanceledException("El producto no existe");

                productoEncontrado.CodigoBarra = productoModelo.CodigoBarra;
                productoEncontrado.Producto1 = productoModelo.Producto1;
                productoEncontrado.IdPresentacion = productoModelo.IdPresentacion;
                productoEncontrado.IdProveedor = productoModelo.IdProveedor;
                productoEncontrado.Pvf = productoModelo.Pvf;
                productoEncontrado.Pvp = productoModelo.Pvp;
                productoEncontrado.Contiene = productoModelo.Contiene;
                productoEncontrado.Estado = productoModelo.Estado;
                productoEncontrado.Disponible = productoModelo.Disponible;
                productoEncontrado.IdEspecificacion = productoModelo.IdEspecificacion;
                productoEncontrado.RegistroSanitario = productoModelo.RegistroSanitario;

                bool respuesta = await _productosRepositorio.Editar(productoEncontrado);

                if (!respuesta)
                    throw new TaskCanceledException("No se pudo editar");

                return respuesta;

            }
            catch 
            {

                throw;
            }
        }

        public async Task<bool> Eliminar(int id)
        {
            try
            {
                var productoEncontrado = await _productosRepositorio.Obtener(p => p.Id == id);

                if(productoEncontrado == null)
                    throw new TaskCanceledException("El producto no existe");

                bool respuesta = await _productosRepositorio.Eliminar(productoEncontrado);

                if (!respuesta)
                    throw new TaskCanceledException("No se pudo eliminar");

                return respuesta;

            }
            catch 
            {

                throw;
            }
        }

   
    }
}
