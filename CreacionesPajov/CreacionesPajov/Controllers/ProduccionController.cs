using CreacionesPajov.WEB.Helpers;
using CreacionesPajov.WEB.Models.Abstract;
using CreacionesPajov.WEB.Models.Abstract.IProduccion;
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
    public class ProduccionController : Controller
    {
        private readonly IProduccionService _produccionService;
        private readonly IFaseService _faseService;

        public ProduccionController(IProduccionService produccionService, IFaseService faseService)
        {
            _produccionService = produccionService; //inyectamos la interfaz empleadoService.
            _faseService = faseService;
        }
        public async Task<IActionResult> Index()
        {
            @ViewBag.Titulo = "Producción";
            ViewBag.Fases = new SelectList(await _faseService.ObtenerFases(), "FaseId", "Nombre");
            var producion = await _produccionService.ObtenerProduccion();
            return View(producion);
        }

        [HttpGet]
        //[NoDirectAccess]
        public async Task<IActionResult> Crear()
        {


            try
            {
                ViewBag.Titulo = "Crear Producción";
                ViewBag.Fases = new SelectList(await _faseService.ObtenerFases(), "FaseId", "Nombre");

                ViewBag.Produccion = new SelectList(await _produccionService.ObtenerProduccion(), "Nombre");
                return View();
            }
            catch (Exception)
            {
                return Json(new { isValid = false, tipoError = "error", mensaje = "Error interno al crear el registro." });

            }


        }
        [HttpPost]

        public async Task<IActionResult> CrearAsync(Produccion produccion)
        {
            if (produccion == null)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _produccionService.Crear(produccion);
                    var guardar = await _produccionService.GuardarCambios();
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
            ViewBag.Titulo = "Crear producción";
         
            return Json(new { isValid = false, tipoError = "warning", error = "Debe diligenciar los campos requeridos.", html = Helper.RenderRazorViewToString(this, "Crear", produccion) });
        }

        [HttpGet]

        public async Task<IActionResult> Editar(int? id)
        {
            if (id != null)
            {
                try
                {
                    ViewBag.Fases = new SelectList(await _faseService.ObtenerFases(), "FaseId", "Nombre");
                    var produccion = await _produccionService.ObtenerProduccionPorId(id.Value);
                    if (produccion != null)
                    {

                        ViewBag.Produccion = new SelectList(await _produccionService.ObtenerProduccion(), "Nombre");

                        return View(produccion);
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

        public async Task<IActionResult> Editar(int? id, Produccion produccion)
        {
            if (id != produccion.ProduccionId)
                return Json(new { isValid = false, tipoError = "error", mensaje = "Error interno al editar el registro." });

            if (ModelState.IsValid)
            {
                try
                {
                    _produccionService.Editar(produccion);
                    var editar = await _produccionService.GuardarCambios();
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
            ViewBag.Titulo = "Editar  producción";
            ViewBag.Produccion = new SelectList(await _produccionService.ObtenerProduccion(), "Nombre");
            return Json(new { isValid = false, tipoError = "warning", error = "Debe diligenciar los campos requeridos.", html = Helper.RenderRazorViewToString(this, "Editar", produccion) });




        }

       [HttpGet]

        public async Task<IActionResult> Detalle(int? id)
        {
            if (id != null)
            {
                try
                {
                    ViewBag.Fases = new SelectList(await _faseService.ObtenerFases(), "FaseId", "Nombre");
                    var produccion = await _produccionService.ObtenerProduccionPorId(id.Value);
                    if (produccion != null)
                        return View(produccion);
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
                    var produccion = await _produccionService.ObtenerProduccionPorId(id.Value);
                    if (produccion != null)
                    {
                        produccion.Estado = !produccion.Estado;
                        _produccionService.Editar(produccion);
                        var editar = await _produccionService.GuardarCambios();
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
