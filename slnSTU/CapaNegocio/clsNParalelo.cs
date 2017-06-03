using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;
namespace CapaNegocio
{
    public class clsNParalelo
    {
        clsDParalelo objDParalelo = new clsDParalelo();
        public Boolean consultarParalelo(int id)
        {
            return objDParalelo.consultarParalelo(id);
        }
        public Boolean cargarParalelo(DataSet ds, int i)
        {
            return objDParalelo.cargarParalelo(ds, i);
        }
        public Boolean actualizarParalelo(DataSet ds, int i)
        {
            return objDParalelo.actualizarParalelo(ds, i);
        }
    }
}
