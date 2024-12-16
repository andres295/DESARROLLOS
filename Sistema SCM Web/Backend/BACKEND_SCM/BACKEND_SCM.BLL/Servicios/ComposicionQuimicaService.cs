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
    public class ComposicionQuimicaService:IComposicionQuimicaService
    {
        private readonly IGenericRepository<ComposicionQuimicaDTO> _composicionRepositorio;
        private readonly IMapper _mapper;

        public ComposicionQuimicaService(IGenericRepository<ComposicionQuimicaDTO> composicionRepositorio, IMapper mapper)
        {
            _composicionRepositorio = composicionRepositorio;
            _mapper = mapper;
        }

        public async Task<List<ComposicionQuimicaDTO>> Lista()
        {
            var listacomposicionQuimica = await _composicionRepositorio.Consultar();
            return _mapper.Map<List<ComposicionQuimicaDTO>>(listacomposicionQuimica.ToList());
            
        }
    }
}
