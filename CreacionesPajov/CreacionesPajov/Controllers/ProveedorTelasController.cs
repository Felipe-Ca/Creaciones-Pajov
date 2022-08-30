using CreacionesPajov.WEB.Helpers;
using CreacionesPajov.WEB.Models.Abstract.IProveedorTela;
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
    public class ProveedorTelasController : Controller
    {
        private readonly IProveedorTelaService _proveedortelasservice;

        public ProveedorTelasController(IProveedorTelaService proveedortelasservice)
        {
            _proveedortelasservice = proveedortelasservice; 
        }
        public async Task<IActionResult> Index()
        {
            @ViewBag.Titulo = "Proveedor Telas";
            var proveedortelas = await _proveedortelasservice.ObtenerProveedorTelas();
            return View(proveedortelas);
        }

        [HttpGet]

        [NoDirectAccess]

        public async Task<IActionResult> Crear()
        {


            try
            {
                ViewBag.Titulo = "Crear Proveedor Telas";
                ViewBag.ProveedorTelas = new SelectList(await _proveedortelasservice.ObtenerProveedorTelas(),"NIT" ,"Nombre");
                return View();
            }
            catch (Exception)
            {
                return Json(new { isValid = false, tipoError = "error", mensaje = "Error interno al crear el registro." });

            }


        }

        [HttpPost]

        public async Task<IActionResult> CrearAsync(ProveedorTela proveedortelas)
        {
            if (proveedortelas == null)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _proveedortelasservice.Crear(proveedortelas);
                    var guardar = await _proveedortelasservice.GaurdarCambios();
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
            ViewBag.Titulo = "Crear Proveedor Telas";
            ViewBag.ProveedorTelas = new SelectList(await _proveedortelasservice.ObtenerProveedorTelas(), "NIT", "Nombre");
            return Json(new { isValid = false, tipoError = "warning", error = "Debe diligencias los campos requeridos.", html = Helper.RenderRazorViewToString(this, "Crear", proveedortelas) });
        }

        [HttpGet]

        public async Task<IActionResult> Detalle(int? id)
        {
            if (id != null)
            {
                try
                {
                    var proveedortelas = await _proveedortelasservice.ObtenerProveedorTelaPorId(id.Value);
                    if (proveedortelas != null)
                        return View(proveedortelas);
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
                    var proveedortelas = await _proveedortelasservice.ObtenerProveedorTelaPorId(id.Value);
                    if (proveedortelas != null)
                    {

                        ViewBag.ProveedorTelas = new SelectList(await _proveedortelasservice.ObtenerProveedorTelas(), "NIT", "Nombre");

                        return View(proveedortelas);
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

        public async Task<IActionResult> Editar(int? id, ProveedorTela proveedortelas)
        {
            if (id != proveedortelas.ProveedorTelaId)
                return Json(new { isValid = false, tipoError = "error", mensaje = "Error interno al editar el registro." });

            if (ModelState.IsValid)
            {
                try
                {
                    _proveedortelasservice.Editar(proveedortelas);
                    var editar = await _proveedortelasservice.GaurdarCambios();
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
            ViewBag.Titulo = "Editar  Proveedor Telas";
            ViewBag.ProveedorTelas = new SelectList(await _proveedortelasservice.ObtenerProveedorTelas(), "NIT", "Nombre");
            return Json(new { isValid = false, tipoError = "warning", error = "Debe diligencias los campos requeridos.", html = Helper.RenderRazorViewToString(this, "Editar", proveedortelas) });




        }

        [HttpGet]

        public async Task<IActionResult> CambiarEstado(int? id)
        {
            if (id != null)
            {
                try
                {
                    var proveedortelas = await _proveedortelasservice.ObtenerProveedorTelaPorId(id.Value);
                    if (proveedortelas != null)
                    {
                        proveedortelas.Estado = !proveedortelas.Estado;
                        _proveedortelasservice.Editar(proveedortelas);
                        var editar = await _proveedortelasservice.GaurdarCambios();
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
