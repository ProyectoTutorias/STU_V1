using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public static class clsDLogin
    {

        //Metodo que combrueba que el correo proporcionado se encuentra en la base de datos
        public static bool D_autenticarUsuario(string correo)
        {
            using (LogInEntities db = new LogInEntities())//Llamada a base
            {
                try
                {
                    db.DOCENTE.First(c => c.EMAILDOCENTE == correo);

                    //Se encontro el correo en la base de datos
                    return true;
                }

                //No encuentra el correo en la base de datos
                catch
                {
                    return false;
                }
            }
        }

        //Metodo que devuelve toda la informacion del docente para almacenarla en memoria
        public static DOCENTE D_infoDocente(string email)
        {
            using (LogInEntities db = new LogInEntities())//Llamada a base
            {
                try
                {
                    //Busqueda del docente el base
                    return db.DOCENTE.First(c => c.EMAILDOCENTE == email);                                        
                }

                //No encuentra el correo en la base de datos
                catch
                {
                    return new DOCENTE();
                }
            }
        }
    }
}
