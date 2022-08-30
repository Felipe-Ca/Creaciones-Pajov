using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CreacionesPajov.WEB.Models.Entities
{

    public partial class ControlLote
    {
        public ControlLote()
        {
            DetalleHilos = new HashSet<DetalleHilo>();
            DetalleTelas = new HashSet<DetalleTela>();
        }


        [Key]
        public int? IdControlLote { get; set; }

        [Required(ErrorMessage = "La descripión es Obligatoria")]
        [StringLength(200, ErrorMessage = "El {0} debe tener al menos {2} y máximo {1} caracteres", MinimumLength = 3)]
        [Display(Name = "Descripción")]
        public string? Descripcion { get; set; }

        public DateTime FechaRegistro { get; set; } = DateTime.Now;

        public int? Total { get; set; }

        public virtual ICollection<DetalleHilo> DetalleHilos { get; set; }
        public virtual ICollection<DetalleTela> DetalleTelas { get; set; }

        public virtual ICollection<DetalleLote> DetalleLote { get; set; }
    }
}