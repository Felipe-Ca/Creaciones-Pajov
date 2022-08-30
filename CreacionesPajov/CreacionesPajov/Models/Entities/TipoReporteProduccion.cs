using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreacionesPajov.WEB.Models.Entities
{
    public class TipoReporteProduccion
    {
        public int TipoReporteProduccionId { get; set; }

        public string Nombre { get; set; }

        public virtual List<ReporteProduccion> ReportesProduccion { get; set; }

    }
}
