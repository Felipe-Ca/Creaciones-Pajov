using CreacionesPajov.WEB.Models.Abstract.IProveedorTela;
using CreacionesPajov.WEB.Models.DAL;
using CreacionesPajov.WEB.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreacionesPajov.WEB.Models.Bussines.ServiceProveedorTela
{
    public class ProveedorTelaService : IProveedorTelaService
    {
        private readonly AppDbContext _context;

        public ProveedorTelaService(AppDbContext context)
        {
            _context = context;
        }
        public void Crear(ProveedorTela proveedortela)
        {
            if (proveedortela == null)
                throw new ArgumentNullException(nameof(proveedortela));

            proveedortela.Estado = true;
            _context.Add(proveedortela);
        }

        public void Editar(ProveedorTela proveedortela)
        {
            if (proveedortela == null)
                throw new ArgumentNullException(nameof(proveedortela));
            _context.Update(proveedortela);
        }

        public async Task<bool> GaurdarCambios()
        {
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<ProveedorTela> ObtenerProveedorTelaPorId(int? id)
        {
            if (id == null)
                throw new ArgumentNullException(nameof(id));


            return await _context.ProveedorTelas.FindAsync(id);
        }

        public async Task<IEnumerable<ProveedorTela>> ObtenerProveedorTelas()
        {
            return await _context.ProveedorTelas.ToListAsync();
        }
    }
}
