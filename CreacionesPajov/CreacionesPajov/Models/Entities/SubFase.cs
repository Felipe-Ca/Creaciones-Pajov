using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CreacionesPajov.WEB.Models.Entities
{
    public class SubFase
    {
        public int SubFaseId { get; set; }

        [Required(ErrorMessage = "El nombre es Obligatorio")]
        [StringLength(50, ErrorMessage = "El {0} debe tener al menos {2} y maximo {1} caracteres", MinimumLength = 4)]
        [Display(Name = "Nombre")]
        public String Nombre { get; set; }
        [Required(ErrorMessage = "La descripción es Obligatoria")]
        [StringLength(50, ErrorMessage = "El {0} debe tener al menos {2} y maximo {1} caracteres", MinimumLength = 4)]
        [Display(Name = "Descripción")]
        public String Descripcion { get; set; }

        public virtual Operacion Operaciones { get; set; }
        [Required(ErrorMessage = "La operación es requerido")]
        [Display(Name = "Operación")]
        public int? OperacionId { get; set; }

        public virtual Fase Fases { get; set; }
        [Required(ErrorMessage = "La fase es requerido")]
        [Display(Name = "Fase")]
        public int? FaseId { get; set; }

        public bool Estado { get; set; }
    }
}