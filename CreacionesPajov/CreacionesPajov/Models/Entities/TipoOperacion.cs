using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreacionesPajov.WEB.Models.Entities
{
    public class TipoOperacion
    {
        public int TipoOperacionId { get; set; }
        public string Nombre { get; set; }

        public virtual List<Operacion> Operaciones { get; set; }
    }
}
