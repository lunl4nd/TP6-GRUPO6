<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio2.aspx.cs" Inherits="TP6_GRUPO_6.Ejercicio2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 16px;
        }
        .auto-style3 {
            width: 16px;
            height: 53px;
        }
        .auto-style4 {
            height: 53px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <table class="auto-style1">
                <tr>
                    <td class="auto-style3"></td>
                    <td class="auto-style4">
            <asp:Label ID="labelInicio" runat="server" Font-Size="XX-Large" Text="Inicio" Font-Bold="True"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td>
            <asp:HyperLink ID="hyperlinkSeleccionar" runat="server" NavigateUrl="~/SeleccionarProductos.aspx">Seleccionar Productos</asp:HyperLink>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td>
                        <asp:LinkButton ID="lbEliminar" runat="server" OnClick="linkbuttonEliminar_Click">Eliminar Productos Seleccionados</asp:LinkButton>
&nbsp;&nbsp;
                        <asp:Label ID="lblMensaje" runat="server" ForeColor="Red"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td>
            <asp:HyperLink ID="hyperlinkMostrar" runat="server">Mostrar Productos</asp:HyperLink>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
            <br />
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;
            <br />
            <br />
        </div>
    </form>
</body>
</html>
