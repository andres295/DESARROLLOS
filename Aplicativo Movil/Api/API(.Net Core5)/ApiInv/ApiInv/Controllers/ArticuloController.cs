using ApiInv.Data;
using Microsoft.AspNetCore.Mvc;

namespace ApiInv.Controllers
{
    public class ArticuloController : BaseApiController
    {
        public ArticuloController(DataContext context) : base(context)
        {

        }

    }
}
