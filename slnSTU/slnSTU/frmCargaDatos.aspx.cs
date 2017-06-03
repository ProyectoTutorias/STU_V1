using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
//using Excel;
using System.Data.OleDb;
using System.Data;
using CapaNegocio;
namespace slnSTU
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        clsNDocente objNDocente = new clsNDocente();
        clsNEstudiante objNEstudiante = new clsNEstudiante();
        clsNMateria objNMateria = new clsNMateria();
        clsNParalelo objNParalelo = new clsNParalelo();
        clsNFacultad objNFacultad = new clsNFacultad();
        clsNCarrera objNCarrera = new clsNCarrera();

        string ID_DOCENTE = "ID_DOCENTE";
        string PRIMERNOMBREDOCENTE = "PRIMERNOMBREDOCENTE";
        string SEGUNDONOMBREDOCENTE = "SEGUNDONOMBREDOCENTE";
        string PRIMERAPELLIDODOCENTE = "PRIMERAPELLIDODOCENTE";
        string SEGUNDOAPELLIDODOCENTE = "SEGUNDOAPELLIDODOCENTE";
        string EMAILDOCENTE = "EMAILDOCENTE";
        string CEDULADOCENTE = "CEDULADOCENTE";

        string CODIGOFACULTAD = "Código facultad";
        string CODIGOCARRERA = "Código carrera";
        string NOMBRECARRERA = "Carrera";
        string CODIGOAREA = "Código área";

        string CEDULAESTUDIANTE = "Cédula";
        string PRIMERNOMBREESTUDIANTE = "Primer Nombre";
        string SEGUNDONOMBREESTUDIANTE = "Segundo Nombre";
        string PRIMERAPELLIDOESTUDIANTE = "Apellido";
        string SEGUNDOAPELLIDO_ESTUDIANTE = "Segundo Apellido";
        string EMAILESTUDIANTE = "Email";
        string NUMEROMATRICULAESTUDIANTE = "Matrícula";

        string ID_AREACONOCIMIENTO = "ID_AREACONOCIMIENTO";
        string ID_MATERIA = "ID_MATERIA";
        string NOMBREMATERIA = "NOMBREMATERIA";
        string SIGLAMATERIA = "SIGLAMATERIA";
        string CREDITOSMATERIA = "CREDITOSMATERIA";

        string ID_PARALELO = "ID_PARALELO";
        string NOMBREPARALELO = "NOMBREPARALELO";

        string ID_FACULTAD = "Código facultad";
        string NOMBREFACULTAD = "Nombre";
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnImportar_Click(object sender, EventArgs e)
        {
            bool fileOK = false;
            string path = "";
            try
            {
                if (txtRuta.HasFile)
                {

                    path = Server.MapPath("");
                    String fileExtension = Path.GetExtension(txtRuta.PostedFile.FileName).ToLower();

                    String[] allowedExtensions = { ".xlsx" };
                    for (int i = 0; i < allowedExtensions.Length; i++)
                    {
                        if (fileExtension == allowedExtensions[i])
                        {
                            fileOK = true;
                        }
                    }
                }

                if (fileOK)
                {
                    try
                    {
                        txtRuta.PostedFile.SaveAs(path + "\\" + txtRuta.FileName);
                    }
                    catch
                    {
                    }
                }


                string conexion = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + path + "\\" + txtRuta.FileName + ";Extended Properties=\"Excel 8.0;HDR = Yes\"";

                OleDbConnection conector = default(OleDbConnection);
                conector = new OleDbConnection(conexion);
                conector.Open();

                OleDbCommand consulta = default(OleDbCommand);
                OleDbCommand consulta2 = default(OleDbCommand);
                OleDbCommand consulta3 = default(OleDbCommand);

                consulta = new OleDbCommand("select * from [Facultades$]", conector);
                consulta2 = new OleDbCommand("select * from [Carreras2$]", conector);
                consulta3 = new OleDbCommand("select * from [Estudiantes$]", conector);


                OleDbDataAdapter adaptador = new OleDbDataAdapter();
                OleDbDataAdapter adaptador2 = new OleDbDataAdapter();
                OleDbDataAdapter adaptador3 = new OleDbDataAdapter();

                adaptador.SelectCommand = consulta;
                adaptador2.SelectCommand = consulta2;
                adaptador3.SelectCommand = consulta3;

                DataSet ds = new DataSet();

                adaptador.Fill(ds, "Primera");
                adaptador2.Fill(ds, "Segunda");
                adaptador3.Fill(ds, "Tercera");

                gvPrueba.DataSource = ds.Tables[0];
                gvPrueba.DataBind();
                gvPrueba2.DataSource = ds.Tables[1];
                gvPrueba2.DataBind();
                gvPrueba3.DataSource = ds.Tables[2];
                gvPrueba3.DataBind();
                try
                {
                    for (int i = 0; i <= ds.Tables[0].Rows.Count; i++)
                    {
                        if (objNFacultad.consultarFacultad((ds.Tables[0].Rows[i][NOMBREFACULTAD].ToString())) == true)
                        {
                            objNFacultad.cargarFacultad(ds, i);
                        }
                        else
                        {
                            //objNFacultad.actualizarFacultad(ds, i);
                        }

                    }
                }
                catch
                {

                }
                try
                {
                    for (int j = 0; j <= ds.Tables[1].Rows.Count; j++)
                    {
                        if (objNCarrera.consultarCarrera(ds, j)== true)
                        {
                            objNCarrera.cargarCarrera(ds, j);
                        }
                        //else
                        {
                            // objNMateria.actualizarMateria(ds, j);
                        }

                    }
                }
                catch
                {

                }
                //try
                {
                    for (int j = 0; j <= ds.Tables[1].Rows.Count; j++)
                    {
                       
                        if (objNCarrera.consultarCarrera(ds, j) == true)
                        {
                            objNCarrera.cargarCarrera(ds, j);
                        }
                        //else
                        {
                            // objNMateria.actualizarMateria(ds, j);
                        }
                    }
                }
                //catch
                {

                }
                
                try
                {
                    for (int i = 0; i <= ds.Tables[2].Rows.Count; i++)
                    {
                        string CEDULAESTUDIANTE1 = (ds.Tables[2].Rows[i][CEDULAESTUDIANTE].ToString());
                        string PRIMERNOMBREESTUDIANTE1 = ds.Tables[2].Rows[i][PRIMERNOMBREESTUDIANTE].ToString();
                        string SEGUNDONOMBREESTUDIANTE1 = ds.Tables[2].Rows[i][SEGUNDONOMBREESTUDIANTE].ToString();
                        string PRIMERAPELLIDOESTUDIANTE1 = ds.Tables[2].Rows[i][PRIMERAPELLIDOESTUDIANTE].ToString(); ;
                        string SEGUNDOAPELLIDO_ESTUDIANTE1 = ds.Tables[2].Rows[i][SEGUNDOAPELLIDO_ESTUDIANTE].ToString();
                        string EMAILESTUDIANTE1 = ds.Tables[2].Rows[i][EMAILESTUDIANTE].ToString();
                        string NUMEROMATRICULAESTUDIANTE1 = ds.Tables[2].Rows[i][NUMEROMATRICULAESTUDIANTE].ToString();
                        if (objNEstudiante.consultarEstudiante((ds.Tables[2].Rows[i][NUMEROMATRICULAESTUDIANTE].ToString())) == true)
                        {
                            objNEstudiante.cargarEstudiante(CEDULAESTUDIANTE1,PRIMERNOMBREESTUDIANTE1,SEGUNDONOMBREESTUDIANTE1,PRIMERAPELLIDOESTUDIANTE1, SEGUNDOAPELLIDO_ESTUDIANTE1,EMAILESTUDIANTE1,NUMEROMATRICULAESTUDIANTE1);
                        }
                        //else
                        {
                            // objNMateria.actualizarMateria(ds, j);
                        }
                    }
                }
                catch
                {

                }
                conector.Close();                

            }
            catch
            {

            }
        }
    }
}