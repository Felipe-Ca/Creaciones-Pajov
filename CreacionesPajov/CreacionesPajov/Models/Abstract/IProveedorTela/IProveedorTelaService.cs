using CreacionesPajov.WEB.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreacionesPajov.WEB.Models.Abstract.IProveedorTela
{
    public interface IProveedorTelaService
    {
        Task<IEnumerable<ProveedorTela>> ObtenerProveedorTelas();
        void Crear(ProveedorTela proveedortela);
        Task<bool> GaurdarCambios();

        Task<ProveedorTela> ObtenerProveedorTelaPorId(int? id);

        void Editar(ProveedorTela proveedortela);
    }
}
