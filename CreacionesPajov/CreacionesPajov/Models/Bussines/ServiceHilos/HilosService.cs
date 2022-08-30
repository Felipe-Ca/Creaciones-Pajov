using CreacionesPajov.WEB.Models.Abstract.IHilos;
using CreacionesPajov.WEB.Models.DAL;
using CreacionesPajov.WEB.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreacionesPajov.WEB.Models.Bussines.ServiceHilos
{
    public class HilosService : IHilosService
    {

        public readonly AppDbContext _context;

        public HilosService(AppDbContext context)
        {
            _context = context;
        }

        public void Crear(Hilo hilo)
        {
            if (hilo == null)
                throw new ArgumentNullException(nameof(hilo));

            _context.Add(hilo);
        }
        public void Editar(Hilo hilo)
        {
            if (hilo == null)
                throw new ArgumentNullException(nameof(hilo));
            _context.Update(hilo);
        }
        public async Task<bool> GuardarCambios()
        {
            return await _context.SaveChangesAsync() > 0;
        }
        public async Task<Hilo> ObtenerHiloPorId(int? id)
        {
            if (id == null)
                throw new ArgumentNullException(nameof(id));

            return await _context.Hilos.Include(x => x.ProveedoresHilo).FirstOrDefaultAsync(x => x.HiloId == id);
        }
        public async Task<IEnumerable<Hilo>> ObtenerHilo()
        {
            return await _context.Hilos.Include(x => x.ProveedoresHilo).ToListAsync(); 
        }
        

    }
}
