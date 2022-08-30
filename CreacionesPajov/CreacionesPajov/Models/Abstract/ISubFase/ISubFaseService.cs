using CreacionesPajov.WEB.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreacionesPajov.WEB.Models.Abstract.ISubFase
{
    public interface ISubFaseService
    {
        Task<IEnumerable<SubFase>> ObtenerSubFases();
        void Crear(SubFase subfase);
        Task<bool> GaurdarCambios();

        Task<SubFase> ObtenerSubFasePorId(int? id);

        void Editar(SubFase subfase);
    }
}
