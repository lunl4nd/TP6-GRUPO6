using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace TP6_GRUPO_6
{
	public partial class SeleccionarProductos : System.Web.UI.Page
    {
        GestionProductos gestor = new GestionProductos();
        string nombreTabla = "Tabla de Productos";
        protected void Page_Load(object sender, EventArgs e)
		{
            if (!IsPostBack)
            {
                CargarGridView();
                if (Session["Tabla"] == null)
                {
                    Session["Tabla"] = CrearTabla();
                }
            }
        }

        private void CargarGridView()
        {
            string consultaSQL = "SELECT * FROM PRODUCTOS";
            gridviewProductos2.DataSource = gestor.ObtenerTabla(nombreTabla, consultaSQL);
            gridviewProductos2.DataBind();
        }

        protected void GridView1_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            int idProducto = Convert.ToInt32(((Label)gridviewProductos2.Rows[e.NewSelectedIndex].FindControl("labelItemID")).Text);
            string Nombre = ((Label)gridviewProductos2.Rows[e.NewSelectedIndex].FindControl("labelItemProducto")).Text;
            int idProveedor = Convert.ToInt32(((Label)gridviewProductos2.Rows[e.NewSelectedIndex].FindControl("labelItemProveedor")).Text);
            string Precio = ((Label)gridviewProductos2.Rows[e.NewSelectedIndex].FindControl("labelItemPrecio")).Text;
            AgregarFila((DataTable)Session["Tabla"], idProducto, Nombre, idProveedor, Precio);
        }

        private DataTable CrearTabla()
        {
            DataTable dataTable = new DataTable();
            DataColumn dataColumn = new DataColumn("Id Producto", System.Type.GetType("System.Int32"));
            dataTable.Columns.Add(dataColumn);
            dataColumn = new DataColumn("Nombre Producto",System.Type.GetType("System.String"));
            dataTable.Columns.Add(dataColumn);
            dataColumn = new DataColumn("Id Proveedor", System.Type.GetType("System.Int32"));
            dataTable.Columns.Add(dataColumn);
            dataColumn = new DataColumn("Precio Unitario", System.Type.GetType("System.Single"));
            dataTable.Columns.Add(dataColumn);
            return dataTable;
        }

        private DataTable AgregarFila(DataTable data, int idProducto, string Nombre, int idProveedor, string Precio)
        {
            DataRow datarow = data.NewRow();
            datarow["Id Producto"] = idProducto;
            datarow["Nombre Producto"] = Nombre;
            datarow["Id Proveedor"] = idProveedor;
            datarow["Precio Unitario"] = Precio;
            data.Rows.Add(datarow);
            return data;
        }

    }
}