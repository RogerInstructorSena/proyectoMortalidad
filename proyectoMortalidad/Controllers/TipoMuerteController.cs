using proyectoMortalidad.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace proyectoMortalidad.Controllers
{
    public class TipoMuerteController : Controller
    {
        // GET: TipoMuerte
        public ActionResult Index()
        {
            List<Models.TableViewModels.TipoMuerteTVM> listaTipoMuerte;
            using (nofetal2017Entities db = new nofetal2017Entities())
            {
                var dataContext = new nofetal2017Entities();
                dataContext.Database.CommandTimeout = 300; // Timeout en hardcode :( 

                listaTipoMuerte = db.Database.SqlQuery<Models.TableViewModels.TipoMuerteTVM>("spTipoMuerte").ToList();


            }
            return View(listaTipoMuerte);
        }
    }
}