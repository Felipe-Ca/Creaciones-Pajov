using CreacionesPajov.WEB.Helpers;
using CreacionesPajov.WEB.Models.Abstract;
using CreacionesPajov.WEB.Models.Abstract.IRemision;
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
    public class RemisionesController : Controller
    {
        //private readonly ISubFaseService _subfaseService;
        //private readonly IOperacionService _operacionService;
        //private readonly IFaseService _faseService;

        private readonly IRemisionService _remisionService;
        private readonly IFaseService _faseService;

        public RemisionesController(IRemisionService remisionService, IFaseService faseService)
        {
            _remisionService = remisionService;
            _faseService = faseService;
        }

        public async Task<IActionResult> IndexAsync()
        {
            @ViewBag.Titulo = "Remisiones";
            var remisiones = await _remisionService.ObtenerRemisiones();
            return View(remisiones);
        }

        [HttpGet]

        //[NoDirectAccess]

        public async Task<IActionResult> Crear()
        {


            try
            {
                ViewBag.Titulo = "Crear Remisión";
                ViewBag.Fases = new SelectList(await _faseService.ObtenerFases(), "FaseId", "Nombre");
                return View();
            }
            catch (Exception)
            {
                return Json(new { isValid = false, tipoError = "error", mensaje = "Error interno al crear el registro." });

            }


        }

        [HttpPost]

        public async Task<IActionResult> CrearAsync(Remision remision)
        {
            if (remision == null)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _remisionService.Crear(remision);
                    var guardar = await _remisionService.GaurdarCambios();
                    if (guardar)
                    {

                        //TempData["Accion"] = "Guardar";
                        //TempData["Mansaje"] = $"Se resgistró el remision {remision.Nombre}";
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
            ViewBag.Titulo = "Crear Remisión";
            ViewBag.Fases = new SelectList(await _faseService.ObtenerFases(), "FaseId", "Nombre");

            return Json(new { isValid = false, tipoError = "warning", error = "Debe diligencias los campos requeridos.", html = Helper.RenderRazorViewToString(this, "Crear", remision) });
        }
        [HttpGet]

        public async Task<IActionResult> Editar(int? id)
        {
            if (id != null)
            {
                try
                {
                    var remision = await _remisionService.ObtenerRemisionPorId(id.Value);
                    if (remision != null)
                    {
                        ViewBag.Fases = new SelectList(await _faseService.ObtenerFases(), "FaseId", "Nombre");

                        return View(remision);
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
        public async Task<IActionResult> Editar(int? id, Remision remision)
        {
            if (id != remision.FaseId)
                return Json(new { isValid = false, tipoError = "error", mensaje = "Error interno al editar el registro." });

            if (ModelState.IsValid)
            {
                try
                {
                    _remisionService.Editar(remision);
                    var editar = await _remisionService.GaurdarCambios();
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
            ViewBag.Titulo = "Editar  Remisión";
            ViewBag.Fases = new SelectList(await _faseService.ObtenerFases(), "FaseId", "Nombre");
            return Json(new { isValid = false, tipoError = "warning", error = "Debe diligencias los campos requeridos.", html = Helper.RenderRazorViewToString(this, "Editar", remision) });




        }


        [HttpGet]

        public async Task<IActionResult> Detalle(int? id)
        {
            if (id != null)
            {
                try
                {
                    var remision = await _remisionService.ObtenerRemisionPorId(id.Value);
                    if (remision != null)
                        return View(remision);
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
        public async Task<IActionResult> CambiarEstado(int? id)
        {
            if (id != null)
            {
                try
                {
                    var remision = await _remisionService.ObtenerRemisionPorId(id.Value);
                    if (remision != null)
                    {
                        remision.Estado = !remision.Estado;
                        //if (remision.Estado)
                        //    remision.Estado = false;
                        //else
                        //    remision.Estado = true;
                        _remisionService.Editar(remision);
                        var editar = await _remisionService.GaurdarCambios();
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