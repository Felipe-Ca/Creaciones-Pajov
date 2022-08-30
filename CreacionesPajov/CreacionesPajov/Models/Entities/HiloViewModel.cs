using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreacionesPajov.WEB.Models.Entities
{
    public class HiloViewModel
    {
        public string Descripcion { get; set; }

        public int Total { get; set; }
        public List<Hilo> Hilos { get; set; }
    }
}
