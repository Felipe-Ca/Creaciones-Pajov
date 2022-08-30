using CreacionesPajov.WEB.Helpers;
using CreacionesPajov.WEB.Models.Abstract.IUsuario;
using CreacionesPajov.WEB.Models.Dtos.Usuarios;
using CreacionesPajov.WEB.Models.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SendGrid;
using SendGrid.Helpers.Mail;
using SendGrid.Helpers.Mail.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using static CreacionesPajov.WEB.Helpers.Helper;

namespace CreacionesPajov.WEB.Controllers
{

    public class UsuariosController : Controller
    {

        private readonly IUsuarioService _usuarioService;
        private readonly SignInManager<Usuario> _signInManager;
        private readonly UserManager<Usuario> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IConfiguration _configuration;

        //SignInManager es el objeto encargado de el inicio de sesiones el cerrar.
        public UsuariosController(IUsuarioService usauriosService, SignInManager<Usuario> signInManager, UserManager<Usuario> userManager, RoleManager<IdentityRole> roleManager, IConfiguration configuration)
        {
            _usuarioService = usauriosService;
            _signInManager = signInManager;
            _userManager = userManager;
            _roleManager = roleManager;
            _configuration = configuration;
        }

        
       
        [NoDirectAccess]
        public async Task<IActionResult> Index()
        {
            ViewBag.Titulo = "Gestión de Usuarios";

            return View(await  _usuarioService.ObtenerListaUsuarios());

        }
        [NoDirectAccess]
        [Authorize]
       
        public IActionResult Crear()
        {

            return View();
        }


        [HttpPost]

        public async Task<IActionResult> Crear(RegistrarUsuarioDto registrarUsuarioDto)
        {
            //Comprobar si existe el usuario con el correo
            var email = await  _usuarioService.ObtenerUsuarioDtoPorEmail(registrarUsuarioDto.Email);
            {
                if (email == null)
                {
                    try
                    {
                        var usuarioId = await  _usuarioService.Crear(registrarUsuarioDto);

                        if (usuarioId == null)
                            return Json(new { isValid = false, tipoError = "danger", error = "Error al crear el usuario" });

                        if (usuarioId.Equals("ErrorPasword"))
                            return Json(new { isValid = false, tipoError = "danger", error = "Error de password" });
                        return Json(new { isValid = true, operacion = "crear" });
                    }
                    catch (Exception)
                    {

                        return Json(new { isValid = false, tipoError = "error", mensaje = "Error al crear el usuario." });
                    }
                }
                return Json(new { isValid = false, tipoError = "warning", error = "Debe diligencias los campos requeridos.", html = Helper.RenderRazorViewToString(this, "Crear", registrarUsuarioDto) });

            }

        }

        public IActionResult Landing()
        {

            return View();
        }

        public IActionResult Login()
        {

            return View();
        }

        [HttpPost]

        public async Task<IActionResult> Login(LoginDto loginDto)
        {
            if (ModelState.IsValid)
            {
                var resultado = await _signInManager.PasswordSignInAsync(loginDto.Email, loginDto.Password, loginDto.RecordarMe, false);
                if (resultado.Succeeded)
                    return RedirectToAction("DashBoard", "Admin");
            }

            return View();
        }

        public async Task<IActionResult> CerrarSesion()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Landing");
        }

        public IActionResult OlvidePassword()
        {
            return View();
        }


       
        [HttpPost]
        public async Task<IActionResult> OlvidePassword(RecuperarPasswordDto recuperarPasswordDto)
        {
            if (ModelState.IsValid)
            {
                //Buscamos si el email existe
                var usuario = await _userManager.FindByEmailAsync(recuperarPasswordDto.Email);
                if (usuario != null)
                {
                    //Generamos un token para SENDGRID
                    //var token = await _userManager.GeneratePasswordResetTokenAsync(usuario);
                    //Generamos token SMTP
                    var token = await _userManager.GeneratePasswordResetTokenAsync(usuario);

                    //Creamos un link para resetear password
                    var passwordResetLink = Url.Action("ResetearPassword", "Usuarios",
                    new { email = recuperarPasswordDto.Email, token = token }, Request.Scheme);

                    //Enviamos correo a traves de SMTP
                    MailMessage mensaje = new();
                    mensaje.To.Add(recuperarPasswordDto.Email); // destinatario
                    mensaje.Subject = "Creaciones Pajov - recuperar password"; // Asunto
                    mensaje.Body = @"Presione en el siguiente enlace para la restauración de sus contraseña: " + " " + passwordResetLink; // cuerpo del correo
                    //mensaje.IsBodyHtml = false;

                    mensaje.From = new MailAddress("creacionespajov@hotmail.com", "Creaciones-Pajov- Notificaciones");

                    // configurar el servidor SMTP

                    SmtpClient smtpClient = new("smtp-mail.outlook.com");
                    smtpClient.Port = 587;
                    smtpClient.UseDefaultCredentials = false;
                    smtpClient.EnableSsl = true;
                    smtpClient.Credentials = new NetworkCredential("creacionespajov@hotmail.com", "PajovCreaciones123");


                    try
                    {
                        smtpClient.Send(mensaje);
                        return RedirectToAction("Login");



                    }
                    catch (Exception)
                    {
                        return Json(new { isValid = false, tipoError = "error", mensaje = "Error interno en la recuperación de contraseña." });
                    }




                    //Envio de email de API(sengrid)

                    //var clienteCorreo = new SendGridClient(_configuration["Email:Key"]);

                    //Configuramos  el mensaje

                    //var mensaje = new SendGridMessage
                    //{
                    //    From = new EmailAddress(_configuration["Email:FromEmail"], _configuration["Email:FRomName"]),
                    //    Subject = "Creaciones Pajov - Recuperar contraseña ",
                    //    PlainTextContent = passwordresetlink,
                    //    HtmlContent = "<h1>Haga clik en el link para recuperar la contraseña:<h1><br><br>" + passwordresetlink
                    //};
                    //mensaje.AddTo(recuperarPasswordDto.Email);
                    //mensaje.SetClickTracking(false, false);
                    //var resultado = await clienteCorreo.SendEmailAsync(mensaje);

                    //if (resultado.IsSuccessStatusCode)
                    //    return RedirectToAction("Login");


                }
            }

            return View(recuperarPasswordDto);
        }
        [HttpGet]
        public IActionResult ResetearPassword(string token, string email)
        {
            if (token == null || email == null)
            {
                ModelState.AddModelError("", "Error de token o de email");
            }
            return View();

        }
   
