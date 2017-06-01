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
                    //Se almacena toda la informacion del docente en la varible session
                    Session["Docente"] = Login.N_infoDocente(txtUsuario.Text);


                    //Cast de la variable session para obtener datos del docente
                    DOCENTE docente = (DOCENTE)Session["Docente"];

                    //Seleccion del master page al que va a ser dirigido el usuario
                    switch (docente.ID_ROL)
                    {

                        ///Administrador
                        case 1:
                            
                            break;


                        //Director
                        case 2:
                            break;


                        //Seguimiento
                        case 3:
                            break;


                        //Docente
                        case 4:
                            break;


                        //El docente no tiene asignado un rol
                        default:
                            Response.Redirect("~/frmLogOut.aspx"); ///Pendiente de implementacion
                            break;
                    }
                    
                }
                else
                {
                    //Correo no registrado en el sistema
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Correo proporcionado no se encuentra en el sistema.')", true);
                }
            }
            else
            {
                //Correo o clave incorrecta
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Correo/Contraseña incorrecta(s).')", true);
            }
        }
    }
}