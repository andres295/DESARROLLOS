using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiInv.Entidades
{
    public class Ubicaciones
    {
        public Guid Id { get; set; }
        public string UBICACION { get; set; }
        public Guid InventaId { get; set; }
        public Inventa Inventa { get; set; }
    }
}
