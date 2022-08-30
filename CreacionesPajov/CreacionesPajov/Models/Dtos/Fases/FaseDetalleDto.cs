using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreacionesPajov.WEB.Models.Dtos.Fases
{
    public class FaseDetalleDto
    {
        public int FaseId { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public string Estado { get; set; }
    }
}
