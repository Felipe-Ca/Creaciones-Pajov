using CreacionesPajov.WEB.Controllers;
using CreacionesPajov.WEB.Models.Abstract.ITipoNovedadEmpleado;
using CreacionesPajov.WEB.Models.DAL;
using CreacionesPajov.WEB.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreacionesPajov.WEB.Models.Bussines.ServiceTipoNovedadEmpleados
{
    public class TipoNovedadEmpleadoService : ITipoNovedadEmpleadoService
    {
        private readonly AppDbContext _context;

        public TipoNovedadEmpleadoService(AppDbContext context)
        {
            _context = context;
        }
        public void Crear(TipoNovedadEmpleado tiponovedadempleados)
        {
            if (tiponovedadempleados == null)
                throw new ArgumentNullException(nameof(tiponovedadempleados));

           
            _context.Add(tiponovedadempleados);
        }

        public void Editar(TipoNovedadEmpleado tiponovedadempleados)
        { 

            if (tiponovedadempleados == null)
                throw new ArgumentNullException(nameof(tiponovedadempleados));
            _context.Update(tiponovedadempleados);
        }

        public async Task<bool> GaurdarCambios()
        {
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<TipoNovedadEmpleado> ObtenerTipoNovedadEmpleadoPorId(int? id)
        {
            if (id == null)
                throw new ArgumentNullException(nameof(id));

            return await _context.TipoNovedadEmpleados.Include(x => x.Empleados).FirstOrDefaultAsync(x => x.TipoNovedadEmpleadoId == id);
        }

        public async Task<IEnumerable<TipoNovedadEmpleado>> ObtenerTipoNovedadEmpleados()
        {
            return await _context.TipoNovedadEmpleados.Include(x => x.Empleados).ToListAsync();
        }
    }
}
