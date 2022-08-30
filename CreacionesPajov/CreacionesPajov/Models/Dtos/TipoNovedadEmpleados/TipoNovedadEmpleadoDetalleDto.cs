using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreacionesPajov.WEB.Models.Dtos.TipoNovedadEmpleados
{
    public class TipoNovedadEmpleadoDetalleDto
    {
        public int TipoNovedadEmpleadoId { get; set; }
        public string Empleado { get; set; }
        public string Descripcion { get; set; }

    }
}
