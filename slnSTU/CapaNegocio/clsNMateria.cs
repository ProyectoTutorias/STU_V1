using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;
namespace CapaNegocio
{
    public class clsNMateria
    {
        clsDMateria objDMateria = new clsDMateria();
        public Boolean consultarMateria(int id)
        {
            return objDMateria.consultarMateria(id);
        }
        public Boolean cargarMateria(DataSet ds, int i)
        {
            return objDMateria.cargarMateria(ds, i);
        }
        public Boolean actualizarMateria(DataSet ds, int i)
        {
            return objDMateria.actualizarMateria(ds, i);
        }
    }
}
