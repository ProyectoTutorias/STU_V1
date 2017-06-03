using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public class clsNAdministrador
    {
        //Estanciamiento de nuevos objetos
        clsDAdministrador administrador = new clsDAdministrador();

        /*
         * Metodos para el manejo de Docentes
         */

        //Metodo de ingreso manual de docente
        public bool N_ingresoDocente(int idcarrera, int idrol, string nombre1, string nombre2, string apellido1, string apellido2, string email, string cedula)//Implementar el idcoordinador
        {
            //Crear el nuevo objeto docente
            DOCENTE nuevoDocente = new DOCENTE();

            //Definir los atributos del nuevo docente
            nuevoDocente.ID_CARRERA = idcarrera;
            nuevoDocente.ID_ROL = idrol;
            nuevoDocente.PRIMERNOMBREDOCENTE = nombre1;
            nuevoDocente.SEGUNDONOMBREDOCENTE = nombre2;
            nuevoDocente.PRIMERAPELLIDODOCENTE = apellido1;
            nuevoDocente.SEGUNDOAPELLIDODOCENTE = apellido2;
            nuevoDocente.EMAILDOCENTE = email;
            nuevoDocente.CEDULADOCENTE = cedula;

            //Envio a la capa de datos
            return administrador.D_ingresoDocente(nuevoDocente);

        }
    }
}
