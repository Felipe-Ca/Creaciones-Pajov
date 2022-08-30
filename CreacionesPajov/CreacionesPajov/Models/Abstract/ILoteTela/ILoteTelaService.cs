using CreacionesPajov.WEB.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreacionesPajov.WEB.Models.Abstract.ILoteTela
{
    public interface ILoteTelaService
    {
        Task<IEnumerable<ControlLote>> ObtenerLote();

        Task<IEnumerable<DetalleTela>> ListarTelas(int id);
    }
}
