using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InventarioApi.Models
{
    public class Articulos
    {
        public string ARTICULO { get; set; }
        public string DESCRIPCION { get; set; }

        public string PROVEEDOR { get; set; }
        public string TIPO { get; set; }
        public string UM { get; set; }

    }
}