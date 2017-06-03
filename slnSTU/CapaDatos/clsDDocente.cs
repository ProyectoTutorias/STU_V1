using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class clsDDocente
    {
        //Metodo que obtiene los paralelos con sus respectivas materias de los docentes
        public object D_consultarParalelos(DOCENTE docente)
        {
            using (LogInEntities db = new LogInEntities())
            {
                try
                {
                    //Busqueda de paralelos en la tabla de registro academico por el id del docente
                    var paralelos = from p in db.REGISTROACADEMICO
                                    where p.ID_DOCENTE == docente.ID_DOCENTE
                                    select new
                                    {
                                        //Lista de campos que se presentaran en el grid view
                                        SIGLA = p.MATERIA.SIGLAMATERIA,
                                        MATERIA = p.MATERIA.NOMBREMATERIA,
                                        PARALELO = p.PARALELO.NOMBREPARALELO
                                    };

                    return paralelos.Distinct().ToList();
                }
                catch
                {
                    return new object();
                }
            }
        }
    }
}
