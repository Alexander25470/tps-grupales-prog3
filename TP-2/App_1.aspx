<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="App_1.aspx.cs" Inherits="AppWeb_Emi.App_1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        &nbsp;&nbsp;&nbsp; Ingrese nombre del producto:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="Txt_NombreProduct1" runat="server" Width="125px"></asp:TextBox>
&nbsp;&nbsp;&nbsp; Cantidad:&nbsp;&nbsp;
            <asp:TextBox ID="txt_Cant1" runat="server"></asp:TextBox>
            <br />
            <br />
&nbsp;&nbsp; Ingrese nombre del producto:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="Txt_NombreProduct2" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp; Cantidad:&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txt_Cant2" runat="server"></asp:TextBox>
        </div>
        <p>
            <asp:Button ID="btn_Aceptar" runat="server" OnClick="btn_Aceptar_Click" Text="Generar Tabla" />
        </p>
    </form>
</body>
</html>
