using proyectoMortalidad.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace proyectoMortalidad.Controllers
{
    public class ConsultaController : Controller
    {
        // GET: Consulta
        public ActionResult Index()
        {
            List<Models.TableViewModels.ConsultaTVM> listaConsulta;
            List<Models.TableViewModels.DepartamentosTVM> listaConsultaDept;
            using (nofetal2017Entities db = new nofetal2017Entities())
            {
                var dataContext = new nofetal2017Entities();
                dataContext.Database.CommandTimeout = 3000; // Timeout en hardcode :( 

                listaConsulta = db.Database.SqlQuery<Models.TableViewModels.ConsultaTVM>("spTipoMuerte").ToList();
                listaConsultaDept = db.Database.SqlQuery<Models.TableViewModels.DepartamentosTVM>("spDepartamentos").ToList();

               
                ViewBag.Dato1 = "80";
                ViewBag.Dato = listaConsultaDept.ToArray();
            }
            return View(listaConsulta);
            
        }
       
        public ActionResult Consulta()
        {
            //List<Models.TableViewModels.ConsultaTVM> listaConsulta;
            List<Models.TableViewModels.DepartamentosTVM> listaConsultaDept;
            nofetal2017Entities db = new nofetal2017Entities();
            var dataContext = new nofetal2017Entities();
            dataContext.Database.CommandTimeout = 300; // Timeout en hardcode :( 

            //listaConsulta = db.Database.SqlQuery<Models.TableViewModels.ConsultaTVM>("spTipoMuerte").ToList();
            listaConsultaDept = db.Database.SqlQuery<Models.TableViewModels.DepartamentosTVM>("spDepartamentos").ToList();

            ViewBag.Dato = 50;

            return View();

        }
    }
}