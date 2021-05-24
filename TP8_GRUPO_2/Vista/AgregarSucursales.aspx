<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AgregarSucursales.aspx.cs" Inherits="Vista.AgregarSucursales" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 419px;
        }
        .auto-style3 {
            width: 376px;
        }
        .auto-style4 {
            width: 376px;
            text-align: center;
        }
        .auto-style5 {
            width: 376px;
            text-align: left;
        }
        .auto-style6 {
            width: 419px;
            text-align: right;
        }
        .auto-style7 {
            width: 419px;
            text-align: center;
        }
        .auto-style8 {
            width: 419px;
            text-align: right;
            height: 25px;
        }
        .auto-style9 {
            width: 376px;
            height: 25px;
        }
        .auto-style10 {
            height: 25px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">
                        <asp:HyperLink ID="link_agregarSucursal" runat="server">Agregar Sucursal</asp:HyperLink>
                    </td>
                    <td class="auto-style3">
                        <asp:HyperLink ID="link_listarSucursales" runat="server">Listado de Sucursales</asp:HyperLink>
                    </td>
                    <td>
                        <asp:HyperLink ID="link_EliminarSucursal" runat="server">Eliminar Sucursal</asp:HyperLink>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2"><strong>GRUPO N 2</strong></td>
                    <td class="auto-style3">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style7"><strong>Agregar sucursal</strong></td>
                    <td class="auto-style5">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style6">Nombre Sucursal:</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="txt_NombreSucursal" runat="server" Width="305px"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style6">Descripcion:</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="txt_Descripcion" runat="server" Height="72px" Width="303px"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style6">Provincia:</td>
                    <td class="auto-style3">
                        <asp:DropDownList ID="ddl_Provincia" runat="server" Height="17px" Width="309px">
                        </asp:DropDownList>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style8">Direccion:</td>
                    <td class="auto-style9">
                        <asp:TextBox ID="txt_Direccion" runat="server" Width="302px"></asp:TextBox>
                    </td>
                    <td class="auto-style10"></td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style4">
                        <asp:Button ID="btn_Aceptar" runat="server" Text="Aceptar" Width="164px" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
