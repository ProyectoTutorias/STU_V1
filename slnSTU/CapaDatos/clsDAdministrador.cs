using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class clsDAdministrador
    {
        /*
         * Metodos para el manejo de Docentes
         */
         
         //Metodo de ingreso manual de docente
         public bool D_ingresoDocente(DOCENTE nuevoDocente)
        {
            using (LogInEntities db = new LogInEntities())
            {
                try
                {
                    db.DOCENTE.Add(nuevoDocente);
                    db.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }

        //Metodo de consulta de docentes
        public List<DOCENTE> D_consultaDocentes()
        {
            using (LogInEntities db = new LogInEntities())
            {
                return db.DOCENTE.ToList();
            }
        }




        /*
         * Metodos miselaneos
         */

        //Metodo para obtener la lista de roles
        public List<ROL> D_consultaRoles()
        {
            using (LogInEntities db = new LogInEntities())
            {
                return db.ROL.ToList();
            }
        }


        //Metodo para obtener la lista de carreras
        public List<CARRERA> D_consultaCarreras()
        {
            using (LogInEntities db = new LogInEntities())
            {
                return db.CARRERA.ToList();
            }
        }
    }
}
