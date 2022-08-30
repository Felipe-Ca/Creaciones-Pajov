using CreacionesPajov.WEB.Models.Abstract.ITelas;
using CreacionesPajov.WEB.Models.DAL;
using CreacionesPajov.WEB.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreacionesPajov.WEB.Models.Bussines.ServicesTelas
{
    public class TelasService : ITelasService
    {
        
   
            public readonly AppDbContext _context;

            public TelasService(AppDbContext context)
            {
                _context = context;
            }

            public void Crear(Tela tela)
            {
                if (tela == null)
                    throw new ArgumentNullException(nameof(tela));

                _context.Add(tela);
            }
            public void Editar(Tela tela)
            {
                if (tela == null)
                    throw new ArgumentNullException(nameof(tela));
                _context.Update(tela);
            }
            public async Task<bool> GuardarCambios()
            {
                return await _context.SaveChangesAsync() > 0;
            }
            public async Task<Tela> ObtenerTelaPorId(int? id)
            {
                if (id == null)
                    throw new ArgumentNullException(nameof(id));

                return await _context.Telas.Include(x => x.ProveedorTelas).FirstOrDefaultAsync(x => x.TelaId == id);
            }
            public async Task<IEnumerable<Tela>> ObtenerTela()
            {
                return await _context.Telas.ToListAsync(); 
            }

        }
    }
