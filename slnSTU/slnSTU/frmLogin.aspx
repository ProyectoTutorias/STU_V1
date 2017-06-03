<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmLogin.aspx.cs" Inherits="slnSTU.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Tutorias | Login</title>
    <link rel="icon" type="image/gif/png" href="Recursos/IMG/logo_homeRed.png"/>
    <!-- Adaptable para dispositivos Moviles  -->
    <meta name="viewport" content="with=device-width,user-scalable=no,
        initial-scale=1.0, maximum-scale = 1" />
    <!-- Referencia de Fuentes y Hojas de CSS  -->
    <link href="https://fonts.googleapis.com/css?family=Nunito+Sans:300i,400,600,700" rel="stylesheet" />
    <link href="Recursos/CSS/login.css" rel="stylesheet" />
    <link href="Recursos/CSS/font-awesome.min.css" rel="stylesheet" />
    <style type="text/css">
        .auto-style1 {
            width: 199px;
        }
        .auto-style2 {
            width: 347px;
        }
        .auto-style5 {
            width: 347px;
            text-align: center;
        }
        .auto-style6 {
            height: 8px;
        }
        .auto-style7 {
            width: 199px;
            text-align: right;
            height: 8px;
        }
        .auto-style8 {
            width: 347px;
            text-align: right;
            height: 8px;
        }
        .auto-style10 {
            width: 199px;
            height: 3px;
        }
        .auto-style11 {
            width: 347px;
            height: 3px;
        }
        .auto-style12 {
            height: 3px;
        }
        .auto-style16 {
            height: 55px;
        }
        .auto-style17 {
            width: 199px;
            text-align: right;
            height: 55px;
        }
        .auto-style18 {
            width: 347px;
            text-align: right;
            height: 55px;
        }
        .auto-style19 {
            height: 25px;
        }
        .auto-style20 {
            width: 199px;
            text-align: right;
            height: 25px;
        }
        .auto-style21 {
            width: 347px;
            text-align: right;
            height: 25px;
        }
        .auto-style22 {
            height: 3px;
            width: 110px;
        }
        .auto-style23 {
            height: 55px;
            width: 110px;
        }
        .auto-style24 {
            height: 8px;
            width: 110px;
        }
        .auto-style25 {
            height: 25px;
            width: 110px;
        }
        .auto-style26 {
            width: 110px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <header class="menu">
            <div class="logo">
                <a href="frmLogin.aspx"><img src="Recursos/IMG/logo_home.png" /></a>
            </div>
            <div class="enlaces">
                <a><i class="fa fa-users" aria-hidden="true"></i></a>
            </div>
        </header>

        <table class="main" style="width:100%;">
            <tr>
                <td class="auto-style22"></td>
                <td class="auto-style10"></td>
                <td class="auto-style11"></td>
                <td class="auto-style12"></td>
                <td class="auto-style12"></td>
            </tr>
            <tr>
                <td class="auto-style23"></td>
                <td class="auto-style17">Usuario:</td>
                <td class="auto-style18">
                    <asp:TextBox ID="txtUsuario" runat="server" TabIndex="1" Width="95%"></asp:TextBox>
                </td>
                <td class="auto-style16"></td>
                <td class="auto-style16"></td>
            </tr>
            <tr>
                <td class="auto-style24"></td>
                <td class="auto-style7"></td>
                <td class="auto-style8"></td>
                <td class="auto-style6"></td>
                <td class="auto-style6"></td>
            </tr>
            <tr>
                <td class="auto-style23"></td>
                <td class="auto-style17">Contraseña:</td>
                <td class="auto-style18">
                    <asp:TextBox ID="txtContrasena" runat="server" TabIndex="2" Width="95%" TextMode="Password"></asp:TextBox>
                </td>
                <td class="auto-style16"></td>
                <td class="auto-style16"></td>
            </tr>
            <tr>
                <td class="auto-style25"></td>
                <td class="auto-style20"></td>
                <td class="auto-style21"></td>
                <td class="auto-style19"></td>
                <td class="auto-style19"></td>
            </tr>
            <tr>
                <td class="auto-style26">&nbsp;</td>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style5">
                    <asp:Button ID="btnIngresar" runat="server" OnClick="btnIngresar_Click" TabIndex="3" Text="Ingresar" Width="45%" />
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style26">&nbsp;</td>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>

    </form>
        </body>
</html>
