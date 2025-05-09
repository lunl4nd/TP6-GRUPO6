<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="TP6_GRUPO_6.Inicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="labelGrupo6" runat="server" Font-Bold="True" Font-Size="25pt" Text="GRUPO No. 6"></asp:Label>
            <br />
            <br />
            <asp:HyperLink ID="hyperlinkEjercicio1" runat="server" Font-Size="15pt" NavigateUrl="~/Ejercicio1.aspx">Ejercicio 1</asp:HyperLink>
            <br />
            <br />
            <asp:HyperLink ID="HyperLink1" runat="server" Font-Size="15pt" NavigateUrl="~/Ejercicio2.aspx">Ejercicio 2</asp:HyperLink>
        </div>
    </form>
</body>
</html>
