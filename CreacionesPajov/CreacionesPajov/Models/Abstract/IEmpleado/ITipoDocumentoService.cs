using CreacionesPajov.WEB.Models.Bussines;
using CreacionesPajov.WEB.Models.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CreacionesPajov.WEB.Models.Abstract
{
    public interface ITipoDocumentoService 
    {
        Task<IEnumerable<TipoDocumento>> ObtenerTiposDocumento();
    }
}
