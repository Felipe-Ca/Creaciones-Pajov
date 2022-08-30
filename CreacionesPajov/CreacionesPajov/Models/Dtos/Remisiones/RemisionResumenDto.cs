using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreacionesPajov.WEB.Models.Dtos.Remisiones
{
    public class RemisionResumenDto
    {
        public int CantidadPrendas { get; set; }
        public String Direccion { get; set; }
        public String Encargado { get; set; }
        public String Observacion { get; set; }
        public bool Estado { get; set; }
        public string Fase { get; set; }
    }
}
