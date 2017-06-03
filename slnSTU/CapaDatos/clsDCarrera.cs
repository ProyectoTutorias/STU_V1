using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace CapaDatos
{
    public class clsDCarrera
    {
        string CODIGOFACULTAD = "Código facultad";
        string CODIGOCARRERA = "Código carrera";
        string NOMBRECARRERA = "Carrera";
        string CODIGOAREA = "Código área";
        public Boolean cargarCarreras(DataSet ds, int i)
        {
            MERTutoriasDataContext bd = new MERTutoriasDataContext();
            //try
            {
                CARRERA e1 = new CARRERA
                {
                    ID_FACULTAD = 38,
                    CODIGOAREACARRERA = int.Parse(ds.Tables[1].Rows[i][CODIGOAREA].ToString()),
                    CODIGOCARRERA = ds.Tables[1].Rows[i][CODIGOCARRERA].ToString(),
                    NOMBRECARRERA= ds.Tables[1].Rows[i][NOMBRECARRERA].ToString(),
                    CODIGOFACULTADAREACARRERA= ds.Tables[1].Rows[i][CODIGOFACULTAD].ToString()+"/"+ds.Tables[1].Rows[i][CODIGOAREA].ToString()+ "/" + ds.Tables[1].Rows[i][CODIGOCARRERA].ToString()
                };
                bd.CARRERAs.InsertOnSubmit(e1);
                bd.SubmitChanges();
                return true;
            }
            //catch
            {
                return false;
            }
        }
        public Boolean actualizarCarrera(DataSet ds, int i)
        {
            MERTutoriasDataContext bd = new MERTutoriasDataContext();
            try
            {
                
                bd.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public Boolean consultarCarrera(DataSet ds, int i)
        {
            try
            {
                MERTutoriasDataContext bd = new MERTutoriasDataContext();
                List<int> lista = (from d in bd.CARRERAs
                                   where d.CODIGOFACULTADAREACARRERA == ds.Tables[1].Rows[i][CODIGOFACULTAD].ToString() + "/" + ds.Tables[1].Rows[i][CODIGOAREA].ToString() + "/" + ds.Tables[1].Rows[i][CODIGOCARRERA].ToString()
                                   select new { d.ID_CARRERA }.ID_CARRERA).ToList();
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
