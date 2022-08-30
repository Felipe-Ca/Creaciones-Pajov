using CreacionesPajov.WEB.Helpers;
using CreacionesPajov.WEB.Models.Abstract;
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
    public class FasesController : Controller
    {
        private readonly IFaseService _fasesService;

        public FasesController(IFaseService fasesService)
        {
            _fasesService = fasesService; //inyectamos la interfaz faseservice.
        }
        public async Task<IActionResult> Index()
        {
            @ViewBag.Titulo = "Fases";
            var fases = await _fasesService.ObtenerFases();
            return View(fases);
        }

        [HttpGet]

        [NoDirectAccess]

        public async Task<IActionResult> Crear()
        {


            try
            {
                ViewBag.Titulo = "Crear Fase";
                ViewBag.Fases = new SelectList(await _fasesService.ObtenerFases(), "Nombre", "Descripcion");
                return View();
            }
            catch (Exception)
            {
                return Json(new { isValid = false, tipoError = "error", mensaje = "Error interno al crear el registro." });

            }


        }

        [HttpPost]

        public async Task<IActionResult> CrearAsync(Fase fase)
        {
            if (fase == null)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _fasesService.Crear(fase);
                    var guardar = await _fasesService.GaurdarCambios();
                    if (guardar)
                    {
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
            ViewBag.Titulo = "Crear Fase";
            ViewBag.Fases = new SelectList(await _fasesService.ObtenerFases(), "Nombre", "Descripcion");
            return Json(new { isValid = false, tipoError = "warning", error = "Debe diligencias los campos requeridos.", html = Helper.RenderRazorViewToString(this, "Crear", fase) });
        }

        [HttpGet]

        public async Task<IActionResult> Detalle(int? id)
        {
            if (id != null)
            {
                try
                {
                    var fase = await _fasesService.ObtenerfasePorId(id.Value);
                    if (fase != null)
                        return View(fase);
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
                    var fase = await _fasesService.ObtenerfasePorId(id.Value);
                    if (fase != null)
                    {

                        ViewBag.Fases = new SelectList(await _fasesService.ObtenerFases(), "Nombre", "Descripcion");

                        return View(fase);
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

        public async Task<IActionResult> Editar(int? id, Fase fase)
        {
            if (id != fase.FaseId)
                return Json(new { isValid = false, tipoError = "error", mensaje = "Error interno al editar el registro." });

            if (ModelState.IsValid)
            {
                try
                {
                    _fasesService.Editar(fase);
                    var editar = await _fasesService.GaurdarCambios();
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
            ViewBag.Titulo = "Editar  Fase";
            ViewBag.Fases = new SelectList(await _fasesService.ObtenerFases(), "Nombre", "Descripcion");
            return Json(new { isValid = false, tipoError = "warning", error = "Debe diligencias los campos requeridos.", html = Helper.RenderRazorViewToString(this, "Editar", fase) });




        }
        //public async Task<IActionResult> Editar(int? id, Fase fase)
        //{
        //    if (id != fase.FaseId)
        //        return Json(new { isValid = false, tipoError = "error", mensaje = "Error interno al editar el registro." });

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            _fasesService.Editar(fase);
        //            var editar = await _fasesService.GaurdarCambios();
        //            if (editar)
        //                return Json(new { isValid = true, fase = "editar" });

        //            else
        //                return Json(new { isValid = false, tipoError = "error", mensaje = "Error interno al editar el registro." });

        //        }
        //        catch (Exception)
        //        {

        //            return Json(new { isValid = false, tipoError = "error", mensaje = "Error interno al editar el registro." });

        //        }
        //    }
        //    //Si el modelo tiene errores en las validadciones
        //    ViewBag.Titulo = "Editar  Fase";
        //    ViewBag.TiposDocumento = new SelectList(await _fasesService.ObtenerFases(), "Nombre", "Descripcion");
        //    return Json(new { isValid = false, tipoError = "warning", error = "Debe diligencias los campos requeridos.", html = Helper.RenderRazorViewToString(this, "Editar", fase) });




        //}
        [HttpGet]

        public async Task<IActionResult> CambiarEstado(int? id)
        {
            if (id != null)
            {
                try
                {
                    var fase = await _fasesService.ObtenerfasePorId(id.Value);
                    if (fase != null)
                    {
                        fase.Estado = !fase.Estado;
                        //if (fase.Estado)
                        //    fase.Estado = false;
                        //else
                        //    fase.Estado = true;
                        _fasesService.Editar(fase);
                        var editar = await _fasesService.GaurdarCambios();
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
