using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CreacionesPajov.WEB.Models.Entities
{
    public class DetalleTela
    {
        [Key]
        public int DetalleTelaId { get; set; }

        [Required(ErrorMessage = "La tela es requerida")]
        [Display(Name = "Tela")]
        public int? TelaId { get; set; }

        [Required(ErrorMessage = "El control delote es requerido")]
        [Display(Name = "Control Lote")]
        public int? ControlLoteId { get; set; }

        public virtual ControlLote? ControLote { get; set; }
        public virtual Tela? Tela { get; set; }
    }
}