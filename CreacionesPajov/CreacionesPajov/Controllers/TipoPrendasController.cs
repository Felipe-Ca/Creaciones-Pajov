using CreacionesPajov.WEB.Helpers;
using CreacionesPajov.WEB.Models.Abstract.ITipoPrendas;
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
    public class TipoPrendasController : Controller
    {
        private readonly ITipoPrendaService _tipoprendaservice;

        public TipoPrendasController(ITipoPrendaService tipoprendaservice)
        {
            _tipoprendaservice = tipoprendaservice; 
        }
        public async Task<IActionResult> Index()
        {
            @ViewBag.Titulo = "Tipo Prendas";
            var tipoprendas = await _tipoprendaservice.ObtenerTipoPrendas();
            return View(tipoprendas);
        }

        [HttpGet]

        [NoDirectAccess]

        public async Task<IActionResult> Crear()
        {


            try
            {
                ViewBag.Titulo = "Crear Tipo Prenda";
                ViewBag.TipoPrendas = new SelectList(await _tipoprendaservice.ObtenerTipoPrendas(), "Nombre");
                return View();
            }
            catch (Exception)
            {
                return Json(new { isValid = false, tipoError = "error", mensaje = "Error interno al crear el registro." });

            }


        }

        [HttpPost]

        public async Task<IActionResult> CrearAsync(TipoPrenda tipoprenda)
        {
            if (tipoprenda == null)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _tipoprendaservice.Crear(tipoprenda);
                    var guardar = await _tipoprendaservice.GaurdarCambios();
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
            ViewBag.Titulo = "Crear Tipo Prenda";
            ViewBag.TipoPrendas = new SelectList(await _tipoprendaservice.ObtenerTipoPrendas(), "Nombre");
            return Json(new { isValid = false, tipoError = "warning", error = "Debe diligencias los campos requeridos.", html = Helper.RenderRazorViewToString(this, "Crear", tipoprenda) });
        }

        [HttpGet]

        public async Task<IActionResult> Detalle(int? id)
        {
            if (id != null)
            {
                try
                {
                    var tipoprenda = await _tipoprendaservice.ObtenerTipoPrendaPorId(id.Value);
                    if (tipoprenda != null)
                        return View(tipoprenda);
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
                    var tipoprenda = await _tipoprendaservice.ObtenerTipoPrendaPorId(id.Value);
                    if (tipoprenda != null)
                    {

                        ViewBag.TipoPrendas = new SelectList(await _tipoprendaservice.ObtenerTipoPrendas(), "Nombre");

                        return View(tipoprenda);
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

        public async Task<IActionResult> Editar(int? id, TipoPrenda tipoprenda)
        {
            if (id != tipoprenda.TipoPrendaId)
                return Json(new { isValid = false, tipoError = "error", mensaje = "Error interno al editar el registro." });

            if (ModelState.IsValid)
            {
                try
                {
                    _tipoprendaservice.Editar(tipoprenda);
                    var editar = await _tipoprendaservice.GaurdarCambios();
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
            ViewBag.Titulo = "Editar  Tipo Prenda";
            ViewBag.TipoPrendas = new SelectList(await _tipoprendaservice.ObtenerTipoPrendas(), "Nombre");
            return Json(new { isValid = false, tipoError = "warning", error = "Debe diligencias los campos requeridos.", html = Helper.RenderRazorViewToString(this, "Editar", tipoprenda) });




        }

        //[HttpGet]

        //public async Task<IActionResult> CambiarEstado(int? id)
        //{
        //    if (id != null)
        //    {
        //        try
        //        {
        //            var tipoprenda = await _tipoprendaservice.ObtenerTipoPrendaPorId(id.Value);
        //            if (tipoprenda != null)
        //            {
        //                tipoprenda.Estado = !tipoprenda.Estado;

        //                _tipoprendaservice.Editar(tipoprenda);
        //                var editar = await _tipoprendaservice.GaurdarCambios();
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
