﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BACKEND_SCM.DTO
{
    public class VentaDTO
    {
        public int IdVenta { get; set; }

        public string? NumeroDocumento { get; set; }

        public string? TipoPago { get; set; }

        public string? TotalTexto { get; set; }

        public string? FechaRegistro { get; set; }
        public virtual ICollection<DetalleVentaDTO> IdDetalleVenta { get; set; }
    }
}
