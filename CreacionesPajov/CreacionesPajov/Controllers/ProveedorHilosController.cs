using CreacionesPajov.WEB.Helpers;
using CreacionesPajov.WEB.Models.Abstract.IProveedorHilo;
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
    public class ProveedorHilosController : Controller
    {
        private readonly IProveedorHiloService _proveedorhilosservice;

        public ProveedorHilosController(IProveedorHiloService proveedorhilosservice)
        {
            _proveedorhilosservice = proveedorhilosservice;
        }
        public async Task<IActionResult> Index()
        {
            @ViewBag.Titulo = "Proveedor Hilos";
            var proveedorhilos = await _proveedorhilosservice.ObtenerProveedorHilos();
            return View(proveedorhilos);
        }

        [HttpGet]

        [NoDirectAccess]

        public async Task<IActionResult> Crear()
        {


            try
            {
                ViewBag.Titulo = "Crear Proveedor Hilos";
                ViewBag.ProveedorHilos = new SelectList(await _proveedorhilosservice.ObtenerProveedorHilos(), "Nombre");
                return View();
            }
            catch (Exception)
            {
                return Json(new { isValid = false, tipoError = "error", mensaje = "Error interno al crear el registro." });

            }


        }

        [HttpPost]

        public async Task<IActionResult> CrearAsync(ProveedorHilo proveedorhilos)
        {
            if (proveedorhilos == null)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _proveedorhilosservice.Crear(proveedorhilos);
                    var guardar = await _proveedorhilosservice.GaurdarCambios();
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
            ViewBag.Titulo = "Crear Proveedor Hilos";
            ViewBag.ProveedorHilos = new SelectList(await _proveedorhilosservice.ObtenerProveedorHilos(), "NIT", "Nombre");
            return Json(new { isValid = false, tipoError = "warning", error = "Debe diligencias los campos requeridos.", html = Helper.RenderRazorViewToString(this, "Crear", proveedorhilos) });
        }



        [HttpGet]

        public async Task<IActionResult> Detalle(int? id)
        {
            if (id != null)
            {
                try
                {
                    var proveedorhilos = await _proveedorhilosservice.ObtenerProveedorHiloPorId(id.Value);
                    if (proveedorhilos != null)
                        return View(proveedorhilos);
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
                    var proveedorhilos = await _proveedorhilosservice.ObtenerProveedorHiloPorId(id.Value);
                    if (proveedorhilos != null)
                    {

                        ViewBag.ProveedorHilos = new SelectList(await _proveedorhilosservice.ObtenerProveedorHilos(), "NIT", "Nombre");

                        return View(proveedorhilos);
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

        public async Task<IActionResult> Editar(int? id, ProveedorHilo proveedorhilos)
        {
            if (id != proveedorhilos.ProveedorHiloId)
                return Json(new { isValid = false, tipoError = "error", mensaje = "Error interno al editar el registro." });

            if (ModelState.IsValid)
            {
                try
                {
                    _proveedorhilosservice.Editar(proveedorhilos);
                    var editar = await _proveedorhilosservice.GaurdarCambios();
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
            ViewBag.Titulo = "Editar  Proveedor Hilos";
            ViewBag.ProveedorHilos = new SelectList(await _proveedorhilosservice.ObtenerProveedorHilos(), "NIT", "Nombre");
            return Json(new { isValid = false, tipoError = "warning", error = "Debe diligencias los campos requeridos.", html = Helper.RenderRazorViewToString(this, "Editar", proveedorhilos) });




        }

        [HttpGet]

        public async Task<IActionResult> CambiarEstado(int? id)
        {
            if (id != null)
            {
                try
                {
                    var proveedorhilos = await _proveedorhilosservice.ObtenerProveedorHiloPorId(id.Value);
                    if (proveedorhilos != null)
                    {
                        proveedorhilos.Estado = !proveedorhilos.Estado;
                        _proveedorhilosservice.Editar(proveedorhilos);
                        var editar = await _proveedorhilosservice.GaurdarCambios();
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
