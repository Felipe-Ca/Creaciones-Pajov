using CreacionesPajov.WEB.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreacionesPajov.WEB.Models.Abstract.IProveedorHilo
{
    public interface IProveedorHiloService
    {
        Task<IEnumerable<ProveedorHilo>> ObtenerProveedorHilos();
        void Crear(ProveedorHilo proveedorhilo);
        Task<bool> GaurdarCambios();

        Task<ProveedorHilo> ObtenerProveedorHiloPorId(int? id);

        void Editar(ProveedorHilo proveedorhilo);
    }
}
