using CreacionesPajov.WEB.Models.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CreacionesPajov.WEB.Models.Abstract
{
    public interface IEmpleadoService
    {

        Task<IEnumerable<Empleado>> ObtenerEmpleados();
        Task<IEnumerable<Empleado>> ObtenerEmpleadosDeshabilitados();
        void Crear(Empleado empleado);
        Task<bool> GaurdarCambios();

        Task<Empleado> ObtenerEmpleadoPorId(int? id);

        void Editar(Empleado empleado);
    }

}
