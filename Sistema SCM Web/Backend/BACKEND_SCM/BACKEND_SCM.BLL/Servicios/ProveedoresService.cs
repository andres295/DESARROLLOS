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
    public class ProveedoresService:IProveedoresService
    {
        private readonly IGenericRepository<Proveedore> _proveedoresRepositorio;
        private readonly IMapper _mapper;

        public ProveedoresService(IGenericRepository<Proveedore> proveedoresRepositorio, IMapper mapper)
        {
            _proveedoresRepositorio = proveedoresRepositorio;
            _mapper = mapper;
        }

        public async Task<List<ProveedoresDTO>> Lista()
        {
            var listaProveedores = await _proveedoresRepositorio.Consultar();
            return _mapper.Map<List<ProveedoresDTO>>(listaProveedores.ToList());
        }
    }
}
