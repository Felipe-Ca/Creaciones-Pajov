using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreacionesPajov.WEB.Models.Dtos.ProveedorTelas
{
    public class ProveedorTelaDetalleDto
    {
        public int ProveedorTelaId { get; set; }
        public string NIT { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Email { get; set; }
        public int Telefono { get; set; }
        public string Estado { get; set; }
    }
}
