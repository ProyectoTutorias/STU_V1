using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;
namespace CapaDatos
{
    public class clsDDocente
    {
        string ID_DOCENTE = "ID_DOCENTE";
        string PRIMERNOMBREDOCENTE = "PRIMERNOMBREDOCENTE";
        string SEGUNDONOMBREDOCENTE = "SEGUNDONOMBREDOCENTE";
        string PRIMERAPELLIDODOCENTE = "PRIMERAPELLIDODOCENTE";
        string SEGUNDOAPELLIDODOCENTE = "SEGUNDOAPELLIDODOCENTE";
        string EMAILDOCENTE = "EMAILDOCENTE";
        string CEDULADOCENTE = "CEDULADOCENTE";
        public Boolean actualizarDocentes(DataSet ds, int i)
        {
            MERTutoriasDataContext bd = new MERTutoriasDataContext();
            try
            {
                DOCENTE doc = bd.DOCENTEs.First(e => e.ID_DOCENTE == int.Parse(ds.Tables[0].Rows[i][ID_DOCENTE].ToString()));
                doc.PRIMERNOMBREDOCENTE = ds.Tables[0].Rows[i][PRIMERNOMBREDOCENTE].ToString();
                doc.SEGUNDONOMBREDOCENTE = ds.Tables[0].Rows[i][SEGUNDONOMBREDOCENTE].ToString();
                doc.PRIMERAPELLIDODOCENTE = ds.Tables[0].Rows[i][PRIMERAPELLIDODOCENTE].ToString();
                doc.SEGUNDOAPELLIDODOCENTE = ds.Tables[0].Rows[i][SEGUNDOAPELLIDODOCENTE].ToString();
                doc.EMAILDOCENTE = ds.Tables[0].Rows[i][EMAILDOCENTE].ToString();
                doc.CEDULADOCENTE = ds.Tables[0].Rows[i][CEDULADOCENTE].ToString();
                bd.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }

        }
            public Boolean cargarDocentes(DataSet ds, int i)
        {
            MERTutoriasDataContext bd = new MERTutoriasDataContext();
            try
            {
                DOCENTE d1 = new DOCENTE
                {
                    ID_DOCENTE = int.Parse(ds.Tables[0].Rows[i][ID_DOCENTE].ToString()),
                    PRIMERNOMBREDOCENTE = ds.Tables[0].Rows[i][PRIMERNOMBREDOCENTE].ToString(),
                    SEGUNDONOMBREDOCENTE = ds.Tables[0].Rows[i][SEGUNDONOMBREDOCENTE].ToString(),
                    PRIMERAPELLIDODOCENTE = ds.Tables[0].Rows[i][PRIMERAPELLIDODOCENTE].ToString(),
                    SEGUNDOAPELLIDODOCENTE = ds.Tables[0].Rows[i][SEGUNDOAPELLIDODOCENTE].ToString(),
                    EMAILDOCENTE = ds.Tables[0].Rows[i][EMAILDOCENTE].ToString(),
                    CEDULADOCENTE = ds.Tables[0].Rows[i][CEDULADOCENTE].ToString()
                };
                bd.DOCENTEs.InsertOnSubmit(d1);
                bd.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public Boolean consultarDocente(int id)
        {
            try
            {
                MERTutoriasDataContext bd = new MERTutoriasDataContext();
                List<int> lista = (from d in bd.DOCENTEs
                                   where d.ID_DOCENTE == id
                                   select new { d.ID_DOCENTE }.ID_DOCENTE).ToList();
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
