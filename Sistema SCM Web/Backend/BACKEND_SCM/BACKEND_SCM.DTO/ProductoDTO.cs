using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BACKEND_SCM.DTO
{
    public class ProductoDTO
    {
        public long Id { get; set; }

        public string? CodigoBarra { get; set; }

        public string? Producto1 { get; set; }

        public long? IdPresentacion { get; set; }
        public string? DescripcionPresentacion { get; set; }

        public long? IdProveedor { get; set; }
        public string? NombreProveedor { get; set; }

        public string? Pvf { get; set; }

        public string? Pvp { get; set; }

        public int? Contiene { get; set; }

       // public DateOnly? Vencimiento { get; set; }

        public string? Estado { get; set; }

        //public decimal? Descuento { get; set; }

        //public DateOnly? DescuentoDesde { get; set; }

        //public DateOnly? DescuentoHasta { get; set; }
        public long? Disponible { get; set; }
        //public string? Lote { get; set; }

        //public string? Foto { get; set; }

        //public decimal? Iva { get; set; }

        //public decimal? Pur { get; set; }

        //public decimal? Utilidad { get; set; }

        public long? IdEspecificacion { get; set; }
        public string? DescripcionEspecifiacion { get; set; }

        //public int? IdComposicion { get; set; }
        //public string? DescripcionComposicion { get; set; }

        //public bool? PvpIva { get; set; }

        public string? RegistroSanitario { get; set; }
    
    }
}
