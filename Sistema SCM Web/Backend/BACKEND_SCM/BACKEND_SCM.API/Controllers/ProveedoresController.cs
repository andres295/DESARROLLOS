using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BACKEND_SCM.BLL.Servicios.Contrato;
using BACKEND_SCM.DTO;
using BACKEND_SCM.API.Utilidad;

namespace BACKEND_SCM.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProveedoresController : ControllerBase
    {
        private readonly IProveedoresService _proveedoresServicio;

        public ProveedoresController(IProveedoresService proveedoresServicio)
        {
            _proveedoresServicio = proveedoresServicio;
        }

        [HttpGet]
        [Route("Lista")]
        public async Task<IActionResult> Lista()
        {
            var rsp = new Response<List<ProveedoresDTO>>();
            try
            {
                rsp.status = true;
                rsp.value = await _proveedoresServicio.Lista();
            }
            catch (Exception ex)
            {

                rsp.status = false;
                rsp.msg = ex.Message;
            }
            return Ok(rsp);

        }

    }
}
