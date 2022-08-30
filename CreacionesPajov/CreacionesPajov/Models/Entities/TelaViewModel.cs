using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreacionesPajov.WEB.Models.Entities
{
    public class TelaViewModel
    {
        public int Total { get; set; }

        public string Descripcion { get; set; }
        public List<Tela> Telas { get; set; }
    }
}
