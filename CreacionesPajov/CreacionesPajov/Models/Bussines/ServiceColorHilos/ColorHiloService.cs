using CreacionesPajov.WEB.Models.Abstract.IColorHilo;
using CreacionesPajov.WEB.Models.DAL;
using CreacionesPajov.WEB.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreacionesPajov.WEB.Models.Bussines.ServiceColorHilos
{
    public class ColorHiloService : IColorHiloService
    {
        private readonly AppDbContext _context;

        public ColorHiloService(AppDbContext context)
        {
            _context = context;
        }

        public void Crear(ColorHilo colorhilo)
        {
            if (colorhilo == null)
                throw new ArgumentNullException(nameof(colorhilo));

            colorhilo.Estado = true;
            _context.Add(colorhilo);
        }

        public void Editar(ColorHilo colorhilo)
        {
            if (colorhilo == null)
                throw new ArgumentNullException(nameof(colorhilo));
            _context.Update(colorhilo);
        }

        public async Task<bool> GaurdarCambios()
        {
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<ColorHilo> ObtenerColorHiloPorId(int? id)
        {
            if (id == null)
                throw new ArgumentNullException(nameof(id));

            return await _context.ColorHilos.FindAsync(id);
        }

        public async Task<IEnumerable<ColorHilo>> ObtenerColorHilos()
        {
            return await _context.ColorHilos.ToListAsync();
        }
    }
}
