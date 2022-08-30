using CreacionesPajov.WEB.Models.Abstract.ITipoPrendas;
using CreacionesPajov.WEB.Models.DAL;
using CreacionesPajov.WEB.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreacionesPajov.WEB.Models.Bussines.ServiceTipoPrendas
{
    public class TipoPrendaService : ITipoPrendaService
    {
        private readonly AppDbContext _context;

        public TipoPrendaService(AppDbContext context)
        {
            _context = context;
        }
        public void Crear(TipoPrenda tipoprenda)
        {
            if (tipoprenda == null)
                throw new ArgumentNullException(nameof(tipoprenda));

            
            _context.Add(tipoprenda);
        }

        public void Editar(TipoPrenda tipoprenda)
        {
            if (tipoprenda == null)
                throw new ArgumentNullException(nameof(tipoprenda));
            _context.Update(tipoprenda);
        }

        public async Task<bool> GaurdarCambios()
        {
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<IEnumerable<TipoPrenda>> ObtenerTipoPrendas()
        {
            return await _context.TipoPrendas.ToListAsync();
        }

        public async Task<TipoPrenda> ObtenerTipoPrendaPorId(int? id)
        {
            if (id == null)
                throw new ArgumentNullException(nameof(id));

            return await _context.TipoPrendas.FindAsync(id);
        }
    }
}
