using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiInv.Dtos
{
    public class ActualizarConteoInventarioDto
    {

       public int Conteo { get; set; }
       public string Lote { get; set; }
       public DateTime Fecha { get; set; }
        public string Bodega { get; set; }
        public string Codigo { get; set; }
        public string User { get; set; }
        public string Descripcion { get; set; }
        public string Proveedor { get; set; }
        public string Tipo { get; set; }
        public string Um { get; set; }
        public string Rack { get; set; }
        public string Ubicacion { get; set; }
        public decimal Cantidad { get; set; }



    }
}
