using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreacionesPajov.WEB.Models.Dtos.Operaciones
{
    public class OperacionResumenDto
    {
        public String Nombre { get; set; }
        public String Descripcion { get; set; }

        public double SAM { get; set; }

        public string TipoOperacion { get; set; }

        public bool Estado { get; set; }
    }
}
