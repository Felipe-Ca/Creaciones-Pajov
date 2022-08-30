using System;

namespace CreacionesPajov.WEB.Models.Dtos.Empleados
{
    public class EmpleadoDetalleDto
    {
        public int EmpleadoId { get; set; }
        public string Documento { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
        public string Email { get; set; }
        public int Telefono { get; set; }        
        public string Cargo { get; set; }
        public DateTime FechaRegistro { get; set; } = DateTime.Now;
        public string Estado { get; set; }
        public string TipoDocumento { get; set; }
    }
}
