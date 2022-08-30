using CreacionesPajov.WEB.Helpers;
using CreacionesPajov.WEB.Models.Abstract;
using CreacionesPajov.WEB.Models.Abstract.IOperacion;
using CreacionesPajov.WEB.Models.Abstract.ISubFase;
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
    public class SubFasesController : Controller
    {
        private readonly ISubFaseService _subfaseService;
        private readonly IOperacionService _operacionService;
        private readonly IFaseService _faseService;

        public SubFasesController(ISubFaseService subfaseService, IOperacionService operacionService, IFaseService faseService)
        {
            _subfaseService = subfaseService; //inyectamos las interfaces 
            _operacionService = operacionService;
            _faseService = faseService;
        }
        public async Task<IActionResult> IndexAsync()
        {
            @ViewBag.Titulo = "SubFases";
            var subfases = await _subfaseService.ObtenerSubFases(); ;
            return View(subfases);
        }

        [HttpGet]

        [NoDirectAccess]

        public async Task<IActionResult> Crear()
        {


            try
            {
                ViewBag.Titulo = "Crear SubFase";
                ViewBag.Operaciones = new SelectList(await _operacionService.ObtenerOperaciones(), "OperacionId", "Nombre");
                ViewBag.Fases = new SelectList(await _faseService.ObtenerFases(), "FaseId", "Nombre");
                return View();
            }
            catch (Exception)
            {
                return Json(new { isValid = false, tipoError = "error", mensaje = "Error interno al crear el registro." });

            }


        }

        [HttpPost]

        public async Task<IActionResult> CrearAsync(SubFase subfase)
        {
            if (subfase == null)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _subfaseService.Crear(subfase);
                    var guardar = await _subfaseService.GaurdarCambios();
                    if (guardar)
                    {

                        //TempData["Accion"] = "Guardar";
                        //TempData["Mansaje"] = $"Se resgistró el subfase {subfase.Nombre}";
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
            ViewBag.Titulo = "Crear SubFase";
            ViewBag.Operaciones = new SelectList(await _operacionService.ObtenerOperaciones(), "OperacionId", "Nombre");
            ViewBag.Fases = new SelectList(await _faseService.ObtenerFases(), "FaseId", "Nombre");

            return Json(new { isValid = false, tipoError = "warning", error = "Debe diligencias los campos requeridos.", html = Helper.RenderRazorViewToString(this, "Crear", subfase) });
        }
        [HttpGet]

        public async Task<IActionResult> Editar(int? id)
        {
            if (id != null)
            {
                try
                {
                    var subfase = await _subfaseService.ObtenerSubFasePorId(id.Value);
                    if (subfase != null)
                    {

                        ViewBag.Operaciones = new SelectList(await _operacionService.ObtenerOperaciones(), "OperacionId", "Nombre");
                        ViewBag.Fases = new SelectList(await _faseService.ObtenerFases(), "FaseId", "Nombre");

                        return View(subfase);
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
        public async Task<IActionResult> Editar(int? id, SubFase subfase)
        {
            if (id != subfase.FaseId)
                return Json(new { isValid = false, tipoError = "error", mensaje = "Error interno al editar el registro." });

            if (ModelState.IsValid)
            {
                try
                {
                    _subfaseService.Editar(subfase);
                    var editar = await _subfaseService.GaurdarCambios();
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
            ViewBag.Titulo = "Editar  SubFase";
            ViewBag.Operaciones = new SelectList(await _operacionService.ObtenerOperaciones(), "OperacionId", "Nombre");
            ViewBag.Fases = new SelectList(await _faseService.ObtenerFases(), "FaseId", "Nombre");
            return Json(new { isValid = false, tipoError = "warning", error = "Debe diligencias los campos requeridos.", html = Helper.RenderRazorViewToString(this, "Editar", subfase) });




        }


        [HttpGet]

        public async Task<IActionResult> Detalle(int? id)
        {
            if (id != null)
            {
                try
                {
                    var subfase = await _subfaseService.ObtenerSubFasePorId(id.Value);
                    if (subfase != null)
                        return View(subfase);
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
                    var subfase = await _subfaseService.ObtenerSubFasePorId(id.Value);
                    if (subfase != null)
                    {
                        subfase.Estado = !subfase.Estado;
                        //if (subfase.Estado)
                        //    subfase.Estado = false;
                        //else
                        //    subfase.Estado = true;
                        _subfaseService.Editar(subfase);
                        var editar = await _subfaseService.GaurdarCambios();
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
