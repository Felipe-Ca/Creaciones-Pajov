using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CreacionesPajov.WEB.Models.Entities
{
    public class ReporteProduccion
    {
        public int ReporteProduccionId { get; set; }

        public DateTime FechaRegistro { get; set; } = DateTime.Now;

        [Required(ErrorMessage = "La descripión es Obligatoria")]
        [StringLength(200, ErrorMessage = "El {0} debe tener al menos {2} y máximo {1} caracteres", MinimumLength = 3)]
        [Display(Name = "Descripción")]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "El tipo de Reporte es requerido")]
        [Display(Name = "Tipo Reporte")]
        public int? TipoReporteProduccion { get; set; }

        public virtual TipoReporteProduccion TiposReportesProduccion { get; set; }




    }
}