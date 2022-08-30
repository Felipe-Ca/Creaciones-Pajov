using CreacionesPajov.WEB.Helpers;
using CreacionesPajov.WEB.Models.Abstract;
using CreacionesPajov.WEB.Models.Abstract.ITipoNovedadEmpleado;
using CreacionesPajov.WEB.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreacionesPajov.WEB.Controllers
{
    public class TipoNovedadEmpleadosController : Controller
    {
        private readonly ITipoNovedadEmpleadoService _tiponovedadempleadoservice;
        private readonly IEmpleadoService _empleadoService;

        public TipoNovedadEmpleadosController(ITipoNovedadEmpleadoService tiponovedadempleadoservice, IEmpleadoService empleadoService)
        {
            _empleadoService = empleadoService; //inyectamos la interfaz empleadoService.
            _tiponovedadempleadoservice = tiponovedadempleadoservice;
        }

        public async Task<IActionResult> Index()
        {

            @ViewBag.Titulo = "Novedad Empleados";
            var tiponovedadempleados = await _tiponovedadempleadoservice.ObtenerTipoNovedadEmpleados();
            return View(tiponovedadempleados);
        }

        [HttpGet]

        public async Task<IActionResult> Crear()
        {


            try
            {
                ViewBag.Titulo = "Crear Novedad Empleado";
                ViewBag.Empleado = new SelectList(await _empleadoService.ObtenerEmpleados(), "EmpleadoId", "Nombre");
                return View();
            }
            catch (Exception)
            {
                return Json(new { isValid = false, tipoError = "error", mensaje = "Error interno al crear el registro." });

            }


        }

        [HttpPost]

        public async Task<IActionResult> Crear(TipoNovedadEmpleado tiponovedadempleados)
        {
            if (tiponovedadempleados == null)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _tiponovedadempleadoservice.Crear(tiponovedadempleados);
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
            ViewBag.Titulo = "Crear Novedad Empleado";
            ViewBag.Empleado = new SelectList(await _empleadoService.ObtenerEmpleados(), "EmpleadoId", "Nombre");
            return Json(new { isValid = false, tipoError = "warning", error = "Debe diligencias los campos requeridos.", html = Helper.RenderRazorViewToString(this, "Crear", tiponovedadempleados) });
        }

        [HttpGet]

        public async Task<IActionResult> Detalle(int? id)
        {
            if (id != null)
            {
                try
                {
                    var tiponovedadempleados = await _tiponovedadempleadoservice.ObtenerTipoNovedadEmpleadoPorId(id.Value);
                    if (tiponovedadempleados != null)
                        return View(tiponovedadempleados);
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
                    var tiponovedadempleados = await _tiponovedadempleadoservice.ObtenerTipoNovedadEmpleadoPorId(id.Value);
                    if (tiponovedadempleados != null)
                    {

                        ViewBag.Empleado = new SelectList(await _empleadoService.ObtenerEmpleados(), "EmpleadoId", "Nombre");

                        return View(tiponovedadempleados);
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
        public async Task<IActionResult> Editar(int? id, TipoNovedadEmpleado tiponovedadempleados)
        {
            if (id != tiponovedadempleados.TipoNovedadEmpleadoId)
                return Json(new { isValid = false, tipoError = "error", mensaje = "Error interno al editar el registro." });

            if (ModelState.IsValid)
            {
                try
                {
                    _tiponovedadempleadoservice.Editar(tiponovedadempleados);
                    var editar = await _tiponovedadempleadoservice.GaurdarCambios();
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
            ViewBag.Empleado = new SelectList(await _empleadoService.ObtenerEmpleados(), "EmpleadoId", "Nombre");
            return Json(new { isValid = false, tipoError = "warning", error = "Debe diligencias los campos requeridos.", html = Helper.RenderRazorViewToString(this, "Editar", tiponovedadempleados) });




        }
        //[HttpGet]

        //public async Task<IActionResult> Editar(int? id)
        //{
        //    if (id != null)
        //    {
        //        try
        //        {
        //            var tiponovedadempleados = await _tiponovedadempleadoservice.ObtenerTipoNovedadEmpleadoPorId(id.Value);
        //            if (tiponovedadempleados != null)
        //            {

        //                ViewBag.Empleado = new SelectList(await _empleadoService.ObtenerEmpleados(), "EmpleadoId", "Nombre");

        //                return View(tiponovedadempleados);
        //            }
        //            else
        //                return NotFound();
        //        }
        //        catch (Exception)
        //        {

        //            throw;
        //        }
        //    }
        //    return NotFound();

        //}
        //[HttpPost]
        //public async Task<IActionResult> Editar(int? id, TipoNovedadEmpleado tiponovedadempleados)
        //{
        //    if (id != tiponovedadempleados.TipoNovedadEmpleadoId)
        //        return Json(new { isValid = false, tipoError = "error", mensaje = "Error interno al editar el registro." });

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            _tiponovedadempleadoservice.Editar(tiponovedadempleados);
        //            var editar = await _tiponovedadempleadoservice.GaurdarCambios();
        //            if (editar)
        //                return Json(new { isValid = true, operacion = "editar" });

        //            else
        //                return Json(new { isValid = false, tipoError = "error", mensaje = "Error interno al editar el registro." });

        //        }
        //        catch (Exception)
        //        {

        //            return Json(new { isValid = false, tipoError = "error", mensaje = "Error interno al editar el registro." });

        //        }
        //    }
        //    //Si el modelo tiene errores en las validadciones
        //    ViewBag.Titulo = "Editar  Novedad Empleado";
        //    ViewBag.Empleado = new SelectList(await _empleadoService.ObtenerEmpleados(), "EmpleadoId", "Nombre");
        //    return Json(new { isValid = false, tipoError = "warning", error = "Debe diligencias los campos requeridos.", html = Helper.RenderRazorViewToString(this, "Editar", tiponovedadempleados) });




        //}
        //[HttpGet]

        //public async Task<IActionResult> CambiarEstado(int? id)
        //{
        //    if (id != null)
        //    {
        //        try
        //        {
        //            var tiponovedadempleados = await _tiponovedadempleadoservice.ObtenerTipoNovedadEmpleadoPorId(id.Value);
        //            if (tiponovedadempleados != null)
        //            {
        //                //tiponovedadempleados.Estado = !tiponovedadempleados.Estado;
        //                //if (empleado.Estado)
        //                //    empleado.Estado = false;
        //                //else
        //                //    empleado.Estado = true;
        //                _tiponovedadempleadoservice.Editar(tiponovedadempleados);
        //                var editar = await _empleadoService.GaurdarCambios();
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
