using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CreacionesPajov.WEB.Models.Entities
{
    public partial class Hilo
    {
        public Hilo()
        {

            DetalleHilos = new HashSet<DetalleHilo>();
        }


        public int HiloId { get; set; }

        [Required(ErrorMessage = "La descripción es Obligatoria")]
        [StringLength(50, ErrorMessage = "El {0} debe tener al menos {2} y maximo {1} caracteres", MinimumLength = 4)]
        [Display(Name = "Descripción")]
        public string Descripcion { get; set; }
        [Required(ErrorMessage = "La cantidad son Obligatorias")]
        [Display(Name = "Cantidad")]
        public int Cantidad { get; set; }
        public DateTime Fecha { get; set; } = DateTime.Now;

        [Required(ErrorMessage = "La medida es Obligatoria")]
        [Display(Name = "Medida")]
        public double Medida { get; set; }

        [Required(ErrorMessage = "El color hilo es requerido")]
        [Display(Name = "Color Hilo")]
        public int? ColorHiloId { get; set; }
        public virtual ColorHilo ColoresHilos { get; set; }

        [Required(ErrorMessage = "El proveedor hilo es requerido")]
        [Display(Name = "Proveedor Hilo")]
        public int? ProveedorHiloId { get; set; }

        public virtual ProveedorHilo ProveedoresHilo { get; set; }
        // public virtual List<ProveedorHilo> ProveedorHilos { get; set; }
        public virtual ICollection<DetalleHilo> DetalleHilos { get; set; }

    }
}