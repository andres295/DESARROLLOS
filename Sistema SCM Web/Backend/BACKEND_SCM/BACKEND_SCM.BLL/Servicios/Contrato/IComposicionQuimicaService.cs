using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BACKEND_SCM.DTO;

namespace BACKEND_SCM.BLL.Servicios.Contrato
{
    public interface IComposicionQuimicaService
    {
        Task<List<ComposicionQuimicaDTO>> Lista();
    }
}
