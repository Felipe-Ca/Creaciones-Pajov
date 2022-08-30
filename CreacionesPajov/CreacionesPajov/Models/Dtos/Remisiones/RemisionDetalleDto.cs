using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreacionesPajov.WEB.Models.Dtos.Remisiones
{
    public class RemisionDetalleDto
    {
        public int RemisionId { get; set; }
        public int CantidadPrendas { get; set; }
        public String Direccion { get; set; }
        public String Encargado { get; set; }
        public DateTime FechaLlegada { get; set; }
        public DateTime FechaSalida { get; set; }
        public String Observacion { get; set; }
        public bool Estado { get; set; }
        public string Fase { get; set; }
    }
}
