using CreacionesPajov.WEB.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreacionesPajov.WEB.Models.Abstract.ILoteHilo
{
    public interface ILoteHiloService
    {
        Task<IEnumerable<ControlLote>> ObtenerLote();
       

        Task<IEnumerable<DetalleHilo>> ListarHilos(int id);
    }
}
