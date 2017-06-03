using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace CapaDatos
{
    public class clsDMateria
    {
        string ID_NIVELMATERIA = "ID_NIVELMATERIA";
        string ID_MATERIA = "ID_MATERIA";
        string NOMBREMATERIA = "NOMBREMATERIA";
        string SIGLAMATERIA = "SIGLAMATERIA";
        public Boolean cargarMateria(DataSet ds, int j)
        {
            MERTutoriasDataContext bd = new MERTutoriasDataContext();
            try
            {
                MATERIA m1 = new MATERIA
                {
                    ID_NIVELMATERIA = int.Parse(ds.Tables[1].Rows[j][ID_NIVELMATERIA].ToString()),
                    ID_MATERIA = int.Parse(ds.Tables[1].Rows[j][ID_MATERIA].ToString()),
                    NOMBREMATERIA = ds.Tables[1].Rows[j][NOMBREMATERIA].ToString(),
                    SIGLAMATERIA = ds.Tables[1].Rows[j][SIGLAMATERIA].ToString(),
                };
                bd.MATERIAs.InsertOnSubmit(m1);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public Boolean actualizarMateria(DataSet ds, int j)
        {
            MERTutoriasDataContext bd = new MERTutoriasDataContext();
            try
            {
                MATERIA mat = bd.MATERIAs.First(e => e.ID_MATERIA == int.Parse(ds.Tables[1].Rows[j][ID_MATERIA].ToString()));
                mat.ID_NIVELMATERIA = int.Parse(ds.Tables[1].Rows[j][ID_NIVELMATERIA].ToString());
                mat.NOMBREMATERIA = ds.Tables[1].Rows[j][NOMBREMATERIA].ToString();
                mat.SIGLAMATERIA = ds.Tables[1].Rows[j][SIGLAMATERIA].ToString();
                bd.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool consultarMateria(int id)
        {
            try
            {
                MERTutoriasDataContext bd = new MERTutoriasDataContext();
                List<int> lista = (from d in bd.MATERIAs
                                   where d.ID_MATERIA == id
                                   select new { d.ID_MATERIA }.ID_MATERIA).ToList();
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
