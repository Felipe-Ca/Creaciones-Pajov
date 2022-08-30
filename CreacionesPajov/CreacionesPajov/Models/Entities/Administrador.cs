using Microsoft.AspNetCore.Identity;

namespace CreacionesPajov.WEB.Models.Entities
{
    public class Administrador: IdentityUser
    {
        public bool Estado { get; set; }
    }
}
