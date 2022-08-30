using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CreacionesPajov.WEB.Models.Entities
{
    public class Produccion
    {

        public Produccion()
        {

            DetalleLotes = new HashSet<DetalleLote>();
        }


        public int ProduccionId { get; set; }

        [Required(ErrorMessage = "El Nombre es Obligatorio")]
        [StringLength(50, ErrorMessage = "El {0} debe tener al menos {2} y máximo {1} caracteres", MinimumLength = 3)]
        [Display(Name = "Nombre")]
        public string Nombre { get; set; }

        public int Total { get; set; }

        [Required(ErrorMessage = "La descrición es Obligatoria")]
        [StringLength(200, ErrorMessage = "El {0} debe tener al menos {2} y máximo {1} caracteres", MinimumLength = 3)]
        [Display(Name = "Descripción")]
        public string Descripcion { get; set; }

        public DateTime FechaRegistro { get; set; } = DateTime.Now;

        [Required(ErrorMessage = "La Fecha de salida es Obligatoria")]
        public DateTime FechaSalida { get; set; }

        public bool Estado { get; set; }

        [Required(ErrorMessage = "La fase es requerida")]
        [Display(Name = "Fase")]
        public int? FaseId { get; set; }

        public virtual Fase Fases { get; set; }

        

        public virtual ICollection<DetalleLote> DetalleLotes { get; set; }



    }
}