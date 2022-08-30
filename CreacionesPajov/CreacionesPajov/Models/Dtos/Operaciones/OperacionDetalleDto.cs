using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreacionesPajov.WEB.Models.Dtos.Operaciones
{
    public class OperacionDetalleDto
    {
        public int OperacionId { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public string TipoOperacion { get; set; }

        public double SAM { get; set; }

        public string Estado { get; set; }
    }
}
