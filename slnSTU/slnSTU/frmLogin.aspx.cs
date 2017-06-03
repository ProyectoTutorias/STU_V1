using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaNegocio;
using unirest_net.http;
using CapaDatos;


namespace slnSTU
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        clsNLogin Login = new clsNLogin();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            HttpResponse<string> respuesta = Unirest.get("https://outlook.office365.com/api/v1.0/me/").basicAuth(txtUsuario.Text, txtContrasena.Text).asJson<string>();

            //Autenticacion de Windows
            if (respuesta.Code == 200)
            {
                //Autenticacion del sistema
                if (Login.N_autenticarUsuario(txtUsuario.Text))
                {
                    //Se carga la informacion del docente
                    DOCENTE docente = Login.N_infoDocente(txtUsuario.Text);                    


                    //Se almancena informacion importante en la varibale cast
                    Session["Docente"] = docente;
                    Session["Rol"] = docente.ID_ROL;


                    //Seleccionar ruta a la cual sera dirigido el docente
                    string ruta = Login.N_rutaMaster(docente);

                    //Redireccionamiento al master page
                    Response.Redirect(ruta);                    
                    
                }
                else
                {
                    //Correo no registrado en el sistema
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Correo proporcionado no se encuentra en el sistema.')", true);
                    txtContrasena.Text = ""; //Limpia el campo de contrasenia
                }
            }
            else
            {
                //Correo o clave incorrecta
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Correo/Contraseña incorrecta(s).')", true);
                txtContrasena.Text = ""; //Limpia el campo de contrasenia
            }
        }
    }
}