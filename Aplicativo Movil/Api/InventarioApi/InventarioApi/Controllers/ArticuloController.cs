using InventarioApi.Data;
using InventarioApi.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace InventarioApi.Controllers
{
    public class ArticuloController : ApiController
    {
        // GET api/<controller>
        public List<Articulos> Get()
        {
            return DataArticulo.Listar();
        }

        public  Articulos Get (string id)
        {
            return   DataArticulo.Obtener(id);
        }
        public bool Post([FromBody]Conteo oConteo)
        {
            return DataArticulo.Registrar(oConteo);
        } 

         
    }
}
