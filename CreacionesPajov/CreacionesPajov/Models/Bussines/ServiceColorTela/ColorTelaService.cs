using CreacionesPajov.WEB.Models.Abstract.IColorTela;
using CreacionesPajov.WEB.Models.DAL;
using CreacionesPajov.WEB.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreacionesPajov.WEB.Models.Bussines.ServiceColorTela
{
    public class ColorTelaService : IColorTelaService
    {
        private readonly AppDbContext _context;

        public ColorTelaService(AppDbContext context)
        {
            _context = context;
        }

        public void Crear(ColorTela colortela)
        {
            if (colortela == null)
                throw new ArgumentNullException(nameof(colortela));

            colortela.Estado = true;
            _context.Add(colortela);
        }

        public void Editar(ColorTela colortela)
        {
            if (colortela == null)
                throw new ArgumentNullException(nameof(colortela));
            _context.Update(colortela);
        }

        public async Task<bool> GaurdarCambios()
        {
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<ColorTela> ObtenerColorTelaPorId(int? id)
        {
            if (id == null)
                throw new ArgumentNullException(nameof(id));

            return await _context.ColorTelas.FindAsync(id);
        }

        public async Task<IEnumerable<ColorTela>> ObtenerColorTelas()
        {
            return await _context.ColorTelas.ToListAsync();
        }
    }
}
