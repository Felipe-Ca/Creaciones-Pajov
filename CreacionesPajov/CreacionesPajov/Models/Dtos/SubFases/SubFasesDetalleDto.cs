using CreacionesPajov.WEB.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreacionesPajov.WEB.Models.Dtos.SubFases
{
    public class SubFasesDetalleDto
    {
        public int SubFaseId { get; set; }
        public String Nombre { get; set; }
        public String Descripcion { get; set; }
        public string Operacion { get; set; }
        public string Fase { get; set; }
        public bool Estado { get; set; }
    }
}
