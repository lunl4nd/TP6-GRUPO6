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
        protected void Page_Load(object sender, EventArgs e)
		{
            if (!IsPostBack)
            {
                CargarGridView();
                
            }


        }

        private void CargarGridView()
        {
            GestionProductos productos = new GestionProductos();
            gridviewProductos2.DataSource = productos.obtenerProductos();
            gridviewProductos2.DataBind();
        }

        protected void GridView1_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            int idProducto = Convert.ToInt32(((Label)gridviewProductos2.Rows[e.NewSelectedIndex].FindControl("labelItemID")).Text);
            string Nombre = ((Label)gridviewProductos2.Rows[e.NewSelectedIndex].FindControl("labelItemProducto")).Text;
            int idProveedor = Convert.ToInt32(((Label)gridviewProductos2.Rows[e.NewSelectedIndex].FindControl("labelItemProveedor")).Text);
            decimal Precio = Convert.ToDecimal(((Label)gridviewProductos2.Rows[e.NewSelectedIndex].FindControl("labelItemPrecio")).Text);

            bool fueAgregado = gestorSesiones.agregarProducto(idProducto, Nombre, idProveedor, Precio);
            if (!fueAgregado)
            {
                pAgregado.Text = "El producto " + Nombre + " ya fue agregado";
            }
            else
            {
                pAgregado.Text = "El Producto " + Nombre + " ha sido agregado";
            }
            

            pAgregado.Visible = true;
            
        }

        protected void gridviewProductos2_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gridviewProductos2.PageIndex = e.NewPageIndex;
            CargarGridView();
        }
    }
}