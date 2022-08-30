using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CreacionesPajov.WEB.Models.Entities
{
    public class Tela
    {
        public Tela()
        {

            DetalleTelas = new HashSet<DetalleTela>();
        }



        public int TelaId { get; set; }

        public int Cantidad { get; set; }

        [Required(ErrorMessage = "La descripción es Obligatoria")]
        [StringLength(50, ErrorMessage = "El {0} debe tener al menos {2} y maximo {1} caracteres", MinimumLength = 4)]
        [Display(Name = "Descripción")]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "La empresa de empaque es Obligatorio")]
        [StringLength(50, ErrorMessage = "El {0} debe tener al menos {2} y maximo {1} caracteres", MinimumLength = 4)]
        [Display(Name = "Empresa Empaque")]
        public string EmpresaEmpaque { get; set; }

        [Required(ErrorMessage = "La empresa de revision es Obligatorio")]
        [StringLength(50, ErrorMessage = "El {0} debe tener al menos {2} y maximo {1} caracteres", MinimumLength = 4)]
        [Display(Name = "Empresa Revision")]
        public string EmpresaRevision { get; set; }

        public DateTime FechaRegistro { get; set; } = DateTime.Now;

        [Required(ErrorMessage = "La observación es Obligatoria")]
        [StringLength(50, ErrorMessage = "El {0} debe tener al menos {2} y maximo {1} caracteres", MinimumLength = 4)]
        [Display(Name = "Observación")]
        public string Observaciones { get; set; }

        [Required(ErrorMessage = "La Referencia es Obligatoria")]
        [StringLength(50, ErrorMessage = "El {0} debe tener al menos {2} y maximo {1} caracteres", MinimumLength = 4)]
        [Display(Name = "Referencia")]
        public string Referencia { get; set; }

        [Required(ErrorMessage = "El tejido es Obligatorio")]
        [StringLength(50, ErrorMessage = "El {0} debe tener al menos {2} y maximo {1} caracteres", MinimumLength = 4)]
        [Display(Name = "Tejido")]
        public string Tejido { get; set; }

        [Required(ErrorMessage = "El proveedor de tela es requerido")]
        [Display(Name = "Proveedor Tela")]
        public int? ProveedorTelaId { get; set; }

        [Required(ErrorMessage = "El color tela es requerido")]
        [Display(Name = "Color tela ")]
        public int? ColorTelaId { get; set; }

        public virtual ColorTela ColorTelas { get; set; }
        public virtual ProveedorTela ProveedorTelas { get; set; }
        public virtual ICollection<DetalleTela> DetalleTelas { get; set; }







    }
}