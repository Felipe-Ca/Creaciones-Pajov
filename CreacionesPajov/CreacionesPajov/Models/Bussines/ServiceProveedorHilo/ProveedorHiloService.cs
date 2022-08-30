using CreacionesPajov.WEB.Models.Abstract.IProveedorHilo;
using CreacionesPajov.WEB.Models.DAL;
using CreacionesPajov.WEB.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreacionesPajov.WEB.Models.Bussines.ServiceProveedorHilo
{
    public class ProveedorHiloService : IProveedorHiloService
    {
        private readonly AppDbContext _context;

        public ProveedorHiloService(AppDbContext context)
        {
            _context = context;
        }
        public void Crear(ProveedorHilo proveedorhilo)
        {
            if (proveedorhilo == null)
                throw new ArgumentNullException(nameof(proveedorhilo));

            proveedorhilo.Estado = true;
            _context.Add(proveedorhilo);
        }

        public void Editar(ProveedorHilo proveedorhilo)
        {
            if (proveedorhilo == null)
                throw new ArgumentNullException(nameof(proveedorhilo));
            _context.Update(proveedorhilo);
        }

        public async Task<bool> GaurdarCambios()
        {
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<ProveedorHilo> ObtenerProveedorHiloPorId(int? id)
        {
            if (id == null)
                throw new ArgumentNullException(nameof(id));


            return await _context.ProveedorHilos.FindAsync(id);
        }

        public async Task<IEnumerable<ProveedorHilo>> ObtenerProveedorHilos()
        {
            return await _context.ProveedorHilos.ToListAsync();
        }
        
    }
}
