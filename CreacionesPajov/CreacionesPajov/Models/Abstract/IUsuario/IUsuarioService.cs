using CreacionesPajov.WEB.Models.Dtos.Usuarios;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreacionesPajov.WEB.Models.Abstract.IUsuario
{
    public interface IUsuarioService
    {
        Task<UsuarioResumenDto> ObtenerUsuarioDtoPorEmail(string email);
        Task<string> Crear(RegistrarUsuarioDto registrarUsuarioDto);

        Task<IEnumerable<UsuarioResumenDto>> ObtenerListaUsuarios();

     
    }
}
