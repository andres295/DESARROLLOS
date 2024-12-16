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
    public class PresentacionService:IPresentacionService
    {
        private readonly IGenericRepository<Presentacione> _presentacionesRepositorio;
        private readonly IMapper _mapper;

        public PresentacionService(IGenericRepository<Presentacione> presentacionesRepositorio, IMapper mapper)
        {
            _presentacionesRepositorio = presentacionesRepositorio;
            _mapper = mapper;
        }

        public async Task<List<PresentacionDTO>> Lista()
        {
            var listaPresentaciones = await _presentacionesRepositorio.Consultar();
            return _mapper.Map<List<PresentacionDTO>>(listaPresentaciones.ToList());
        }
    }
}
