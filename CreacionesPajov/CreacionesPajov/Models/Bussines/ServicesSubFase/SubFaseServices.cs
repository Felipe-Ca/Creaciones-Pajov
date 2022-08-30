using CreacionesPajov.WEB.Models.Abstract.ISubFase;
using CreacionesPajov.WEB.Models.DAL;
using CreacionesPajov.WEB.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreacionesPajov.WEB.Models.Bussines.ServicesSubFase
{
    public class SubFaseServices : ISubFaseService
    {
        //Objeto privado de solo lectura
        private readonly AppDbContext _context;

        public SubFaseServices(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<SubFase>> ObtenerSubFases()
        {
            return await(_context.SubFases.Include(x => x.Operaciones).Include(y => y.Fases)).ToListAsync();

        }

        public void Crear(SubFase subfase)
        {
            if (subfase == null)
                throw new ArgumentNullException(nameof(subfase));

            subfase.Estado = true;
            _context.Add(subfase);


        }

        public void Editar(SubFase subfase)
        {
            if (subfase == null)
                throw new ArgumentNullException(nameof(subfase));
            _context.Update(subfase);


        }


        public async Task<bool> GaurdarCambios()
        {
            return await _context.SaveChangesAsync() > 0; // Si  el resultado es mayor a 0 me devuelve un true (todo esta correcto)
        }

        public async Task<SubFase> ObtenerSubFasePorId(int? id)
        {
            if (id == null)
                throw new ArgumentNullException(nameof(id));

            return await (_context.SubFases.Include(x => x.Operaciones).Include(x => x.Fases)).FirstOrDefaultAsync(x => x.SubFaseId == id);
        }
    }
}
