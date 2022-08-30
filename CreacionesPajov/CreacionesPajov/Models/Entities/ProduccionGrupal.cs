using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CreacionesPajov.WEB.Models.Entities
{
    public class ProduccionGrupal
    {
        //public ProduccionGrupal()
        //{

        //    DetalleLotes = new HashSet<DetalleLote>();
        //}

        public int ProduccionGrupalId { get; set; }

        public DateTime FechaRegistro { get; set; } = DateTime.Now;

        [Required(ErrorMessage = "La meta del día es Obligatoria")]
        [Range(99999, 999999999999, ErrorMessage = "La meta del día es inválida")]
        [Display(Name = "Meta del día")]
        public int MetaDia { get; set; }

        [Required(ErrorMessage = "La producción real es Obligatoria")]
        [Range(99999, 999999999999, ErrorMessage = "La producción grupal es inválida")]
        [Display(Name = "Producción Grupal")]
        public int ProduccionReal { get; set; }

        

        [Required(ErrorMessage = "La producción es requerida")]
        [Display(Name = "Producción")]
        public int? ProduccionId { get; set; }

        [Required(ErrorMessage = "El tipo de jornada es requerida")]
        [Display(Name = "El tipo de jornada")]
        public int? TipoJornadaId { get; set; }

        public virtual Produccion Producciones { get; set; }

        public virtual TipoJornada TiposJornadas { get; set; }




    }
}
