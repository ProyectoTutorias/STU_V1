using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaNegocio;
using CapaDatos;

namespace slnSTU.Administrador
{
    public partial class frmManejoDocentes : System.Web.UI.Page
    {
        //Objetos necesarios
        clsNAdministrador administrador = new clsNAdministrador();

        protected void Page_Load(object sender, EventArgs e)
        {
            //Comprobar el rol del usuario
            if ((int)Session["Rol"] != 2)
            {
                Response.Redirect("frmError.aspx");//Aun no implementado
            }
        }

        
        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            //Metodo de capa negocio que comprueba si se ingreso correctamente el docente
            if (administrador.N_ingresoDocente(int.Parse(ddlCarrera.SelectedValue), int.Parse(ddlRol.SelectedValue), txtPrimerNombre.Text, txtSegundoNombre.Text, txtPrimerApellido.Text, txtSegundoApellido.Text, txtEmail.Text, txtCedula.Text))
            {
                //Mensaje de ingreso correcto y eliminacion de los campos
                Response.Write(@"<script>alert('Ingreso Correcto');setTimeout(function(){window.location = '" + Request.RawUrl + @"';}, 10);</script>");
            }
            else
            {
                //Ingreso incorrecto
                Response.Write("<script>window.alert('Ingreso incorrecto');</script>");
            }
        }
    }
}