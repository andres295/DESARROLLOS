using InventarioApi.Data;
using InventarioApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace InventarioApi.Controllers
{
    public class UbicacionesController : ApiController
    {



        public List<UBICACIONES> GetUbicacion(string id)
        {
            return DataArticulo.ObtenerUbicacion(id);
        }

        //public List<UBICACIONES> Get()
        //{       
        //    return DataArticulo.ListarUbicacion();
        //}
    }
}
