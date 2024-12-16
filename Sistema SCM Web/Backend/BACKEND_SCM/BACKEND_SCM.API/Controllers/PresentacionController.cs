using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using BACKEND_SCM.BLL.Servicios.Contrato;
using BACKEND_SCM.DTO;
using BACKEND_SCM.API.Utilidad;

namespace BACKEND_SCM.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PresentacionController : ControllerBase
    {
        private readonly IPresentacionService _presentacionServicio;

        public PresentacionController(IPresentacionService presentacionServicio)
        {
            _presentacionServicio = presentacionServicio;
        }

        [HttpGet]
        [Route("Lista")]
        public async Task<IActionResult> Lista()
        {
            var rsp = new Response<List<PresentacionDTO>>();
            try
            {
                rsp.status = true;
                rsp.value = await _presentacionServicio.Lista();
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
