using CreacionesPajov.WEB.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreacionesPajov.WEB.Models.Abstract
{
    public interface IFaseService
    {
        Task<IEnumerable<Fase>> ObtenerFases();
        void Crear(Fase fase);
        Task<bool> GaurdarCambios();

        Task<Fase> ObtenerfasePorId(int? id);

        void Editar(Fase fase);
    }
}
