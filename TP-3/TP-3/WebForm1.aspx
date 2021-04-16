<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="TP_3.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblLocalidad" runat="server" Font-Bold="True" Text="Localidad"></asp:Label>
        </div>
        <p>
            <asp:Label ID="Label1" runat="server" Text="Nombre de la localidad: "></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server" style="margin-left: 91px; margin-bottom: 0px" Width="148px"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="btnGuardarLocalidad" runat="server" style="margin-left: 242px; margin-bottom: 0px" Text="Guardar Cambios" Width="132px" />
        </p>
        <p>
            <asp:Label ID="Label2" runat="server" Font-Bold="True" Text="Usuarios"></asp:Label>
        </p>
        <p>
            <asp:Label ID="Label3" runat="server" Text="Nombre Usuario: "></asp:Label>
            <asp:TextBox ID="txtNombreUsuario" runat="server" style="margin-left: 84px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label4" runat="server" Text="Contraseña:"></asp:Label>
            <asp:TextBox ID="txtContraseña" runat="server" style="margin-left: 120px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label5" runat="server" Text="Repetir Contraseña:"></asp:Label>
            <asp:TextBox ID="txtRepetirContraseña" runat="server" style="margin-left: 74px"></asp:TextBox>
        </p>
        <asp:Label ID="Label6" runat="server" Text="Correo Electronico:"></asp:Label>
        <asp:TextBox ID="txtCorreoElectronico" runat="server" style="margin-left: 74px"></asp:TextBox>
        <p>
            <asp:Label ID="Label7" runat="server" Text="CP:"></asp:Label>
            <asp:TextBox ID="txtCp" runat="server" style="margin-left: 167px"></asp:TextBox>
        </p>
        <asp:Label ID="Label8" runat="server" Text="Localidades:"></asp:Label>
        <asp:DropDownList ID="ddlLocalidades" runat="server" style="margin-left: 113px" Width="133px">
        </asp:DropDownList>
        <br />
        <br />
        <asp:Button ID="btnGuardarUsuario" runat="server" style="margin-left: 185px" Text="Guardar Usuario" Width="148px" />
        <br />
        <br />
        <asp:Button ID="btnInicio" runat="server" Text="Ir a inicio.aspx" Width="103px" />
    </form>
</body>
</html>
