using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreacionesPajov.WEB.Models.Entities
{
    public class TipoJornada
    {
        public int TipoJornadaId { get; set; }

        public string Nombre { get; set; }

        public virtual List<ProduccionGrupal> ProduccionesGrupales { get; set; }
    }
}
