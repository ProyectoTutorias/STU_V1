using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;
namespace CapaNegocio
{
    public class clsNEstudiante
    {
        clsDEstudiante objDEstudiante = new clsDEstudiante();
        public Boolean consultarEstudiante(string id)
        {
            return objDEstudiante.consultarEstudiante(id);
        }
        public Boolean cargarEstudiante(DataSet ds, int i)
        {
            return objDEstudiante.cargarEstudiantes(ds, i);
        }
        public Boolean cargarEstudiante(string Cedula, string primerN, string segundoN, string primerA, string segundoA, string email, string matricula)
        {
            return objDEstudiante.cargarEstudiantes(Cedula, primerN, segundoN, primerA, segundoA,email, matricula);
        }
        public Boolean actualizarEstudiante(DataSet ds, int i)
        {
            return objDEstudiante.actualizarEstudiante(ds, i);
        }
    }
}
