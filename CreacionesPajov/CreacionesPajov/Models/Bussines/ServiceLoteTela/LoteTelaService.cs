using CreacionesPajov.WEB.Models.Abstract.ILoteTela;
using CreacionesPajov.WEB.Models.DAL;
using CreacionesPajov.WEB.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreacionesPajov.WEB.Models.Bussines
{
    public class LoteTelaService : ILoteTelaService
    {
        private readonly AppDbContext _context;
        public LoteTelaService(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<ControlLote>> ObtenerLote()
        {
            return await _context.ControlLotes.ToListAsync();
        }

        public async Task<IEnumerable<DetalleTela>> ListarTelas(int id)
        {
            return await _context.DetalleTelas.Where(x => x.ControlLoteId == id).Include(x => x.Tela).ToListAsync();
        }
    }
}
