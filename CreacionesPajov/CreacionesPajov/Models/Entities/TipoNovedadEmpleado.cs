using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CreacionesPajov.WEB.Models.Entities
{
    public class TipoNovedadEmpleado
    {
        public int TipoNovedadEmpleadoId { get; set; }

        public virtual Empleado Empleados { get; set; }

        [Required(ErrorMessage = "La fase es requerida")]
        [Display(Name = "Fase")]
        public int? EmpleadoId { get; set; }

        [Required(ErrorMessage = "La descripción es Obligatoria")]
        [StringLength(50, ErrorMessage = "El {0} debe tener al menos {2} y maximo {1} caracteres", MinimumLength = 4)]
        [Display(Name = "Descripción")]
        public String Descripcion { get; set; }


    }
}