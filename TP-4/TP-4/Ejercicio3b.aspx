<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio3b.aspx.cs" Inherits="TP_4.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblListadodelibros" runat="server" Text="Listado de libros:"></asp:Label>
        </div>
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
        <asp:LinkButton ID="lbConsultarTema" runat="server">Consultar Otro Tema</asp:LinkButton>
    </form>
</body>
</html>
