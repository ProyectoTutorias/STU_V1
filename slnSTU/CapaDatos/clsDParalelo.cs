using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace CapaDatos
{
    public class clsDParalelo
    {
        string ID_PARALELO = "ID_PARALELO";
        string NOMBREPARALELO = "NOMBREPARALELO";
        public Boolean cargarParalelo(DataSet ds, int j)
        {
            MERTutoriasDataContext bd = new MERTutoriasDataContext();
            try
            {
                PARALELO p1 = new PARALELO
                {
                    ID_PARALELO = int.Parse(ds.Tables[1].Rows[j][ID_PARALELO].ToString()),
                    NOMBREPARALELO = ds.Tables[1].Rows[j][NOMBREPARALELO].ToString(),
                };
                bd.PARALELOs.InsertOnSubmit(p1);
                bd.SubmitChanges();

                return true;
            }
            catch
            {
                
                return false;
            }
        }
        public Boolean actualizarParalelo(DataSet ds, int j)
        {
            MERTutoriasDataContext bd = new MERTutoriasDataContext();
            try
            {
                PARALELO par = bd.PARALELOs.First(e => e.ID_PARALELO == int.Parse(ds.Tables[1].Rows[j][ID_PARALELO].ToString()));
                par.NOMBREPARALELO = ds.Tables[1].Rows[j][NOMBREPARALELO].ToString();
                bd.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public Boolean consultarParalelo(int id)
        {
            try
            {
                MERTutoriasDataContext bd = new MERTutoriasDataContext();
                List<int> lista = (from d in bd.PARALELOs
                                   where d.ID_PARALELO == id
                                   select new { d.ID_PARALELO }.ID_PARALELO).ToList();
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
