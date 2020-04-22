using proyectoMortalidad.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace proyectoMortalidad.Controllers
{
    public class EmpleadosController : Controller
    {
        // GET: Empleados
        // GET: Empleados
        ModeloDatos modelo;

        public EmpleadosController()
        {
            modelo = new ModeloDatos();
        }

        // GET: Index
        public ActionResult Index()
        {
            return View();
        }

        //GET: MultiplesObjetosVistas
        public ActionResult MultiplesObjetosVistas()
        {
            List<C_BAS1_PREGUNTA> listadept = this.modelo.GetDepartamentos();
            ViewBag.Departamentos = listadept;
            return View();
        }

        //POST: MultiplesObjetosVistas
        [HttpPost]
        public ActionResult MultiplesObjetosVistas(int deptno)
        {
            List<C_BAS1_PREGUNTA> listadept = this.modelo.GetDepartamentos();
            ViewBag.Departamentos = listadept;
            List<COD_DPTO_PREGUNTA> listaemp = this.modelo.BuscarEmpleadosDepartamento(deptno);
            return View(listaemp);
        }
    }
}