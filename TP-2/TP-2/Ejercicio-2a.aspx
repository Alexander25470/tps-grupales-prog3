<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio-2a.aspx.cs" Inherits="TP_2.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblNombre" runat="server" Text="Nombre:"></asp:Label>
            <asp:TextBox ID="txtNombre" runat="server" style="margin-left: 127px"></asp:TextBox>
        </div>
        <p>
            <asp:Label ID="lblApellido" runat="server" Text="Apellido:"></asp:Label>
            <asp:TextBox ID="txtApellido" runat="server" style="margin-left: 127px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblCiudad" runat="server" Text="Ciudad:"></asp:Label>
            <asp:DropDownList ID="DropDownList1" runat="server" style="margin-left: 138px">
                <asp:ListItem Value="Norte">Gral. Pacheco</asp:ListItem>
                <asp:ListItem Value="Oeste">San Miguel</asp:ListItem>
                <asp:ListItem Value="Sur">Boedo</asp:ListItem>
            </asp:DropDownList>
        </p>
        <p>
            <asp:Label ID="lblTemas" runat="server" Text="Temas:"></asp:Label>
        </p>
        <asp:CheckBoxList ID="chbxTemas" runat="server" style="margin-left: 218px; margin-top: 51px" Width="110px">
            <asp:ListItem>Ciencias</asp:ListItem>
            <asp:ListItem>Literatura</asp:ListItem>
            <asp:ListItem>Historia</asp:ListItem>
        </asp:CheckBoxList>
        <asp:Button ID="btnVerResumen" runat="server" style="margin-left: 217px; margin-top: 36px" Text="Ver Resumen" Width="114px" />
    </form>
</body>
</html>
