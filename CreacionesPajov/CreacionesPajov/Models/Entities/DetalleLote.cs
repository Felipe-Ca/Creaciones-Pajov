using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CreacionesPajov.WEB.Models.Entities
{
    public partial class DetalleLote
    {
        [Key]
        public int DetalleControlLoteId { get; set; }

        [Required(ErrorMessage = "El control de lote es requerido")]
        [Display(Name = "Control Lote")]
        public int? IdControlLote { get; set; }
        [Required(ErrorMessage = "La ptoducción es requerido")]
        [Display(Name = "Producción")]
        public int? ProduccionId { get; set; }

        public virtual ControlLote? ControLotes { get; set; }
        public virtual Produccion? Producciones { get; set; }
    }
}