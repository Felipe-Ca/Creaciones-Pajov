using CreacionesPajov.WEB.Helpers;
using CreacionesPajov.WEB.Models.Abstract.IColorHilo;
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
    public class ColorHilosController : Controller
    {
        private readonly IColorHiloService _colorhilosService;

        public ColorHilosController(IColorHiloService colorhilosService)
        {
            _colorhilosService = colorhilosService; //inyectamos la interfaz faseservice.
        }
        [NoDirectAccess]
        public async Task<IActionResult> Index()
        {
            @ViewBag.Titulo = "Color Hilos";
            var fases = await _colorhilosService.ObtenerColorHilos();
            return View(fases);
        }

        [HttpGet]

        [NoDirectAccess]

        public async Task<IActionResult> Crear()
        {


            try
            {
                ViewBag.Titulo = "Crear Color Hilo";
                ViewBag.ColorHilos = new SelectList(await _colorhilosService.ObtenerColorHilos(), "Nombre");
                return View();
            }
            catch (Exception)
            {
                return Json(new { isValid = false, tipoError = "error", mensaje = "Error interno al crear el registro." });

            }


        }

        [HttpPost]

        public async Task<IActionResult> CrearAsync(ColorHilo colorhilo)
        {
            if (colorhilo == null)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _colorhilosService.Crear(colorhilo);
                    var guardar = await _colorhilosService.GaurdarCambios();
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
            ViewBag.Titulo = "Crear Color Hilo";
            ViewBag.ColorHilos = new SelectList(await _colorhilosService.ObtenerColorHilos(), "Nombre", "Descripcion");
            return Json(new { isValid = false, tipoError = "warning", error = "Debe diligencias los campos requeridos.", html = Helper.RenderRazorViewToString(this, "Crear", colorhilo) });
        }

        [HttpGet]

        public async Task<IActionResult> Detalle(int? id)
        {
            if (id != null)
            {
                try
                {
                    var colorhilo = await _colorhilosService.ObtenerColorHiloPorId(id.Value);
                    if (colorhilo != null)
                        return View(colorhilo);
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
                    var colorhilo = await _colorhilosService.ObtenerColorHiloPorId(id.Value);
                    if (colorhilo != null)
                    {

                        ViewBag.ColorHilos = new SelectList(await _colorhilosService.ObtenerColorHilos(), "Nombre");

                        return View(colorhilo);
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

        public async Task<IActionResult> Editar(int? id, ColorHilo colorhilo)
        {
            if (id != colorhilo.ColorHiloId)
                return Json(new { isValid = false, tipoError = "error", mensaje = "Error interno al editar el registro." });

            if (ModelState.IsValid)
            {
                try
                {
                    _colorhilosService.Editar(colorhilo);
                    var editar = await _colorhilosService.GaurdarCambios();
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
            ViewBag.Titulo = "Editar  Color Hilo";
            ViewBag.ColorHilos = new SelectList(await _colorhilosService.ObtenerColorHilos(), "Nombre", "Descripcion");
            return Json(new { isValid = false, tipoError = "warning", error = "Debe diligencias los campos requeridos.", html = Helper.RenderRazorViewToString(this, "Editar", colorhilo) });




        }
        //public async Task<IActionResult> Editar(int? id, Color Hilo colorhilo)
        //{
        //    if (id != colorhilo.FaseId)
        //        return Json(new { isValid = false, tipoError = "error", mensaje = "Error interno al editar el registro." });

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            _colorhilosService.Editar(colorhilo);
        //            var editar = await _colorhilosService.GaurdarCambios();
        //            if (editar)
        //                return Json(new { isValid = true, colorhilo = "editar" });

        //            else
        //                return Json(new { isValid = false, tipoError = "error", mensaje = "Error interno al editar el registro." });

        //        }
        //        catch (Exception)
        //        {

        //            return Json(new { isValid = false, tipoError = "error", mensaje = "Error interno al editar el registro." });

        //        }
        //    }
        //    //Si el modelo tiene errores en las validadciones
        //    ViewBag.Titulo = "Editar  Color Hilo";
        //    ViewBag.TiposDocumento = new SelectList(await _colorhilosService.ObtenerFases(), "Nombre", "Descripcion");
        //    return Json(new { isValid = false, tipoError = "warning", error = "Debe diligencias los campos requeridos.", html = Helper.RenderRazorViewToString(this, "Editar", colorhilo) });




        //}
        //[HttpGet]

        //public async Task<IActionResult> CambiarEstado(int? id)
        //{
        //    if (id != null)
        //    {
        //        try
        //        {
        //            var colorhilo = await _colorhilosService.ObtenerColorHiloPorId(id.Value);
        //            if (colorhilo != null)
        //            {
        //                colorhilo.Estado = !colorhilo.Estado;
        //                //if (colorhilo.Estado)
        //                //    colorhilo.Estado = false;
        //                //else
        //                //    colorhilo.Estado = true;
        //                _colorhilosService.Editar(colorhilo);
        //                var editar = await _colorhilosService.GaurdarCambios();
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
