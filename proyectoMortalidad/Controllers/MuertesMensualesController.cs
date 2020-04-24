using proyectoMortalidad.Models;
using proyectoMortalidad.Models.TableViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace proyectoMortalidad.Controllers
{
    public class MuertesMensualesController : Controller
    {
        // GET: MuertesMensuales
        public ActionResult Index()
        {
            List<Models.TableViewModels.MuertesMensualesTVM> listaMuertesMensuales;
            using (nofetal2017Entities db = new nofetal2017Entities())
            {
                //var dataContext = new nofetal2017Entities();
                //dataContext.Database.CommandTimeout = 3000; // Timeout en hardcode :( 

                listaMuertesMensuales = db.Database.SqlQuery<MuertesMensualesTVM>("spMuertesMensuales").ToList();

                ViewBag.Dato = listaMuertesMensuales.ToArray();

            }
            return View(listaMuertesMensuales);
        }
    }
}