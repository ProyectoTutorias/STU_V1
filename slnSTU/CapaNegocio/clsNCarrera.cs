using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class clsNCarrera
    {
        clsDCarrera objDCarrera = new clsDCarrera();
        public Boolean consultarCarrera(DataSet ds, int j)
        {
            return objDCarrera.consultarCarrera(ds,j);
        }
        public Boolean cargarCarrera(DataSet ds, int i)
        {
            return objDCarrera.cargarCarreras(ds, i);
        }
        public Boolean actualizarCarrera(DataSet ds, int i)
        {
            return objDCarrera.actualizarCarrera(ds, i);
        }
    }
}
