using CreacionesPajov.WEB.Helpers;
using CreacionesPajov.WEB.Models.Abstract.IColorTela;
using CreacionesPajov.WEB.Models.Abstract.IProveedorTela;
using CreacionesPajov.WEB.Models.Abstract.ITelas;
using CreacionesPajov.WEB.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreacionesPajov.WEB.Controllers
{
    public class TelaController : Controller
    {
        private readonly ITelasService _telasService;

        private readonly IProveedorTelaService _proveedorTela;

        private readonly IColorTelaService _colorTelaService;

        public TelaController(ITelasService telasService, IProveedorTelaService proveedorTela, IColorTelaService colorTelaService)
        {
            _telasService = telasService; //inyectamos la interfaz empleadoService.
            _proveedorTela = proveedorTela;
            _colorTelaService = colorTelaService;
        }
        public async Task<IActionResult> Index()
        {

            @ViewBag.Titulo = "Telas";
            var telas = await _telasService.ObtenerTela();
            return View(telas);
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
                ViewBag.Titulo = "Crear tela";
                ViewBag.ProveedorTelas = new SelectList(await _proveedorTela.ObtenerProveedorTelas(), "ProveedorTelaId", "Nombre");
                ViewBag.ColoresTelas = new SelectList(await _colorTelaService.ObtenerColorTelas(), "ColorTelaId", "Nombre");
                return View();
            }
            catch (Exception)
            {
                return Json(new { isValid = false, tipoError = "error", mensaje = "Error interno al crear el registro." });

            }


        }
        [HttpPost]

        public async Task<IActionResult> CrearAsync(Tela tela)
        {
            if (tela == null)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _telasService.Crear(tela);
                    var guardar = await _telasService.GuardarCambios();
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
            ViewBag.Titulo = "Crear tela";

            return Json(new { isValid = false, tipoError = "warning", error = "Debe diligenciar los campos requeridos.", html = Helper.RenderRazorViewToString(this, "Crear", tela) });
        }

        [HttpGet]

        public async Task<IActionResult> Editar(int? id)
        {
            if (id != null)
            {
                try
                {

                    var tela = await _telasService.ObtenerTelaPorId(id.Value);
                    if (tela != null)
                    {
                        ViewBag.ProveedorTelas = new SelectList(await _proveedorTela.ObtenerProveedorTelas(), "ProveedorTelaId", "Nombre");
                        ViewBag.ColoresTelas = new SelectList(await _colorTelaService.ObtenerColorTelas(), "ColorTelaId", "Nombre");

                        ViewBag.Tela = new SelectList(await _telasService.ObtenerTela(), "Descripción");

                        return View(tela);
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

        public async Task<IActionResult> Editar(int? id, Tela tela)
        {
            if (id != tela.TelaId)
                return Json(new { isValid = false, tipoError = "error", mensaje = "Error interno al editar el registro." });

            if (ModelState.IsValid)
            {
                try
                {
                    _telasService.Editar(tela);
                    var editar = await _telasService.GuardarCambios();
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
            ViewBag.Titulo = "Editar  tela";
            ViewBag.Tela = new SelectList(await _telasService.ObtenerTela(), "Descripción");
            return Json(new { isValid = false, tipoError = "warning", error = "Debe diligenciar los campos requeridos.", html = Helper.RenderRazorViewToString(this, "Editar", tela) });


        }

        [HttpGet]

        public async Task<IActionResult> Detalle(int? id)
        {
            if (id != null)
            {
                try
                {
                    ViewBag.ProveedorTelas = new SelectList(await _proveedorTela.ObtenerProveedorTelas(), "ProveedorTelaId", "Nombre");
                    ViewBag.ColoresTelas = new SelectList(await _colorTelaService.ObtenerColorTelas(), "ColorTelaId", "Nombre");
                    var hilo = await _telasService.ObtenerTelaPorId(id.Value);
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
