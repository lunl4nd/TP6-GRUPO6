<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio2.aspx.cs" Inherits="TP6_GRUPO_6.Ejercicio2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="labelInicio" runat="server" Font-Size="25pt" Text="Inicio"></asp:Label>
            <br />
            <br />
            <asp:HyperLink ID="hyperlinkSeleccionar" runat="server" NavigateUrl="~/SeleccionarProductos.aspx">Seleccionar Productos</asp:HyperLink>
            <br />
            <br />
            <asp:HyperLink ID="hyperlinkEliminar" runat="server">Eliminar Productos Seleccionados</asp:HyperLink>
            <br />
            <br />
            <asp:HyperLink ID="hyperlinkMostrar" runat="server">Mostrar Productos</asp:HyperLink>
        </div>
    </form>
</body>
</html>
