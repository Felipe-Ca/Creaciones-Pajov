using CreacionesPajov.WEB.Helpers;
using CreacionesPajov.WEB.Models.Abstract;
using CreacionesPajov.WEB.Models.Bussines;
using CreacionesPajov.WEB.Models.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Threading.Tasks;
using static CreacionesPajov.WEB.Helpers.Helper;

namespace CreacionesPajov.WEB.Controllers
{
    
    public class EmpleadosController : Controller
    {
        private readonly IEmpleadoService _empleadoService;
        private readonly ITipoDocumentoService _tipoDocumentoService;

        public EmpleadosController(IEmpleadoService empleadoService, ITipoDocumentoService tipoDocumentoService)
        {
            _empleadoService = empleadoService; //inyectamos la interfaz empleadoService.
            _tipoDocumentoService = tipoDocumentoService;
        }
       
        public async Task<IActionResult> Index()
        {

            @ViewBag.Titulo = "Empleados";
            var empleados = await _empleadoService.ObtenerEmpleados();
            return View(empleados);
        }
        //index de empleados deshabilitados
        public async Task<IActionResult> Deshabilitados()
        {

            @ViewBag.Titulo = "Empleados";
            var empleados = await _empleadoService.ObtenerEmpleadosDeshabilitados();
            return View(empleados);
        }
        [HttpGet]

        

        public async Task<IActionResult> Crear()
        {


            try
            {
                ViewBag.Titulo = "Crear Empleado";
                ViewBag.TiposDocumento = new SelectList(await _tipoDocumentoService.ObtenerTiposDocumento(), "TipoDocumentoId", "Nombre");
                return View();
            }
            catch (Exception)
            {
                return Json(new { isValid = false, tipoError = "error", mensaje = "Error interno al crear el registro." });

            }


        }

        [HttpPost]

        public async Task<IActionResult> CrearAsync(Empleado empleado)
        {
            if (empleado == null)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _empleadoService.Crear(empleado);
                    var guardar = await _empleadoService.GaurdarCambios();
                    if (guardar)
                    {

                        //TempData["Accion"] = "Guardar";
                        //TempData["Mansaje"] = $"Se resgistró el empleado {empleado.Nombre}";
                        //return RedirectToAction("Index");
                        return Json(new { isValid = true, operacion = "crear" });
                    }
                    else
                        return Json(new { isValid = false, tipoError = "error", mensaje = "Error interno al crear el registro." });



                }
                catch (Exception)
                {

                    return Json(new { isValid = false, tipoError = "error", mensaje = "Error interno al crear el registro." });
                }

            }
            ViewBag.Titulo = "Crear Empleado";
            ViewBag.TiposDocumento = new SelectList(await _tipoDocumentoService.ObtenerTiposDocumento(), "TipoDocumentoId", "Nombre");
            return Json(new { isValid = false, tipoError = "warning", error = "Debe diligencias los campos requeridos.", html = Helper.RenderRazorViewToString(this, "Crear", empleado) });
        }

        [HttpGet]

        public async Task<IActionResult> Detalle(int? id)
        {
            if (id != null)
            {
                try
                {
                    var empleado = await _empleadoService.ObtenerEmpleadoPorId(id.Value);
                    if (empleado != null)
                        return View(empleado);
                    else
                        return Json(new { isValid = false, tipoError = "error", mensaje = "Error  al consultar el registro." });

                }
                catch (Exception)
                {

                    return Json(new { isValid = false, tipoError = "error", mensaje = "Error interno al consultar el registro." });

                }
            }
            return Json(new { isValid = false, tipoError = "error", mensaje = "Error  al consultar el registro." });

        }
        [HttpGet]

        public async Task<IActionResult> Editar(int? id)
        {
            if (id != null)
            {
                try
                {
                    var empleado = await _empleadoService.ObtenerEmpleadoPorId(id.Value);
                    if (empleado != null)
                    {

                        ViewBag.TiposDocumento = new SelectList(await _tipoDocumentoService.ObtenerTiposDocumento(), "TipoDocumentoId", "Nombre");

                        return View(empleado);
                    }
                    else
                        return NotFound();
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return NotFound();

        }
        [HttpPost]
        public async Task<IActionResult> Editar(int? id, Empleado empleado)
        {
            if (id != empleado.EmpleadoId)
                return Json(new { isValid = false, tipoError = "error", mensaje = "Error interno al editar el registro." });

            if (ModelState.IsValid)
            {
                try
                {
                    _empleadoService.Editar(empleado);
                    var editar = await _empleadoService.GaurdarCambios();
                    if (editar)
                        return Json(new { isValid = true, operacion = "editar" });

                    else
                        return Json(new { isValid = false, tipoError = "error", mensaje = "Error interno al editar el registro." });

                }
                catch (Exception)
                {

                    return Json(new { isValid = false, tipoError = "error", mensaje = "Error interno al editar el registro." });

                }
            }
            //Si el modelo tiene errores en las validadciones
            ViewBag.Titulo = "Editar  Empleado";
            ViewBag.TiposDocumento = new SelectList(await _tipoDocumentoService.ObtenerTiposDocumento(), "TipoDocumentoId", "Nombre");
            return Json(new { isValid = false, tipoError = "warning", error = "Debe diligencias los campos requeridos.", html = Helper.RenderRazorViewToString(this, "Editar", empleado) });




        }
        [HttpGet]

        public async Task<IActionResult> CambiarEstado(int? id)
        {
            if (id != null)
            {
                try
                {
                    var empleado = await _empleadoService.ObtenerEmpleadoPorId(id.Value);
                    if (empleado != null)
                    {
                        empleado.Estado = !empleado.Estado;
                        //if (empleado.Estado)
                        //    empleado.Estado = false;
                        //else
                        //    empleado.Estado = true;
                        _empleadoService.Editar(empleado);
                        var editar = await _empleadoService.GaurdarCambios();
                        if (editar)
                            return Json(new { isValid = true, });
                    }


                    else
                        return Json(new { isValid = false, });
                }
                catch (Exception)
                {

                    return Json(new { isValid = false, tipoError = "error", mensaje = "Error interno al consultar el registro." });

                }
            }
            return Json(new { isValid = false, tipoError = "error", mensaje = "Error  al consultar el registro." });

        }


    }
}