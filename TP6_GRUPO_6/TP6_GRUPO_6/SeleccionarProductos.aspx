<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SeleccionarProductos.aspx.cs" Inherits="TP6_GRUPO_6.SeleccionarProductos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="gridviewProductos2" runat="server" AutoGenerateColumns="False" AutoGenerateSelectButton="True" OnSelectedIndexChanging="GridView1_SelectedIndexChanging">
                <Columns>
                    <asp:TemplateField HeaderText="Id Producto">
                        <ItemTemplate>
                            <asp:Label ID="labelItemID" runat="server" Text='<%# Bind("IdProducto") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Nombre Producto">
                        <ItemTemplate>
                            <asp:Label ID="labelItemProducto" runat="server" Text='<%# Bind("NombreProducto") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Id Proveedor">
                        <ItemTemplate>
                            <asp:Label ID="labelItemProveedor" runat="server" Text='<%# Bind("IdProveedor") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Precio Unitario">
                        <ItemTemplate>
                            <asp:Label ID="labelItemPrecio" runat="server" Text='<%# Bind("PrecioUnidad") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
            <br />
        </div>
    </form>
</body>
</html>
