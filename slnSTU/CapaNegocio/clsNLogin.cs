using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public class clsNLogin
    {
        public bool N_autenticarUsuario(string correo)
        {
            //Metodo de filtro
            string email = correo;
            return clsDLogin.D_autenticarUsuario(email);
        }

        
        public DOCENTE N_infoDocente(string correo)
        {
            //Metodo Filtro
            //Variables locales
            DOCENTE docente = new DOCENTE();
            string email = correo;

            docente = clsDLogin.D_infoDocente(email);

            return docente;
            
        }
    }
}
