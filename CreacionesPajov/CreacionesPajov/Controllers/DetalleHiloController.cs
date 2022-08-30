using CreacionesPajov.WEB.Models.Abstract.ILoteHilo;
using CreacionesPajov.WEB.Models.DAL;
using CreacionesPajov.WEB.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreacionesPajov.WEB.Controllers
{
    public class DetalleHiloController : Controller
    {
        private readonly AppDbContext _Context;
        private readonly ILoteHiloService _loteHiloservice;

        public DetalleHiloController(AppDbContext Context, ILoteHiloService _loteHiloservice)
        {
            this._Context = Context;
            this._loteHiloservice = _loteHiloservice;
        }

        //public IActionResult Index()
        //{

        //    //return await _Context.DetalleHilos.Where(x => x.Hilo).ToListAsync();

        //  //return await _context.Empleados.Where(x => x.Estado).Include(x => x.TiposDocumento).ToListAsync();


        //}


        public IActionResult Crear()

        {
            List<Hilo> hilos = _Context.Hilos.ToList();
            return View(hilos);
        }

        public async Task<IActionResult> Index()
        {
            return View(await _loteHiloservice.ObtenerLote());
        }

        public IActionResult Guardar(HiloViewModel hiloviewmodel)
        {
            using (var transaction = _Context.Database.BeginTransaction())
            {
                try
                {
                    ControlLote controLote = new ControlLote
                    {
                        Total = hiloviewmodel.Total,
                        Descripcion = "Hilo :" + " " + hiloviewmodel.Descripcion
                    };

                    _Context.Add(controLote);
                    _Context.SaveChanges();

                    foreach (Hilo hilo in hiloviewmodel.Hilos)
                    {
                        DetalleHilo detallehilo = new DetalleHilo
                        {
                            HiloId = hilo.HiloId,
                            ControlLoteId = controLote.IdControlLote
                        };
                        _Context.Add(detallehilo);
                    }
                    _Context.SaveChanges();
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                }
            }

            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> ListHilo(int id)
        {
            return View(await _loteHiloservice.ListarHilos(id));
        }
    }
}

