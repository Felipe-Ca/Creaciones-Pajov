using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CreacionesPajov.WEB.Models.Dtos.TipoPrendas
{
    public class TipoPrendaDto
    {
        public int TipoPrendaId { get; set; }

        [Required(ErrorMessage = "El nombre es Obligatorio")]
        [StringLength(50, ErrorMessage = "El {0} debe tener al menos {2} y maximo {1} caracteres", MinimumLength = 4)]
        [Display(Name = "Nombre")]
        public string Nombre { get; set; }

        
    }
}
