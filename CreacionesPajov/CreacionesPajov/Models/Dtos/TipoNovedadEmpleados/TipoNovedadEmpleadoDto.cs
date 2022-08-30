using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CreacionesPajov.WEB.Models.Dtos.TipoNovedadEmpleados
{
    public class TipoNovedadEmpleadoDto
    {
        public int TipoNovedadEmpleadoId { get; set; }


        [Required(ErrorMessage = "El empleado es requerido")]
        [Display(Name = "Empleado")]
        public int? EmpleadoId { get; set; }

        [Required(ErrorMessage = "La Descripción es Obligatoria")]
        [StringLength(50, ErrorMessage = "El {0} debe tener al menos {2} y maximo {1} caracteres", MinimumLength = 4)]
        [Display(Name = "Descripción")]
        public String Descripcion { get; set; }

       
    }
}
