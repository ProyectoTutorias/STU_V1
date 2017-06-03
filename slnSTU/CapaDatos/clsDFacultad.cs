using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace CapaDatos
{
    public class clsDFacultad
    {
        string ID_FACULTAD = "Código facultad";
        string NOMBREFACULTAD = "Nombre";
        public Boolean cargarFacultad(DataSet ds, int j)
        {
            MERTutoriasDataContext bd = new MERTutoriasDataContext();
            try
            {
                FACULTAD p1 = new FACULTAD
                {
                    NOMBREFACULTAD = ds.Tables[0].Rows[j][NOMBREFACULTAD].ToString()
                };
                bd.FACULTADs.InsertOnSubmit(p1);
                bd.SubmitChanges();
                return true;
            }
            catch
            {
                return false; 
            }
        }
        
        public Boolean actualizarFacultad(DataSet ds, int j)
        {
            MERTutoriasDataContext bd = new MERTutoriasDataContext();
            try
            {
                FACULTAD par = bd.FACULTADs.First(e => e.ID_FACULTAD == int.Parse(ds.Tables[0].Rows[j][ID_FACULTAD].ToString()));
                par.NOMBREFACULTAD = ds.Tables[0].Rows[j][NOMBREFACULTAD].ToString();
                bd.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public Boolean consultarFacultad(string nombre)
        {
            try
            {
                MERTutoriasDataContext bd = new MERTutoriasDataContext();
                List<int> lista = (from d in bd.FACULTADs
                                   where d.NOMBREFACULTAD == nombre
                                   select new { d.ID_FACULTAD }.ID_FACULTAD).ToList();
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
