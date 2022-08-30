using CreacionesPajov.WEB.Models.Abstract;
using CreacionesPajov.WEB.Models.DAL;
using CreacionesPajov.WEB.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CreacionesPajov.WEB.Models.Bussines
{
    public class TipoDocumentoService : ITipoDocumentoService
    {
        private readonly AppDbContext _context;

        public TipoDocumentoService(AppDbContext context)
        {
            _context = context;
            _context = context;
           
        }
        public async Task<IEnumerable<TipoDocumento>> ObtenerTiposDocumento()
        {
            return await _context.TiposDocumento.ToListAsync();

        }

    }
}
