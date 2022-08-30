using CreacionesPajov.WEB.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreacionesPajov.WEB.Models.Abstract.IHilos
{
    public interface IHilosService
    {
        void Crear(Hilo hilo);
        void Editar(Hilo hilo);
        Task<bool> GuardarCambios();
        Task<Hilo> ObtenerHiloPorId(int? id);

        Task<IEnumerable<Hilo>> ObtenerHilo();

    }
}
