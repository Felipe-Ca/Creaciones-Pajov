using System.Collections.Generic;

namespace CreacionesPajov.WEB.Models.Entities
{
    public class TipoDocumento
    {
        public int TipoDocumentoId { get; set; }   
        public string Nombre { get; set; }

        public virtual List<Empleado> Empleados { get; set; }
    }
}
