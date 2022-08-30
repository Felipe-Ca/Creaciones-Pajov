using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreacionesPajov.WEB.Models.Dtos.SubFases
{
    public class SubFaseResumenDto
    {
        public String Nombre { get; set; }
        public String Descripcion { get; set; }
        public String Operacion { get; set; }
        public String Fase { get; set; }
        public bool Estado { get; set; }
    }
}
