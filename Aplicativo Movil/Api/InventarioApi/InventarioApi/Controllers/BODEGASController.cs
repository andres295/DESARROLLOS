using InventarioApi.Data;
using InventarioApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace InventarioApi.Controllers
{
    public class BODEGASController : ApiController
    {
        // GET: BODEGAS
        public List<BODEGAS> GetAll()
        {
            return DataArticulo.ListaBodegas();
        }
    }
}