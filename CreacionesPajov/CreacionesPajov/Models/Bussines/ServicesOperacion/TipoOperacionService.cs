using CreacionesPajov.WEB.Models.Abstract.IOperacion;
using CreacionesPajov.WEB.Models.DAL;
using CreacionesPajov.WEB.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreacionesPajov.WEB.Models.Bussines.ServicesOperacion
{
    public class TipoOperacionService : ITipoOperacionService
    {
        private readonly AppDbContext _context;

        public TipoOperacionService(AppDbContext context)
        {
            _context = context;
            _context = context;

        }
        public async Task<IEnumerable<TipoOperacion>> ObtenerTiposOperacion()
        {
            return await _context.TiposOperacion.ToListAsync();

        }

    }
}
