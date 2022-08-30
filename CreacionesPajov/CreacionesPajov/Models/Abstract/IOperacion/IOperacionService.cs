using CreacionesPajov.WEB.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreacionesPajov.WEB.Models.Abstract.IOperacion
{
    public interface IOperacionService
    {
        Task<IEnumerable<Operacion>> ObtenerOperaciones();
        void Crear(Operacion operacion);
        Task<bool> GaurdarCambios();

        Task<Operacion> ObteneroperacionPorId(int? id);

        void Editar(Operacion operacion);
    }
}
