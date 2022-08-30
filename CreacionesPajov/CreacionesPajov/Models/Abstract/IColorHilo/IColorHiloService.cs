using CreacionesPajov.WEB.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreacionesPajov.WEB.Models.Abstract.IColorHilo
{
    public interface IColorHiloService
    {
        Task<IEnumerable<ColorHilo>> ObtenerColorHilos();
        void Crear(ColorHilo colorhilo);
        Task<bool> GaurdarCambios();

        Task<ColorHilo> ObtenerColorHiloPorId(int? id);

        void Editar(ColorHilo colorhilo);
    }
}
