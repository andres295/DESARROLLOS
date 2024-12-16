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

namespace BACKEND_SCM.BLL.Servicios
{
    public class EspecificacionesService : IEspecificacionesService
    {
        private readonly IGenericRepository<Especificacione> _especificacionesRepositorio;
        private readonly IMapper _mapper;

        public EspecificacionesService(IGenericRepository<Especificacione> especificacionesRepositorio, IMapper mapper)
        {
            _especificacionesRepositorio = especificacionesRepositorio;
            _mapper = mapper;
        }

        public async Task<List<EspecificacionesDTO>> Lista()
        {
            try
            {
                var listaEspecificaciones = await _especificacionesRepositorio.Consultar();
                return _mapper.Map<List<EspecificacionesDTO>>(listaEspecificaciones.ToList());
            }
            catch 
            {

                throw;
            }
        }
    }
}
