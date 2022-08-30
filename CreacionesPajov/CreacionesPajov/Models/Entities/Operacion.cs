using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace CreacionesPajov.WEB.Models.Entities
{
    public class Operacion
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

        public string SAM { get; set; }

        public bool Estado { get; set; }

        public virtual List<SubFase> SubFases { get; set; }

        public virtual TipoOperacion TiposOperacion { get; set; }
        [Required(ErrorMessage = "El tipo operación es requerido")]
        [Display(Name = "Tipo Operación")]
        public int? TipoOperacionId { get; set; }

        ////Propiedad de navegación
        //public virtual TipoDocumento TiposDocumento { get; set; }
        //public int? TipoDocumentoId { get; set; }



    }
}