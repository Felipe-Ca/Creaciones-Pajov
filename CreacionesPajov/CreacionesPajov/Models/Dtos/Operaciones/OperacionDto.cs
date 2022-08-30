using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CreacionesPajov.WEB.Models.Dtos.Operaciones
{
    public class OperacionDto
    {
        public int OperacionId { get; set; }


        [Required(ErrorMessage = "El nombre es Obligatorio")]
        [StringLength(50, ErrorMessage = "El {0} debe tener al menos {2} y maximo {1} caracteres", MinimumLength = 4)]
        [Display(Name = "Nombre")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "La descripción es Obligatoria")]
        [StringLength(50, ErrorMessage = "El {0} debe tener al menos {2} y maximo {1} caracteres", MinimumLength = 4)]
        [Display(Name = "Descripción")]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "El SAM es Obligatorio")]
        [Display(Name = "SAM")]
        public double SAM { get; set; }
        public bool Estado { get; set; }

        //Propiedad de navegación

        [Required(ErrorMessage = "El tipo de operación es requerido")]
        [Display(Name = "Tipo Operación")]
        public int? TipoOperacionId { get; set; }
    }
}
