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
    public class VentaService: IVentaService
    {
        private readonly IVentaRepository _ventaRepositorio;
        private readonly IGenericRepository<IdDetalleVentum> _detalleventaRepositorio;
        private readonly IMapper _mapper;

        public VentaService(IVentaRepository ventaRepositorio, 
            IGenericRepository<IdDetalleVentum> detalleventaRepositorio, IMapper mapper)
        {
            _ventaRepositorio = ventaRepositorio;
            _detalleventaRepositorio = detalleventaRepositorio;
            _mapper = mapper;
        }

        public async Task<VentaDTO> Registrar(VentaDTO modelo)
        {
            try
            {
                var ventaGenerada = await _ventaRepositorio.Registrar(_mapper.Map<Ventum>(modelo));

                if (ventaGenerada.IdVenta == 0)
                    throw new TaskCanceledException("No se pudo generar la venta");

                return _mapper.Map<VentaDTO>(ventaGenerada);
            }
            catch 
            {

                throw;
            }
        }

        public async Task<List<VentaDTO>> Historial(string buscarPor, string numeroVenta, string fechaInicio, string fechaFin)
        {
            IQueryable<Ventum> query = await _ventaRepositorio.Consultar();
            var ListaResultado = new List<Ventum>();

            try
            {
                if(buscarPor == "fecha")
                {
                    DateTime fech_Inicio = DateTime.ParseExact(fechaInicio, "dd/MM/yyyy", new CultureInfo("es-419"));
                    DateTime fech_Fin = DateTime.ParseExact(fechaFin, "dd/MM/yyyy", new CultureInfo("es-419"));

                    ListaResultado = await query.Where(v =>
                        v.FechaRegistro.Value.Date >= fech_Inicio.Date &&
                         v.FechaRegistro.Value.Date <= fech_Fin.Date

                        ).Include(dv => dv.IdDetalleVenta)
                        .ThenInclude(p => p.IdProductoNavigation)
                        .ToListAsync();
                }
                else
                {
                    ListaResultado = await query.Where(v => v.NumeroDocumento == numeroVenta

                        ).Include(dv => dv.IdDetalleVenta)
                        .ThenInclude(p => p.IdProductoNavigation)
                        .ToListAsync();

                }
            }
            catch 
            {

                throw;
            }
            return _mapper.Map<List<VentaDTO>>(ListaResultado);

        }
        public async Task<List<ReporteDTO>> Reporte(string fechaInicio, string fechaFin)
        {
            IQueryable<IdDetalleVentum> query = await _detalleventaRepositorio.Consultar();
            var ListaResultado = new List<IdDetalleVentum>();

            try
            {
                DateTime fech_Inicio = DateTime.ParseExact(fechaInicio, "dd/MM/yyyy", new CultureInfo("es-419"));
                DateTime fech_Fin = DateTime.ParseExact(fechaFin, "dd/MM/yyyy", new CultureInfo("es-419"));

                ListaResultado = await query
                    .Include(p => p.IdProductoNavigation)
                    .Include(v => v.IdVentaNavigation)
                    .Where(dv =>
                       dv.IdVentaNavigation.FechaRegistro.Value.Date >= fech_Inicio.Date &&
                       dv.IdVentaNavigation.FechaRegistro.Value.Date <= fech_Fin.Date
                    ).ToListAsync();
            }
            catch 
            {

                throw;
            }
            return _mapper.Map<List<ReporteDTO>>(ListaResultado);  
        }
    }
}
