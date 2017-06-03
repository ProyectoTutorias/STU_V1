<%@ Page Title="" Language="C#" MasterPageFile="~/Administrador/frmPrincipalAdmin.Master" AutoEventWireup="true" CodeBehind="frmManejoDocentes.aspx.cs" Inherits="slnSTU.Administrador.frmManejoDocentes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style6 {
            width: 215px;
        }
        .auto-style7 {
            width: 215px;
            text-align: right;
        }
        .auto-style8 {
            width: 224px;
        }
        .auto-style9 {
            width: 167px;
        }
        .auto-style10 {
            width: 167px;
            text-align: right;
        }
        .auto-style11 {
            text-align: right;
        }
        .auto-style12 {
            width: 224px;
            text-align: right;
        }
        .auto-style13 {
            width: 215px;
            height: 18px;
        }
        .auto-style14 {
            width: 224px;
            height: 18px;
        }
        .auto-style15 {
            width: 167px;
            height: 18px;
        }
        .auto-style16 {
            text-align: left;
        }
        .auto-style17 {
            width: 215px;
            text-align: right;
            height: 25px;
        }
        .auto-style18 {
            width: 224px;
            text-align: right;
            height: 25px;
        }
        .auto-style19 {
            width: 167px;
            text-align: right;
            height: 25px;
        }
        .auto-style20 {
            text-align: right;
            height: 25px;
        }
        .auto-style21 {
            text-align: right;
            height: 116px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="width:100%;">
        <tr>
            <td colspan="4" style="text-align: center">Manejo de Docentes</td>
        </tr>
        <tr>
            <td class="auto-style6">&nbsp;</td>
            <td class="auto-style8">&nbsp;</td>
            <td class="auto-style9">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td colspan="4">Ingreso de nuevo docente</td>
        </tr>
        <tr>
            <td class="auto-style13"></td>
            <td class="auto-style14"></td>
            <td class="auto-style15"></td>
            <td class="auto-style1"></td>
        </tr>
        <tr>
            <td class="auto-style7">Carrera:</td>
            <td colspan="3">
                <asp:DropDownList ID="ddlCarrera" runat="server" DataSourceID="odsCarrera" DataTextField="NOMBRECARRERA" DataValueField="ID_CARRERA" Width="394px">
                </asp:DropDownList>
                <asp:ObjectDataSource ID="odsCarrera" runat="server" SelectMethod="D_consultaCarreras" TypeName="CapaDatos.clsDAdministrador"></asp:ObjectDataSource>
            </td>
        </tr>
        <tr>
            <td class="auto-style7">Rol:</td>
            <td class="auto-style8">
                <asp:DropDownList ID="ddlRol" runat="server" DataSourceID="odsRol" DataTextField="NOMBREROL" DataValueField="ID_ROL">
                </asp:DropDownList>
                <asp:ObjectDataSource ID="odsRol" runat="server" SelectMethod="D_consultaRoles" TypeName="CapaDatos.clsDAdministrador"></asp:ObjectDataSource>
            </td>
            <td class="auto-style9">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style7">Primer Nombre:</td>
            <td class="auto-style8">
                <asp:TextBox ID="txtPrimerNombre" runat="server" Width="100%"></asp:TextBox>
            </td>
            <td class="auto-style10">Segundo Nombre:</td>
            <td>
                <asp:TextBox ID="txtSegundoNombre" runat="server" Width="100%"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style17">Primer Apellido:</td>
            <td class="auto-style18">
                <asp:TextBox ID="txtPrimerApellido" runat="server" Width="100%"></asp:TextBox>
            </td>
            <td class="auto-style19">Segundo Apellido:</td>
            <td class="auto-style20">
                <asp:TextBox ID="txtSegundoApellido" runat="server" Width="100%"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style7">Email:</td>
            <td class="auto-style16" colspan="2">
                <asp:TextBox ID="txtEmail" runat="server" Width="81%"></asp:TextBox>
            </td>
            <td class="auto-style11">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style7">Cedula:</td>
            <td class="auto-style12">
                <asp:TextBox ID="txtCedula" runat="server" Width="100%"></asp:TextBox>
            </td>
            <td class="auto-style10">&nbsp;</td>
            <td class="auto-style11">
                <asp:Button ID="btnIngresar" runat="server" OnClick="btnIngresar_Click" Text="Ingresar" />
            </td>
        </tr>
        <tr>
            <td class="auto-style7">&nbsp;</td>
            <td class="auto-style12">&nbsp;</td>
            <td class="auto-style10">&nbsp;</td>
            <td class="auto-style11">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style21" colspan="4">
                <asp:GridView ID="gvDocentes" runat="server" AutoGenerateColumns="False" DataSourceID="odsDocentes" Width="100%">
                    <Columns>
                        <asp:TemplateField HeaderText="ROL">
                            <ItemTemplate>
                                <asp:DropDownList ID="ddlGVRol" runat="server" DataSourceID="odsGVRol" DataTextField="NOMBREROL" DataValueField="ID_ROL" Enabled="False" SelectedValue='<%# Bind("ID_ROL") %>'>
                                </asp:DropDownList>
                                <asp:ObjectDataSource ID="odsGVRol" runat="server" SelectMethod="D_consultaRoles" TypeName="CapaDatos.clsDAdministrador"></asp:ObjectDataSource>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:BoundField DataField="PRIMERNOMBREDOCENTE" HeaderText="PRIMERNOMBREDOCENTE" SortExpression="PRIMERNOMBREDOCENTE" />
                        <asp:BoundField DataField="SEGUNDONOMBREDOCENTE" HeaderText="SEGUNDONOMBREDOCENTE" SortExpression="SEGUNDONOMBREDOCENTE" />
                        <asp:BoundField DataField="PRIMERAPELLIDODOCENTE" HeaderText="PRIMERAPELLIDODOCENTE" SortExpression="PRIMERAPELLIDODOCENTE" />
                        <asp:BoundField DataField="SEGUNDOAPELLIDODOCENTE" HeaderText="SEGUNDOAPELLIDODOCENTE" SortExpression="SEGUNDOAPELLIDODOCENTE" />
                        <asp:TemplateField HeaderText="CARRERA">
                            <ItemTemplate>
                                <asp:DropDownList ID="ddlGVCarrera" runat="server" DataSourceID="odsGVCarrera" DataTextField="NOMBRECARRERA" DataValueField="ID_CARRERA" Enabled="False" SelectedValue='<%# Bind("ID_CARRERA") %>'>
                                </asp:DropDownList>
                                <asp:ObjectDataSource ID="odsGVCarrera" runat="server" SelectMethod="D_consultaCarreras" TypeName="CapaDatos.clsDAdministrador"></asp:ObjectDataSource>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:BoundField DataField="EMAILDOCENTE" HeaderText="EMAILDOCENTE" SortExpression="EMAILDOCENTE" />
                        <asp:BoundField DataField="CEDULADOCENTE" HeaderText="CEDULADOCENTE" SortExpression="CEDULADOCENTE" />
                        <asp:BoundField DataField="ID_DOCENTE" HeaderText="ID_DOCENTE" SortExpression="ID_DOCENTE" Visible="False" />
                        <asp:BoundField DataField="ID_CARRERA" HeaderText="ID_CARRERA" SortExpression="ID_CARRERA" Visible="False" />
                        <asp:BoundField DataField="ID_COORDINADOR" HeaderText="ID_COORDINADOR" SortExpression="ID_COORDINADOR" Visible="False" />
                        <asp:BoundField DataField="ID_ROL" HeaderText="ID_ROL" SortExpression="ID_ROL" Visible="False" />
                    </Columns>
                </asp:GridView>
            </td>
        </tr>
        <tr>
            <td class="auto-style7">&nbsp;</td>
            <td class="auto-style12">
                <asp:ObjectDataSource ID="odsDocentes" runat="server" SelectMethod="D_consultaDocentes" TypeName="CapaDatos.clsDAdministrador"></asp:ObjectDataSource>
            </td>
            <td class="auto-style10">&nbsp;</td>
            <td class="auto-style11">&nbsp;</td>
        </tr>
    </table>
</asp:Content>
