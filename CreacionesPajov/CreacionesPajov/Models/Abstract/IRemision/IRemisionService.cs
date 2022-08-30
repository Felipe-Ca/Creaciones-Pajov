using CreacionesPajov.WEB.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreacionesPajov.WEB.Models.Abstract.IRemision
{
    public interface IRemisionService
    {
        Task<IEnumerable<Remision>> ObtenerRemisiones();

        void Crear(Remision remision);
        Task<bool> GaurdarCambios();

        Task<Remision> ObtenerRemisionPorId(int? id);

        void Editar(Remision remision);
    }
}
