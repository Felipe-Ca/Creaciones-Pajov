using CreacionesPajov.WEB.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreacionesPajov.WEB.Models.Abstract.IProduccion
{
    public interface IProduccionService
    {
        void Crear(Produccion produccion);
        void Editar(Produccion produccion);
        Task<bool> GuardarCambios();
        Task<Produccion> ObtenerProduccionPorId(int? id);
        Task<IEnumerable<Produccion>> ObtenerProduccion();
    }
}
