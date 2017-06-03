using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;
using CapaNegocio;
namespace CapaNegocio
{
    public class clsNDocente
    {
        clsDDocente objDDocente = new clsDDocente();
        public Boolean consultarDocente(int id)
        {
            return objDDocente.consultarDocente(id);
        }
        public Boolean cargarDocente(DataSet ds, int i)
        {
            return objDDocente.cargarDocentes(ds, i);
        }
        public Boolean actualizarDocente(DataSet ds, int i)
        {
            return objDDocente.actualizarDocentes(ds, i);
        }
    }
}
