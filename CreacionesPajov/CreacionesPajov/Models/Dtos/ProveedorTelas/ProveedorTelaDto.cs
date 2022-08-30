using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CreacionesPajov.WEB.Models.Dtos.ProveedorTelas
{
    public class ProveedorTelaDto
    {
        public int ProveedorTelaId { get; set; }

        [Required(ErrorMessage = "El NIT es Obligatorio")]
        [StringLength(12, ErrorMessage = "El {0} debe tener al menos {2} y maximo {1} caracteres", MinimumLength = 5)]
        [Range(999, 999999999999, ErrorMessage = "El NIT es inválido")]
        [Display(Name = "NIT")]
        public int NIT { get; set; }

        [Required(ErrorMessage = "El Nombre es Obligatorio")]
        [StringLength(50, ErrorMessage = "El {0} debe tener al menos {2} y maximo {1} caracteres", MinimumLength = 3)]
        [Display(Name = "Nombre")]
        public String Nombre { get; set; }

        [Required(ErrorMessage = "La Dirección es Obligatoria")]
        [StringLength(50, ErrorMessage = "El {0} debe tener al menos {2} y maximo {1} caracteres", MinimumLength = 6)]
        [Display(Name = "Dirección")]
        public String Direccion { get; set; }

        [Required(ErrorMessage = "El Email es Obligatorio")]
        [Display(Name = "Email")]
        public String Email { get; set; }

        [Required(ErrorMessage = "El Teléfono es Obligatorio")]
        [Range(99999, 999999999999, ErrorMessage = "El Teléfono es inválido")]
        [Display(Name = "Teléfono")]
        public int Telefono { get; set; }
        public bool Estado { get; set; }
    }
}
