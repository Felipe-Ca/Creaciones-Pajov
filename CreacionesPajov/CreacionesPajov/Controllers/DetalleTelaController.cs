using CreacionesPajov.WEB.Models.Abstract.ILoteTela;
using CreacionesPajov.WEB.Models.DAL;
using CreacionesPajov.WEB.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreacionesPajov.WEB.Controllers
{
    public class DetalleTelaController : Controller
    {
        private readonly AppDbContext _Context;
        private readonly ILoteTelaService _loteTelaservice;

        public DetalleTelaController(AppDbContext Context, ILoteTelaService _loteTelaservice)
        {
            this._Context = Context;
            this._loteTelaservice = _loteTelaservice;
        }

        //public IActionResult Index()
        //{

        //    //return await _Context.DetalleHilos.Where(x => x.Hilo).ToListAsync();

        //  //return await _context.Empleados.Where(x => x.Estado).Include(x => x.TiposDocumento).ToListAsync();


        //}


        public IActionResult Crear()

        {
            List<Tela> telas = _Context.Telas.ToList();
            return View(telas);
        }

        public async Task<IActionResult> Index()
        {

            return View(await _loteTelaservice.ObtenerLote());
        }

        public IActionResult Guardar(TelaViewModel telaviewmodel)
        {
            using (var transaction = _Context.Database.BeginTransaction())
            {
                try
                {
                    ControlLote controLote = new ControlLote
                    {
                        Total = telaviewmodel.Total,
                        Descripcion = "Tela : " +" "+ telaviewmodel.Descripcion
                    };

                    _Context.Add(controLote);
                    _Context.SaveChanges();

                    foreach (Tela tela in telaviewmodel.Telas)
                    {
                        DetalleTela detalletela = new DetalleTela
                        {
                            TelaId = tela.TelaId,
                            ControlLoteId = controLote.IdControlLote
                        };
                        _Context.Add(detalletela);
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

        public async Task<IActionResult> ListTela(int id)
        {
            return View(await _loteTelaservice.ListarTelas(id));
        }
    }
}
