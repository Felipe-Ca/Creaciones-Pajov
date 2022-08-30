using CreacionesPajov.WEB.Models.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CreacionesPajov.WEB.Models.Dtos.SubFases
{
    public class SubFaseDto
    {
        public int SubFaseId { get; set; }

        [Required(ErrorMessage = "El Nombre es Obligatorio")]
        [StringLength(50, ErrorMessage = "El {0} debe tener al menos {2} y maximo {1} caracteres", MinimumLength = 4)]
        [Display(Name = "Nombre")]
        public String Nombre { get; set; }

        [Required(ErrorMessage = "La Descripción es Obligatoria")]
        [StringLength(50, ErrorMessage = "El {0} debe tener al menos {2} y maximo {1} caracteres", MinimumLength = 4)]
        [Display(Name = "Descripción")]
        public String Descripcion { get; set; }

        [Required(ErrorMessage = "La operación es requerida")]
        [Display(Name = "Operación")]
        public int? OperacionId { get; set; }


        [Required(ErrorMessage = "La Fase es requerida")]
        [Display(Name = "Fase")]
        public int? FaseId { get; set; }

        public bool Estado { get; set; }
    }
}
