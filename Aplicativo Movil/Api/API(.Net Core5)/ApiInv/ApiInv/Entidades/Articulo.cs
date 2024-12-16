using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiInv.Entidades
{
    public class Articulo
    {
       // public int Id { get; set; }

        [Key]
        public string ARTICULO { get; set; }
        public string DESCRIPCION { get; set; }
        public string PROVEEDOR { get; set; }
        public string TIPO { get; set; }
        public string UM { get; set; }


    }
}
