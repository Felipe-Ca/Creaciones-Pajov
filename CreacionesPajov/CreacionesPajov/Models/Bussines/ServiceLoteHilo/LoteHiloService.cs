using CreacionesPajov.WEB.Models.Abstract.ILoteHilo;
using CreacionesPajov.WEB.Models.DAL;
using CreacionesPajov.WEB.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreacionesPajov.WEB.Models.Bussines.ServiceLoteHilo
{
    public class LoteHiloService : ILoteHiloService
    {
        private readonly AppDbContext _context;

        public LoteHiloService(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<ControlLote>> ObtenerLote()
        {
            return await _context.ControlLotes.ToListAsync();
        }
       

        public async Task<IEnumerable<DetalleHilo>> ListarHilos(int id)
        {
            return await _context.DetalleHilos.Where(x => x.ControlLoteId == id).Include(x => x.Hilo).ToListAsync();
        }

    }
}
