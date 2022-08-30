using CreacionesPajov.WEB.Models.Abstract.IProduccion;
using CreacionesPajov.WEB.Models.DAL;
using CreacionesPajov.WEB.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreacionesPajov.WEB.Models.Bussines.ServiceProduccion
{
    public class ProduccionService : IProduccionService
    {
        public readonly AppDbContext _context;

        public ProduccionService(AppDbContext context)
        {
            _context = context;
        }

        public void Crear(Produccion produccion)
        {
            if (produccion == null)
                throw new ArgumentNullException(nameof(produccion));

            produccion.Estado = true;
            _context.Add(produccion);
        }
        public void Editar(Produccion produccion)
        {
            if (produccion == null)
                throw new ArgumentNullException(nameof(produccion));
            _context.Update(produccion);
        }
        public async Task<bool> GuardarCambios()
        {
            return await _context.SaveChangesAsync() > 0;
        }
        public async Task<Produccion> ObtenerProduccionPorId(int? id)
        {
            if (id == null)
                throw new ArgumentNullException(nameof(id));

            return await _context.Producciones.FindAsync(id);
        }
        public async Task<IEnumerable<Produccion>> ObtenerProduccion()
        {
            return await _context.Producciones.ToListAsync();
        }

    }
}
