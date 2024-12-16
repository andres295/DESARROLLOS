using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BACKEND_SCM.MODEL;

namespace BACKEND_SCM.DAL.Repositorios.Contrato
{
    public interface IVentaRepository : IGenericRepository<Ventum>
    {
        Task<Ventum> Registrar(Ventum venta);
    }
}
