using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreacionesPajov.WEB.Models.Dtos.Usuarios
{
    public class UsuarioResumenDto
    {
        public string Id { get; set; }
        public string Email { get; set; }
        public string Estado { get; set; }
        public string Rol { get; set; }
    }
}
