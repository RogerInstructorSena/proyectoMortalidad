﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using proyectoMortalidad.Models;
using proyectoMortalidad.Models.TableViewModels;


namespace proyectoMortalidad.Controllers
{
    public class DepartamentosController : Controller

    {
        //Get: Departamentos
        public ActionResult Index()
        {
            List<DepartamentosTVM> listaDepartamentos;
            using (nofetal2017Entities db = new nofetal2017Entities())
            {
                listaDepartamentos = (from d in db.COD_DPTO_PREGUNTA
                                     select new DepartamentosTVM
                                     {
                                         codDptoPreguntaId=d.codDptoPreguntaId,
                                         codDptoPreguntaNombre = d.codDptoPreguntaNombre
                                     }).ToList();


            }
                return View(listaDepartamentos);
        }

    }
}