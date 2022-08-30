
using System;

namespace CreacionesPajov.WEB.Models.Dtos.Empleados
{
    public class EmpleadoResumenDto
    {
        public String Documento { get; set; }
        public String Nombre { get; set; }
        public String Apellido { get; set; }
        public String Email { get; set; }
        public String Cargo { get; set; }
        public bool Estado { get; set; }
        public String TipoDocumento { get; set; }
    }
}
