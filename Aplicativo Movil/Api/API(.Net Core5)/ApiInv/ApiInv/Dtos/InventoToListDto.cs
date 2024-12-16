using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiInv.Dtos
{
    public class InventoToListDto
    {
        public string Bodega { get; set; }
        public string Lote { get; set; }
        public string Codigo { get; set; }
    }
}
