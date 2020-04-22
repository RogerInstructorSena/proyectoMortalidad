using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace proyectoMortalidad.Models
{
    public class ModeloDatos
    {
        nofetal2017Entities contexto;
        public ModeloDatos()
        {
            contexto = new nofetal2017Entities();
        }
        public List<C_BAS1_PREGUNTA> GetDepartamentos()
        {
            var consulta = from datos in contexto.C_BAS1_PREGUNTA select datos;
            return consulta.ToList();
        }

        public List<COD_DPTO_PREGUNTA> BuscarEmpleadosDepartamento(int deptno)
        {
            var consulta = from datos in contexto.COD_DPTO_PREGUNTA where datos.codDptoPreguntaId == deptno select datos;
            if (consulta.Count() == 0)
            {
                return null;
            }
            else
            {
                return consulta.ToList();
            }
        }
    }
}