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

        public string N_rutaMaster(DOCENTE docente)
        {
            switch (docente.ID_ROL)
            {

                ///Administrador
                case 1:
                    return "Administrador/frmDefault.aspx";


                //Director
                case 2:
                    return "Administrador/frmDefault.aspx";


                //Seguimiento
                case 3:
                    return "Administrador/frmDefault.aspx";


                //Docente
                case 4:
                    return "Docente/frmDefault.aspx";


                //El docente no tiene asignado un rol
                default:
                    return "frmError.aspx"; ///Pendiente de implementacion

            }
        }
    }
}
