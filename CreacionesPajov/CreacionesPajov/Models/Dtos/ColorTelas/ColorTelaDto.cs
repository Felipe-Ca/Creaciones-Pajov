using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CreacionesPajov.WEB.Models.Dtos.ColorTelas
{
    public class ColorTelaDto
    {
        public int ColorTelaId { get; set; }

        [Required(ErrorMessage = "El nombre es Obligatorio")]
        [StringLength(50, ErrorMessage = "El {0} debe tener al menos {2} y maximo {1} caracteres", MinimumLength = 4)]
        [Display(Name = "Nombre")]
        public String Nombre { get; set; }

        public bool Estado { get; set; }
    }
}
