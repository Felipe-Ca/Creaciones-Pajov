using CreacionesPajov.WEB.Models.Abstract;
using CreacionesPajov.WEB.Models.DAL;
using CreacionesPajov.WEB.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreacionesPajov.WEB.Models.Bussines
{



    public class FaseService : IFaseService
    {
        private readonly AppDbContext _context;

        public FaseService(AppDbContext context)
        {
            _context = context;
        }

        public void Crear(Fase fase)
        {
            if (fase == null)
                throw new ArgumentNullException(nameof(fase));

            fase.Estado = true;
            _context.Add(fase);
        }

        public void Editar(Fase fase)
        {
            if (fase == null)
                throw new ArgumentNullException(nameof(fase));
            _context.Update(fase);
        }

        public async Task<bool> GaurdarCambios()
        {
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<Fase> ObtenerfasePorId(int? id)
        {
            if (id == null)
                throw new ArgumentNullException(nameof(id));

            return await _context.Fases.FindAsync(id);
        }

        public async Task<IEnumerable<Fase>> ObtenerFases()
        {
            return await _context.Fases.ToListAsync();
        }
    }
}
