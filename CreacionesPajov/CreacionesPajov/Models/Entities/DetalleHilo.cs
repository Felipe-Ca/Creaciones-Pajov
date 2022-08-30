using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CreacionesPajov.WEB.Models.Entities
{
    public partial class DetalleHilo
    {
        [Key]
        public int DetalleHiloId { get; set; }
        [Required(ErrorMessage = "El hilo es requerido")]
        [Display(Name = "Hilo")]
        public int? HiloId { get; set; }
        [Required(ErrorMessage = "El control de lote es requerido")]
        [Display(Name = "Control Lote")]
        public int? ControlLoteId { get; set; }

        public virtual ControlLote? ControLote { get; set; }
        public virtual Hilo? Hilo { get; set; }
    }
}