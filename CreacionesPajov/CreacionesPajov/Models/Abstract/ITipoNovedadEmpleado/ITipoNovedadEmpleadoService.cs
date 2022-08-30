using CreacionesPajov.WEB.Controllers;
using CreacionesPajov.WEB.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreacionesPajov.WEB.Models.Abstract.ITipoNovedadEmpleado
{
    public interface ITipoNovedadEmpleadoService
    {
        Task<IEnumerable<TipoNovedadEmpleado>> ObtenerTipoNovedadEmpleados();
        Task<bool> GaurdarCambios();

        Task<TipoNovedadEmpleado> ObtenerTipoNovedadEmpleadoPorId(int? id);

        void Editar(TipoNovedadEmpleado tiponovedadempleados);
        void Crear(TipoNovedadEmpleado tiponovedadempleados);
    }
}
