using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InventarioApi.Models
{
    public class Conteo
    {
        
        public int conteo { get; set; }
        public string lote { get; set; }
        public DateTime fecha { get; set; }
        public string bodega { get; set; }
        public string codigo { get; set; }
        public string descripcion { get; set; }
        public decimal cantidad { get; set; }
        public string proveedor { get; set; }
        public string tipo { get; set; }
        public string ubicacion { get; set; }
        public string rack { get; set; }
        public string um { get; set; }
        public string user { get; set; }
        //public string grupo { get; set; }
    }
}