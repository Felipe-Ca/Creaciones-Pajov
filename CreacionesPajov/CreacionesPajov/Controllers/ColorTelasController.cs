using CreacionesPajov.WEB.Helpers;
using CreacionesPajov.WEB.Models.Abstract.IColorTela;
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
    public class ColorTelasController : Controller
    {
        private readonly IColorTelaService _colortelaservice;

        public ColorTelasController(IColorTelaService colortelaservice)
        {
            _colortelaservice = colortelaservice;
        }
        public async Task<IActionResult> Index()
        {
            @ViewBag.Titulo = "Color Telas";
            var colortelas = await _colortelaservice.ObtenerColorTelas();
            return View(colortelas);
        }

        [HttpGet]

        [NoDirectAccess]

        public async Task<IActionResult> Crear()
        {


            try
            {
                ViewBag.Titulo = "Crear Color Tela";
                ViewBag.ColorTelas = new SelectList(await _colortelaservice.ObtenerColorTelas(), "Nombre");
                return View();
            }
            catch (Exception)
            {
                return Json(new { isValid = false, tipoError = "error", mensaje = "Error interno al crear el registro." });

            }


        }

        [HttpPost]

        public async Task<IActionResult> CrearAsync(ColorTela colortela)
        {
            if (colortela == null)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _colortelaservice.Crear(colortela);
                    var guardar = await _colortelaservice.GaurdarCambios();
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
            ViewBag.Titulo = "Crear Color Tela";
            ViewBag.ColorTelas = new SelectList(await _colortelaservice.ObtenerColorTelas(), "Nombre");
            return Json(new { isValid = false, tipoError = "warning", error = "Debe diligencias los campos requeridos.", html = Helper.RenderRazorViewToString(this, "Crear", colortela) });
        }

        [HttpGet]

        public async Task<IActionResult> Detalle(int? id)
        {
            if (id != null)
            {
                try
                {
                    var colortela = await _colortelaservice.ObtenerColorTelaPorId(id.Value);
                    if (colortela != null)
                        return View(colortela);
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
                    var colortela = await _colortelaservice.ObtenerColorTelaPorId(id.Value);
                    if (colortela != null)
                    {

                        ViewBag.ColorTelas = new SelectList(await _colortelaservice.ObtenerColorTelas(), "Nombre");

                        return View(colortela);
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

        public async Task<IActionResult> Editar(int? id, ColorTela colortela)
        {
            if (id != colortela.ColorTelaId)
                return Json(new { isValid = false, tipoError = "error", mensaje = "Error interno al editar el registro." });

            if (ModelState.IsValid)
            {
                try
                {
                    _colortelaservice.Editar(colortela);
                    var editar = await _colortelaservice.GaurdarCambios();
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
            ViewBag.Titulo = "Editar  Colo Tela";
            ViewBag.ColorTelas = new SelectList(await _colortelaservice.ObtenerColorTelas(), "Nombre");
            return Json(new { isValid = false, tipoError = "warning", error = "Debe diligencias los campos requeridos.", html = Helper.RenderRazorViewToString(this, "Editar", colortela) });




        }

        //[HttpGet]

        //public async Task<IActionResult> CambiarEstado(int? id)
        //{
        //    if (id != null)
        //    {
        //        try
        //        {
        //            var colortela = await _colortelaservice.ObtenerColorTelaPorId(id.Value);
        //            if (colortela != null)
        //            {
        //                colortela.Estado = !colortela.Estado;
        //                _colortelaservice.Editar(colortela);
        //                var editar = await _colortelaservice.GaurdarCambios();
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
