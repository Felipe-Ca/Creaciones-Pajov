using CreacionesPajov.WEB.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreacionesPajov.WEB.Models.Abstract.ITipoPrendas
{
    public interface ITipoPrendaService
    {
        Task<IEnumerable<TipoPrenda>> ObtenerTipoPrendas();
        void Crear(TipoPrenda tipoprenda);
        Task<bool> GaurdarCambios();

        Task<TipoPrenda> ObtenerTipoPrendaPorId(int? id);

        void Editar(TipoPrenda tipoprenda);
    }
}
