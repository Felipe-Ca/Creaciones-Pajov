using CreacionesPajov.WEB.Helpers;
using CreacionesPajov.WEB.Models.Abstract.IOperacion;
using CreacionesPajov.WEB.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static CreacionesPajov.WEB.Helpers.Helper;

namespace CreacionesPajov.WEB.Controllers
{
    public class OperacionesController : Controller
    {
        private readonly IOperacionService _operacionService;
        private readonly ITipoOperacionService _tipoOperacionService;

        public OperacionesController(IOperacionService operacionService,ITipoOperacionService tipoOperacionService)
        {
            _operacionService = operacionService; //inyectamos la interfaz operacionService.
            _tipoOperacionService = tipoOperacionService;
        }
        public async Task<IActionResult> Index()
        {
            @ViewBag.Titulo = "Operaciones";
            var operaciones = await _operacionService.ObtenerOperaciones();
            return View(operaciones);
        }

        [HttpGet]

        [NoDirectAccess]

        public async Task<IActionResult> Crear()
        {


            try
            {
                ViewBag.Titulo = "Crear Operacion";
                ViewBag.TiposOperacion = new SelectList(await _tipoOperacionService.ObtenerTiposOperacion(), "TipoOperacionId", "Nombre");
                return View();
            }
            catch (Exception)
            {
                return Json(new { isValid = false, tipoError = "error", mensaje = "Error interno al crear el registro." });

            }


        }

        [HttpPost]

        public async Task<IActionResult> CrearAsync(Operacion operacion)
        {
            if (operacion == null)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _operacionService.Crear(operacion);
                    var guardar = await _operacionService.GaurdarCambios();
                    if (guardar)
                    {

                        //TempData["Accion"] = "Guardar";
                        //TempData["Mansaje"] = $"Se resgistró el operacion {operacion.Nombre}";
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
            ViewBag.Titulo = "Crear Operacion";
            ViewBag.TiposOperacion = new SelectList(await _tipoOperacionService.ObtenerTiposOperacion(), "TipoOperacionId", "Nombre");
            return Json(new { isValid = false, tipoError = "warning", error = "Debe diligencias los campos requeridos.", html = Helper.RenderRazorViewToString(this, "Crear", operacion) });
        }

        [HttpGet]

        public async Task<IActionResult> Detalle(int? id)
        {
            if (id != null)
            {
                try
                {
                    var operacion = await _operacionService.ObteneroperacionPorId(id.Value);
                    if (operacion != null)
                        return View(operacion);
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
                    var operacion = await _operacionService.ObteneroperacionPorId(id.Value);
                    if (operacion != null)
                    {
                        ViewBag.TiposOperacion = new SelectList(await _tipoOperacionService.ObtenerTiposOperacion(), "TipoOperacionId", "Nombre");

                        return View(operacion);
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
        public async Task<IActionResult> Editar(int? id, Operacion operacion)
        {
            if (id != operacion.OperacionId)
                return Json(new { isValid = false, tipoError = "error", mensaje = "Error interno al editar el registro." });

            if (ModelState.IsValid)
            {
                try
                {
                    _operacionService.Editar(operacion);
                    var editar = await _operacionService.GaurdarCambios();
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
            ViewBag.Titulo = "Editar  Operacion";
            ViewBag.TiposOperacion = new SelectList(await _tipoOperacionService.ObtenerTiposOperacion(), "TipoOperacionId", "Nombre");
            return Json(new { isValid = false, tipoError = "warning", error = "Debe diligencias los campos requeridos.", html = Helper.RenderRazorViewToString(this, "Editar", operacion) });




        }
        [HttpGet]

        //public async Task<IActionResult> CambiarEstado(int? id)
        //{
        //    if (id != null)
        //    {
        //        try
        //        {
        //            var operacion = await _operacionService.ObteneroperacionPorId(id);
        //            if (operacion != null)
        //            {
        //                operacion.Estado = !operacion.Estado;
        //                //if (operacion.Estado)
        //                //    operacion.Estado = false;
        //                //else
        //                //    operacion.Estado = true;
        //                _operacionService.Editar(operacion);
        //                var editar = await _operacionService.GaurdarCambios();
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

        public async Task<IActionResult> CambiarEstado(int? id)
        {
            if (id != null)
            {
                try
                {
                    var operacion = await _operacionService.ObteneroperacionPorId(id.Value);
                    if (operacion != null)
                    {
                        operacion.Estado = !operacion.Estado;
                        //if (operacion.Estado)
                        //    operacion.Estado = false;
                        //else
                        //    operacion.Estado = true;
                        _operacionService.Editar(operacion);
                        var editar = await _operacionService.GaurdarCambios();
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
