using CreacionesPajov.WEB.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreacionesPajov.WEB.Models.Abstract.ITelas
{
   public interface ITelasService
   {
        void Crear(Tela tela);
        void Editar(Tela tela);

        Task<bool> GuardarCambios();

        Task<Tela> ObtenerTelaPorId(int? id);

        Task<IEnumerable<Tela>> ObtenerTela();

    }
}
