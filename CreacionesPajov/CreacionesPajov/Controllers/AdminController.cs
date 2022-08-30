using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static CreacionesPajov.WEB.Helpers.Helper;

namespace CreacionesPajov.WEB.Controllers
{

    public class AdminController : Controller
    {
        [NoDirectAccess]
        [Authorize]
        public IActionResult Index()
        {
            return View();
        }
        [NoDirectAccess]
        [Authorize]
        public IActionResult  DashBoard()
        {
            return View();
        }
        [NoDirectAccess]
        public IActionResult NoAutorizado()
        {
            return View();
        }
    }

}
