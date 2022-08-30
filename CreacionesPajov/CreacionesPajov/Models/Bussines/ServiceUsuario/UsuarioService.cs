using CreacionesPajov.WEB.Models.Abstract.IUsuario;
using CreacionesPajov.WEB.Models.Dtos.Usuarios;
using CreacionesPajov.WEB.Models.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreacionesPajov.WEB.Models.Bussines.ServiceUsuario
{
    public class UsuarioService : IUsuarioService
    {
        private readonly UserManager<Usuario> _userManager;
        private readonly SignInManager<Usuario> _signInManager;

        //usermanager para manejar todo lo que tiene que ver con el crud del usuario
        //SigninManager es para las sesiones.

        public UsuarioService(UserManager<Usuario> userManager, SignInManager<Usuario> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public async Task<IEnumerable<UsuarioResumenDto>> ObtenerListaUsuarios()
        {
            List<UsuarioResumenDto> listaUsuarioResumenDtos = new();
            var usuarios = await _userManager.Users.ToListAsync();
            usuarios.ForEach(usuario =>
            {
                UsuarioResumenDto usuarioResumenDto = new()
                {

                    Id = usuario.Id,
                    Email = usuario.Email,
                    Estado = usuario.Estado ? "Habilitado" : "Deshabilitado",
                    Rol = "Sin rol"
                };
                listaUsuarioResumenDtos.Add(usuarioResumenDto);
            });

            return listaUsuarioResumenDtos;





        }

        public async Task<string> Crear(RegistrarUsuarioDto registrarUsuarioDto)
        {
            if (registrarUsuarioDto == null)
                throw new ArgumentNullException(nameof(registrarUsuarioDto));
            Usuario usuario = new()
            {
                UserName = registrarUsuarioDto.Email,
                Email = registrarUsuarioDto.Email,
                Estado = true,
            };
            var resultado = await _userManager.CreateAsync(usuario, registrarUsuarioDto.Password);

            if (resultado.Errors.Any())
                return "ErrorPassword";
            if (resultado.Succeeded)
                return usuario.Id;
            return null;

        }




        public async Task<UsuarioResumenDto> ObtenerUsuarioDtoPorEmail(string email)
        {
            if (email == null)
                throw new ArgumentNullException(nameof(email));
            var usuario = await _userManager.FindByEmailAsync(email);
            if (usuario != null)
            {
                UsuarioResumenDto usuarioResumenDto = new()
                {
                    Id = usuario.Id,
                    Email = usuario.Email,
                    Estado = usuario.Estado ? "Habilitado" : "Deshabilitado",

                };
                return usuarioResumenDto;
            }
            return null;
        }
        //public async Task<Usuario> ObtenerUsuarioPorId(int? id)
        //{
        //    if (id == null)
        //        throw new ArgumentNullException(nameof(id));

        //    return await _context.Usuarios.FindAsync(id);
        //}


    }
}
