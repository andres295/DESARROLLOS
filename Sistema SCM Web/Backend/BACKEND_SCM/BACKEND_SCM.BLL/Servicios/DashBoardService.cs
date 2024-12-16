using System;
using System.Collections.Generic;
using System.Globalization;
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
    public class DashBoardService:IDashBoardService
    {

        private readonly IVentaRepository _ventaRepositorio;
        private readonly IGenericRepository<Producto> _productoRepositorio;
        private readonly IMapper _mapper;

        public DashBoardService(IVentaRepository ventaRepositorio, IGenericRepository<Producto> productoRepositorio, IMapper mapper)
        {
            _ventaRepositorio = ventaRepositorio;
            _productoRepositorio = productoRepositorio;
            _mapper = mapper;
        }
        private IQueryable<Ventum> retornarVentas(IQueryable<Ventum> tablaVenta, int restarCantidadDias)
        {
            DateTime? ultimaFecha = tablaVenta.OrderByDescending(v => v.FechaRegistro).Select(v => v.FechaRegistro).First();

            ultimaFecha = ultimaFecha.Value.AddDays(restarCantidadDias);
            return tablaVenta.Where(v => v.FechaRegistro.Value.Date >= ultimaFecha.Value.Date);

        }
        private async Task<int> TotalVentasUltimasSemana()
        {
            int Total = 0;

            IQueryable<Ventum> _ventaQuery = await _ventaRepositorio.Consultar();
            if(_ventaQuery.Count() > 0)
            {
                var tablaVenta = retornarVentas(_ventaQuery, -7);
                Total = tablaVenta.Count();
            }

            return Total;
        }

        private async Task<string> TotalIngresosUltimasSemana()
        {
            decimal resultado = 0;

            IQueryable<Ventum> _ventaQuery = await _ventaRepositorio.Consultar();
            if (_ventaQuery.Count() > 0)
            {
                var tablaVenta = retornarVentas(_ventaQuery, -7);
                resultado = tablaVenta.Select(v => v.Total).Sum(v => v.Value);
            }

            return Convert.ToString(resultado, new CultureInfo("es-419"));
        }

        private async Task<int> TotalProductos()
        {
            IQueryable<Producto> _productoQuery = await _productoRepositorio.Consultar();
            int total = _productoQuery.Count();

            return total;
        }


        private async Task<Dictionary<string,int>> VentasUltimaSemana()
        {
            Dictionary<string, int> resultado = new Dictionary<string, int>();

            IQueryable<Ventum> _ventaQuery = await _ventaRepositorio.Consultar();
            if (_ventaQuery.Count() > 0)
            {
                var tablaVenta = retornarVentas(_ventaQuery, -7);


                resultado = tablaVenta
                    .GroupBy(v => v.FechaRegistro.Value.Date).OrderBy(g => g.Key)
                    .Select(dv => new { fecha = dv.Key.ToString("dd/MM/yyyy"), total = dv.Count() })
                    .ToDictionary(keySelector: r => r.fecha, elementSelector: r => r.total);

            }
            return resultado;
        }

        public async Task<DashBoardDTO> Resumen()
        {
            DashBoardDTO vmDashBoard = new DashBoardDTO();

            try
            {

                vmDashBoard.TotalVentas = await TotalVentasUltimasSemana();
                vmDashBoard.TotalIngresos = await TotalIngresosUltimasSemana();
                vmDashBoard.TotalProductos = await TotalProductos();

                List<VentasSemanasDTO> listaVentaSemana = new List<VentasSemanasDTO>();
                foreach (KeyValuePair<string,int> item in await VentasUltimaSemana())
                {
                    listaVentaSemana.Add(
                            new VentasSemanasDTO()
                            {
                                Fecha = item.Key,
                                Total = item.Value
                            });
                }
                vmDashBoard.VentasUltimaSemana = listaVentaSemana;

            }
            catch
            {

                throw;
            }
            return vmDashBoard;
        }
    }
}
