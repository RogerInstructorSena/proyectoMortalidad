using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using proyectoMortalidad.Models;
using proyectoMortalidad.Models.TableViewModels;

namespace proyectoMortalidad.Controllers
{
    public class MunicipiosController : Controller
    {
        // GET: Municipios
        public ActionResult Index()
        {
            List<Models.TableViewModels.MunicipiosTVM> listaMunicipios;
            using (nofetal2017Entities db = new nofetal2017Entities())
            {
                listaMunicipios = (from d in db.COD_MUNIC_PREGUNTA
                                      select new MunicipiosTVM
                                      {
                                          codMunicPreguntaId = d.codMunicPreguntaId,
                                          codMunicPreguntaNombre = d.codMunicPreguntaNombre
                                      }).ToList();

                
            }
            return View(listaMunicipios);
        }
    }
    }
