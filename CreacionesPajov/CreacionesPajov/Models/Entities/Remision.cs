using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CreacionesPajov.WEB.Models.Entities
{
    public class Remision
    {

        public int RemisionId { get; set; }

        [Required(ErrorMessage = "La cantidad de prendas son Obligatorias")]
        [Display(Name = "Cantidad Prendas")]
        public int CantidadPrendas { get; set; }

        [Required(ErrorMessage = "La Dirección es Obligatoria")]
        [StringLength(50, ErrorMessage = "El {0} debe tener al menos {2} y maximo {1} caracteres", MinimumLength = 8)]
        [Display(Name = "Dirección")]
        public String Direccion { get; set; }

        [Required(ErrorMessage = "El encargado es Obligatorio")]
        [StringLength(50, ErrorMessage = "El {0} debe tener al menos {2} y maximo {1} caracteres", MinimumLength = 4)]
        [Display(Name = "Encargado")]
        public String Encargado { get; set; }

        public DateTime FechaLlegada { get; set; } = DateTime.Now;

        [Required(ErrorMessage = "La Fecha es Obligatoria")]
        [DataType(DataType.Date)]
        [Display(Name = "Fecha salida")]
        public DateTime? FechaSalida { get; set; }

        [Required(ErrorMessage = "La Observación es Obligatoria")]
        [StringLength(50, ErrorMessage = "El {0} debe tener al menos {2} y maximo {1} caracteres", MinimumLength = 8)]
        [Display(Name = "Observación")]
        public String Observacion { get; set; }

        public bool Estado { get; set; }

        [Required(ErrorMessage = "La fase es requerida")]
        [Display(Name = "Fase")]
        public int? FaseId { get; set; }
        public virtual Fase Fases { get; set; }

    }
}