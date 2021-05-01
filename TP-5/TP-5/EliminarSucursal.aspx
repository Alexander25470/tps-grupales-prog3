<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EliminarSucursal.aspx.cs" Inherits="TP_5.EliminarSucursal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 201px;
        }
        .auto-style3 {
            width: 228px;
        }
        .auto-style4 {
            margin-left: 36px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">
                        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Ejercicio-1.aspx">Agregar Sucursal</asp:HyperLink>
                    </td>
                    <td class="auto-style3">
                        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/ListarSucursales.aspx">Listado de sucursales</asp:HyperLink>
                    </td>
                    <td>
                        <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/EliminarSucursal.aspx">Eliminar Sucursal</asp:HyperLink>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label1" runat="server" Font-Bold="True" Text="Eliminar Sucursales"></asp:Label>
                    </td>
                    <td class="auto-style3">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label2" runat="server" Text="Ingrese ID Sucursal:"></asp:Label>
                    </td>
                    <td class="auto-style3">
                        <asp:TextBox ID="TextBox1" runat="server" Width="231px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Button ID="btnEliminar" runat="server" CssClass="auto-style4" Text="Eliminar" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="lblSucursalEliminado" runat="server"></asp:Label>
                    </td>
                    <td class="auto-style3">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
