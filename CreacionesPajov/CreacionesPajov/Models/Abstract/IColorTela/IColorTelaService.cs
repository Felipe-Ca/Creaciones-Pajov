using CreacionesPajov.WEB.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreacionesPajov.WEB.Models.Abstract.IColorTela
{
    public interface IColorTelaService
    {
        Task<IEnumerable<ColorTela>> ObtenerColorTelas();
        void Crear(ColorTela colortela);
        Task<bool> GaurdarCambios();

        Task<ColorTela> ObtenerColorTelaPorId(int? id);

        void Editar(ColorTela colortela);
    }
}
