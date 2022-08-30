using CreacionesPajov.WEB.Models.Abstract.IRemision;
using CreacionesPajov.WEB.Models.DAL;
using CreacionesPajov.WEB.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreacionesPajov.WEB.Models.Bussines.ServiceRemision
{
    public class RemisionService : IRemisionService
    {
        private readonly AppDbContext _context;

        public RemisionService(AppDbContext context)
        {
            _context = context;
        }

        public void Crear(Remision remision)
        {
            if (remision == null)
                throw new ArgumentNullException(nameof(remision));

            remision.Estado = true;
            _context.Add(remision);

        }

        public void Editar(Remision remision)
        {
            if (remision == null)
                throw new ArgumentNullException(nameof(remision));
            _context.Update(remision);
        }

        public async Task<bool> GaurdarCambios()
        {
            return await _context.SaveChangesAsync() > 0; // Si  el resultado es mayor a 0 me devuelve un true (todo esta correcto)
        }

        public async Task<IEnumerable<Remision>> ObtenerRemisiones()
        {
            return await _context.Remisiones.Include(x => x.Fases).ToListAsync();
        }

        public async Task<Remision> ObtenerRemisionPorId(int? id)
        {
            return await _context.Remisiones.Include(x => x.Fases).FirstOrDefaultAsync(x => x.RemisionId == id);
        }
    }
}
