using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CreacionesPajov.WEB.Models.Entities
{
    public class Empleado

    {
        public int EmpleadoId { get; set; }

        [Required(ErrorMessage = "El documento es Obligatorio")]
        [StringLength(12, ErrorMessage = "El {0} debe tener al menos {2} y maximo {1} caracteres", MinimumLength = 7)]
        [Range(999, 999999999999, ErrorMessage = "El documento es inválido")]
        [Display(Name = "Documento")]
        public string Documento { get; set; }

        [Required(ErrorMessage = "El nombre es Obligatorio")]
        [StringLength(50, ErrorMessage = "El {0} debe tener al menos {2} y maximo {1} caracteres", MinimumLength = 3)]
        [Display(Name = "Nombre")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El apellido es Obligatorio")]
        [StringLength(50, ErrorMessage = "El {0} debe tener al menos {2} y maximo {1} caracteres", MinimumLength = 3)]
        [Display(Name = "Apellido")]
        public string Apellido { get; set; }

        [Required(ErrorMessage = "La edad es Obligatoria")]
        [Range(18, 999999999999, ErrorMessage = "La edad es inválida")]
        [Display(Name = "Edad")]
        public int Edad { get; set; }

        [EmailAddress(ErrorMessage = "El correo es inválido")]
        [Required(ErrorMessage = "El email es Obligatorio")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "El Teléfono es Obligatorio")]
        [Range(18, 999999999999, ErrorMessage = "El teléfono es inválido")]
        [Display(Name = "Teléfono")]
        public int Telefono { get; set; }

        [Required(ErrorMessage = "El cargo es Obligatorio")]
        [Display(Name = "Cargo")]
        public string Cargo { get; set; }

        public DateTime FechaRegistro { get; set; } = DateTime.Now;

        public bool Estado { get; set; }

        [Required(ErrorMessage = "El tipo de documento es requerido")]
        [Display(Name = "Tipo documento")]
        public int? TipoDocumentoId { get; set; }

        public virtual TipoDocumento TiposDocumento { get; set; }
        public virtual List<TipoNovedadEmpleado> TipoNovedadEmpleados { get; set; }
    }
}