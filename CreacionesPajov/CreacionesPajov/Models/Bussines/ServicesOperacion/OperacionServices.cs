using CreacionesPajov.WEB.Models.Abstract.IOperacion;
using CreacionesPajov.WEB.Models.DAL;
using CreacionesPajov.WEB.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreacionesPajov.WEB.Models.Bussines.ServicesOperacion
{

    public class OperacionServices : IOperacionService
    {
        //Objeto privado de solo lectura
        private readonly AppDbContext _context;

        public OperacionServices(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Operacion>> ObtenerOperaciones()
        {

            return await _context.Operaciones.Include(x => x.TiposOperacion).ToListAsync();


        }


        public void Crear(Operacion operacion)
        {
            if (operacion == null)
                throw new ArgumentNullException(nameof(operacion));

            operacion.Estado = true;
            _context.Add(operacion);


        }

        public async Task<Operacion> ObteneroperacionPorId(int? id)
        {
            if (id == null)
                throw new ArgumentNullException(nameof(id));

            return await _context.Operaciones.Include(x => x.TiposOperacion).FirstOrDefaultAsync(x => x.OperacionId == id);
        }

        public void Editar(Operacion operacion)
        {
            if (operacion == null)
                throw new ArgumentNullException(nameof(operacion));
            _context.Update(operacion);


        }


        public async Task<bool> GaurdarCambios()
        {
            return await _context.SaveChangesAsync() > 0; // Si  el resultado es mayor a 0 me devuelve un true (todo esta correcto)
        }

    }

}
