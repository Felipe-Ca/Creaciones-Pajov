using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreacionesPajov.WEB.Models.Entities
{
    public class ControlLoteViewModel
    {
        public int Total { get; set; }

        public List<ControlLote> ControlLotes { get; set; }
    }
}
