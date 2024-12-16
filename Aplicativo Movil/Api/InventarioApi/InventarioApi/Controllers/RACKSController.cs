using InventarioApi.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace InventarioApi.Models
{
    public class RACKSController : ApiController
    {
        // GET: RACKS
        public List<RACKS> GetAll()
        {
            return DataArticulo.ListaRacks();
        }
    }
}