        public async Task<IActionResult> ResetearPassword(ResetearPasswordDto resetearPasswordDto)
        {
            if (ModelState.IsValid)
            { 
            var usuario = await _userManager.FindByEmailAsync(resetearPasswordDto.Email);
            if (usuario != null)
            {
                    //Reseteamos el password
                    var resultado = await _userManager.ResetPasswordAsync(usuario, resetearPasswordDto.Token, resetearPasswordDto.Password);
                    if (resultado.Succeeded)

                       
                     RedirectToAction("Login");

                    else

                    return Json(new { isValid = false, tipoError = "danger", error = "Error al enviar el correo" });

                }

            }
            
            return View(resetearPasswordDto);

        }


       [Authorize]
        public async Task<IActionResult> Editar(string id)
        {
            if (id == null)
             return Json(new { isValid = false, error = "No se encuentra el registro" });
            var usuario = await _userManager.FindByIdAsync(id);
            ViewBag.ListaRoles = new SelectList(await _roleManager.Roles.ToListAsync(), "Name", "Name");
            var rolUsuario = await _userManager.GetRolesAsync(usuario);
            UsuarioAsignRol usuarioAsignarRol = new()
            {
                id = usuario.Id,
                Email = usuario.Email,
                Rol = rolUsuario.FirstOrDefault()
            };
            return View(usuarioAsignarRol);
        }
        [HttpPost]
        public async Task<IActionResult> Editar(string id, UsuarioAsignRol usuarioAsignarRol)
        {
            if (id == null)
                return Json(new { isValid = false, tipoError = "danger", error = "Error al actualizar" });
            if (ModelState.IsValid)
            {
                try
                {
                    var usuario = await _userManager.FindByIdAsync(usuarioAsignarRol.id);
                    var resultado = await _userManager.AddToRoleAsync(usuario, usuarioAsignarRol.Rol);
                    if (resultado.Succeeded)
                        return Json(new { isValid = true, operacion = "editar" });
                    else
                        return Json(new { isValid = false, tipoError = "danger", error = "Error al actualizar" });
                }
                catch (Exception)
                {
                    return Json(new { isValid = false, tipoError = "danger", error = "Error al actualizar" });
                }
            }
            return Json(new { isValid = false, tipoError = "warning", error = "Debe diligenciar los campos requeridos", html = Helper.RenderRazorViewToString(this, "Crear", usuarioAsignarRol) });
        }

        //[HttpGet]

        //public async Task<IActionResult> CambiarEstado(string email)
        //{
        //    if (email!= null)
        //    {
        //        try
        //        {
        //            var usuario = await  _usuarioService.ObtenerUsuarioDtoPorEmail(email);
        //            if (usuario != null)
        //            {
        //                usuario.Email = !usuario.Email;
        //                _usuarioService.O(usuario);
        //                var editar = await _usuarioservice.GaurdarCambios();
        //                if (editar)
        //                    return Json(new { isValid = true, });
        //            }


        //            else
        //                return Json(new { isValid = false, });
        //        }
        //        catch (Exception)
        //        {

        //            return Json(new { isValid = false, tipoError = "error", mensaje = "Error interno al consultar el registro." });

        //        }
        //    }
        //    return Json(new { isValid = false, tipoError = "error", mensaje = "Error  al consultar el registro." });

        //}

    }


}
