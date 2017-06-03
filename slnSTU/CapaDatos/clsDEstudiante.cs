using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace CapaDatos
{
    public class clsDEstudiante
    {
        string CEDULAESTUDIANTE = "Cédula";
        string PRIMERNOMBREESTUDIANTE = "Primer Nombre";
        string SEGUNDONOMBREESTUDIANTE = "Segundo Nombre";
        string PRIMERAPELLIDOESTUDIANTE = "	Primer Apellido";
        string SEGUNDOAPELLIDO_ESTUDIANTE = "Segundo Apellido";
        string EMAILESTUDIANTE = "Email";
        string NUMEROMATRICULAESTUDIANTE = "Matrícula";
        public Boolean cargarEstudiantes(DataSet ds, int i)
        {
            MERTutoriasDataContext bd = new MERTutoriasDataContext();
            try
            {
                ESTUDIANTE e1 = new ESTUDIANTE
                {
                    CEDULAESTUDIANTE = (ds.Tables[2].Rows[i][CEDULAESTUDIANTE].ToString()),
                    PRIMERNOMBREESTUDIANTE = ds.Tables[2].Rows[i][PRIMERNOMBREESTUDIANTE].ToString(),
                    SEGUNDONOMBREESTUDIANTE = ds.Tables[2].Rows[i][SEGUNDONOMBREESTUDIANTE].ToString(),
                    PRIMERAPELLIDOESTUDIANTE = ds.Tables[2].Rows[i][PRIMERAPELLIDOESTUDIANTE].ToString(),
                    SEGUNDOAPELLIDO_ESTUDIANTE = ds.Tables[2].Rows[i][SEGUNDOAPELLIDO_ESTUDIANTE].ToString(),
                    EMAILESTUDIANTE = ds.Tables[2].Rows[i][EMAILESTUDIANTE].ToString(),
                    NUMEROMATRICULAESTUDIANTE = ds.Tables[2].Rows[i][NUMEROMATRICULAESTUDIANTE].ToString()
                };
                bd.ESTUDIANTEs.InsertOnSubmit(e1);
                bd.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public Boolean cargarEstudiantes(string Cedula, string primerN, string segundoN, string primerA, string segundoA, string email, string matricula)
        {
            MERTutoriasDataContext bd = new MERTutoriasDataContext();
            try
            {
                ESTUDIANTE e1 = new ESTUDIANTE
                {
                    CEDULAESTUDIANTE = Cedula,
                    PRIMERNOMBREESTUDIANTE = primerN,
                    SEGUNDONOMBREESTUDIANTE = segundoN,
                    PRIMERAPELLIDOESTUDIANTE = primerA,
                    SEGUNDOAPELLIDO_ESTUDIANTE = segundoA,
                    EMAILESTUDIANTE = email,
                    NUMEROMATRICULAESTUDIANTE =matricula
                };
                bd.ESTUDIANTEs.InsertOnSubmit(e1);
                bd.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public Boolean actualizarEstudiante(DataSet ds, int i)
        {
            MERTutoriasDataContext bd = new MERTutoriasDataContext();
            try
            {
                ESTUDIANTE est = bd.ESTUDIANTEs.First(e => e.NUMEROMATRICULAESTUDIANTE == (ds.Tables[2].Rows[i][NUMEROMATRICULAESTUDIANTE].ToString()));
                est.PRIMERNOMBREESTUDIANTE = ds.Tables[2].Rows[i][PRIMERNOMBREESTUDIANTE].ToString();
                est.SEGUNDONOMBREESTUDIANTE = ds.Tables[2].Rows[i][SEGUNDONOMBREESTUDIANTE].ToString();
                est.PRIMERAPELLIDOESTUDIANTE = ds.Tables[2].Rows[i][PRIMERAPELLIDOESTUDIANTE].ToString();
                est.SEGUNDOAPELLIDO_ESTUDIANTE = ds.Tables[2].Rows[i][SEGUNDOAPELLIDO_ESTUDIANTE].ToString();
                est.EMAILESTUDIANTE = ds.Tables[2].Rows[i][EMAILESTUDIANTE].ToString();
                est.NUMEROMATRICULAESTUDIANTE = ds.Tables[2].Rows[i][NUMEROMATRICULAESTUDIANTE].ToString();
                bd.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public Boolean consultarEstudiante(string id)
        {
            try
            {
                MERTutoriasDataContext bd = new MERTutoriasDataContext();
                List<int> lista = (from d in bd.ESTUDIANTEs
                                   where d.NUMEROMATRICULAESTUDIANTE == id
                                   select new { d.ID_ESTUDIANTE }.ID_ESTUDIANTE).ToList();
                if (lista.Count() == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }

        }

    }
}
