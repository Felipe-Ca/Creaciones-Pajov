using CreacionesPajov.WEB.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreacionesPajov.WEB.Models.Abstract.IOperacion
{
    public interface ITipoOperacionService
    {
        Task<IEnumerable<TipoOperacion>> ObtenerTiposOperacion();
    }
}
