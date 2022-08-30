using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Rotativa.AspNetCore;
using CreacionesPajov.WEB.Models.Abstract;

namespace CreacionesPajov.WEB.Controllers
{
    public class ReportesController : Controller
    {

        private readonly IEmpleadoService _empleadoService;
        private readonly ITipoDocumentoService _tipoDocumentoService;

        public ReportesController(IEmpleadoService empleadoService, ITipoDocumentoService tipoDocumentoService)
        {
            _empleadoService = empleadoService; //inyectamos la interfaz empleadoService.
            _tipoDocumentoService = tipoDocumentoService;
        }

        public async Task<IActionResult> Index()
        {
            var empleados = await _empleadoService.ObtenerEmpleados();
            return new ViewAsPdf("Index", empleados) { 
            
            };
        }

    }
}
