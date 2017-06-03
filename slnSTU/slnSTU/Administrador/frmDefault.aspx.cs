using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaDatos;

namespace slnSTU.Administrador
{
    public partial class frmAdminInicio : System.Web.UI.Page
    {
        //Variables globales usadas por toda la pagina
        clsDDocente funcionesDocente = new clsDDocente();
        DOCENTE docente = new DOCENTE();


        protected void Page_Load(object sender, EventArgs e)
        {
            //Comprobar el rol del usuario
            if ((int)Session["Rol"] != 2)
            {
                Response.Redirect("frmError.aspx");//Aun no implementado
            }
            docente = (DOCENTE)Session["docente"];
            gvParalelos.DataSource = funcionesDocente.D_consultarParalelos(docente);
            gvParalelos.DataBind();
        }
    }
}