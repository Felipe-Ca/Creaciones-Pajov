using CreacionesPajov.WEB.Models.Abstract;
using CreacionesPajov.WEB.Models.DAL;
using CreacionesPajov.WEB.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreacionesPajov.WEB.Models.Bussines
{
    public class EmpleadoService : IEmpleadoService
    {
        //Objeto privado de solo lectura
        private readonly AppDbContext _context;

        public EmpleadoService(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Empleado>> ObtenerEmpleados()
        {
            return await _context.Empleados.Where(x => x.Estado).Include(x => x.TiposDocumento).ToListAsync();
        }
        //Lista de empleados deshabilitados
        public async Task<IEnumerable<Empleado>> ObtenerEmpleadosDeshabilitados()
        {
            return await _context.Empleados.Where(x => x.Estado==false).Include(x => x.TiposDocumento).ToListAsync();
        }

        public void Crear(Empleado empleado)
        {
            if (empleado == null)
                throw new ArgumentNullException(nameof(empleado));

            empleado.Estado = true;
            _context.Add(empleado);


        }

        public async Task<Empleado> ObtenerEmpleadoPorId(int? id)
        {
            if (id == null)
                throw new ArgumentNullException(nameof(id));


            return await _context.Empleados.Include(x => x.TiposDocumento).FirstOrDefaultAsync(x => x.EmpleadoId == id);
        }

        public void Editar(Empleado empleado)
        {
            if (empleado == null)
                throw new ArgumentNullException(nameof(empleado));
            _context.Update(empleado);


        }


        public async Task<bool> GaurdarCambios()
        {
            return await _context.SaveChangesAsync() > 0; // Si  el resultado es mayor a 0 me devuelve un true (todo esta correcto)
        }




    }
}