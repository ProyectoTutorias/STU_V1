using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;
namespace CapaNegocio
{
    public class clsNFacultad
    {
        clsDFacultad objDFacultad = new clsDFacultad();
        public Boolean consultarFacultad(string nombre)
        {
            return objDFacultad.consultarFacultad(nombre);
        }
        public Boolean cargarFacultad(DataSet ds, int i)
        {
            return objDFacultad.cargarFacultad(ds, i);
        }
        
        public Boolean actualizarFacultad(DataSet ds, int i)
        {
            return objDFacultad.actualizarFacultad(ds, i);
        }
    }
}
