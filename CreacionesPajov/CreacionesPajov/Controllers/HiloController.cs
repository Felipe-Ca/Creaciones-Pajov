using CreacionesPajov.WEB.Helpers;
using CreacionesPajov.WEB.Models.Abstract.IColorHilo;
using CreacionesPajov.WEB.Models.Abstract.IHilos;
using CreacionesPajov.WEB.Models.Abstract.IProveedorHilo;
using CreacionesPajov.WEB.Models.Bussines;
using CreacionesPajov.WEB.Models.DAL;
using CreacionesPajov.WEB.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreacionesPajov.WEB.Controllers
{
    public class HiloController : Controller
    {

        private readonly IHilosService _hilosService;

        private readonly IProveedorHiloService _proveedorHilo;

        private readonly IColorHiloService _colorHiloService;

        public HiloController(IHilosService hilosService, IProveedorHiloService proveedorHilo, IColorHiloService colorHiloService)
        {
            _hilosService = hilosService; //inyectamos la interfaz empleadoService.
            _proveedorHilo = proveedorHilo;
            _colorHiloService = colorHiloService;
        }
        public async Task<IActionResult> Index()
        {

            @ViewBag.Titulo = "Hilos";
            var hilos = await _hilosService.ObtenerHilo();
            return View(hilos);
        }


        //Index de Stanly a traves de una lista
        //public async Task<IActionResult> Index()
        //{
        //    List<Hilo> hilos = await _AppDbContext.Hilos.ToListAsync();
        //    return View(hilos);

        //}

        [HttpGet]
        public async Task<IActionResult> Crear()
        {


            try
            {
                ViewBag.Titulo = "Crear hilo";
                ViewBag.TiposProveedores = new SelectList(await _proveedorHilo.ObtenerProveedorHilos(), "ProveedorHiloId", "Nombre");
                ViewBag.ColoresHilos = new SelectList(await _colorHiloService.ObtenerColorHilos(), "ColorHiloId", "Nombre");
                return View();
            }
            catch (Exception)
            {
                return Json(new { isValid = false, tipoError = "error", mensaje = "Error interno al crear el registro." });

            }


        }
        [HttpPost]

        public async Task<IActionResult> CrearAsync(Hilo hilo)
        {
            if (hilo == null)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _hilosService.Crear(hilo);
                    var guardar = await _hilosService.GuardarCambios();
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
            ViewBag.Titulo = "Crear hilo";

            return Json(new { isValid = false, tipoError = "warning", error = "Debe diligenciar los campos requeridos.", html = Helper.RenderRazorViewToString(this, "Crear", hilo) });
        }

        [HttpGet]

        public async Task<IActionResult> Editar(int? id)
        {
            if (id != null)
            {
                try
                {
                    var hilo = await _hilosService.ObtenerHiloPorId(id.Value);
                    if (hilo!= null)
                    {
                        ViewBag.TiposProveedores = new SelectList(await _proveedorHilo.ObtenerProveedorHilos(), "ProveedorHiloId", "Nombre");
                        ViewBag.ColoresHilos = new SelectList(await _colorHiloService.ObtenerColorHilos(), "ColorHiloId", "Nombre");
                        ViewBag.Hilo = new SelectList(await _hilosService.ObtenerHilo(), "Descripción");

                        return View(hilo);
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

        public async Task<IActionResult> Editar(int? id, Hilo hilo)
        {
            if (id != hilo.HiloId)
                return Json(new { isValid = false, tipoError = "error", mensaje = "Error interno al editar el registro." });

            if (ModelState.IsValid)
            {
                try
                {
                    _hilosService.Editar(hilo);
                    var editar = await _hilosService.GuardarCambios();
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
            ViewBag.Titulo = "Editar  hilo";
            ViewBag.Hilo = new SelectList(await _hilosService.ObtenerHilo(), "Descripción");
            return Json(new { isValid = false, tipoError = "warning", error = "Debe diligenciar los campos requeridos.", html = Helper.RenderRazorViewToString(this, "Editar", hilo) });


        }

        [HttpGet]

        public async Task<IActionResult> Detalle(int? id)
        {
            if (id != null)
            {
                try
                {
                    ViewBag.TiposProveedores = new SelectList(await _proveedorHilo.ObtenerProveedorHilos(), "ProveedorHiloId", "Nombre");
                    ViewBag.ColoresHilos = new SelectList(await _colorHiloService.ObtenerColorHilos(), "ColorHiloId", "Nombre");
                    var hilo = await _hilosService.ObtenerHiloPorId(id.Value);
                    if (hilo != null)
                        return View(hilo);
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

       



    }
}
