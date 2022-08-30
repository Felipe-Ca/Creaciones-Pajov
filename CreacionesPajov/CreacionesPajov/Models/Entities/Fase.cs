using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CreacionesPajov.WEB.Models.Entities
{
    public class Fase
    {
        public int FaseId { get; set; }

        [Required(ErrorMessage = "El Nombre es Obligatorio")]
        [StringLength(50, ErrorMessage = "El {0} debe tener al menos {2} y maximo {1} caracteres", MinimumLength = 4)]
        [Display(Name = "Nombre")]
        public String Nombre { get; set; }

        [Required(ErrorMessage = "La descripción es Obligatoria")]
        [StringLength(50, ErrorMessage = "El {0} debe tener al menos {2} y maximo {1} caracteres", MinimumLength = 4)]
        [Display(Name = "Descripción")]
        public String Descripcion { get; set; }

        public bool Estado { get; set; }

        public virtual List<SubFase> SubFases { get; set; }

        public virtual List<Remision> Remisiones { get; set; }

        public virtual List<Produccion> producciones { get; set; }

    }
}