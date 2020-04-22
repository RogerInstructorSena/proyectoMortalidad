using proyectoMortalidad.Models;
using proyectoMortalidad.Models.TableViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace proyectoMortalidad.Controllers
{
    public class GeneroDepMunController : Controller
    {
        // GET: GeneroDepMun
        public ActionResult Index()
        {
            List<Models.TableViewModels.GeneroDepMunTVM> listaGeneroDepMun;
            using (nofetal2017Entities db = new nofetal2017Entities())
            {
              listaGeneroDepMun = db.Database.SqlQuery<GeneroDepMunTVM>("spTodosSexoDepartamentoMunicipio").ToList();


            }
            return View(listaGeneroDepMun);
        }
    }
    }
