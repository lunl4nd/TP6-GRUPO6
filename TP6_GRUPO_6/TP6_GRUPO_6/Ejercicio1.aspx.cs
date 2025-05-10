using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP6_GRUPO_6
{
	public partial class Ejercicio1 : System.Web.UI.Page
	{
		GestionProductos gestor = new GestionProductos();
		string nombreTabla = "Tabla de Productos";
		protected void Page_Load(object sender, EventArgs e)
		{
			if(!IsPostBack)
			{
				CargarGridView();
			}
		}

		private void CargarGridView()
		{
			string consultaSQL = "SELECT * FROM PRODUCTOS";
			gridviewProductos.DataSource = gestor.ObtenerTabla(nombreTabla, consultaSQL);
			gridviewProductos.DataBind();
		}

        protected void gridviewProductos_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
			gridviewProductos.PageIndex = e.NewPageIndex;
			CargarGridView();
        }

        protected void gridviewProductos_RowEditing(object sender, GridViewEditEventArgs e)
        {
			gridviewProductos.EditIndex = e.NewEditIndex;
			CargarGridView();
        }

        protected void gridviewProductos_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
			string idProducto = ((Label)gridviewProductos.Rows[e.RowIndex].FindControl("editIdProducto")).Text;
			string nombreProducto = ((TextBox)gridviewProductos.Rows[e.RowIndex].FindControl("editNombreProducto")).Text;
			string cantidadPorUnidad = ((TextBox)gridviewProductos.Rows[e.RowIndex].FindControl("editCantidadPorUnidad")).Text;
			string precioUnidad = ((TextBox)gridviewProductos.Rows[e.RowIndex].FindControl("editPrecioUnidad")).Text;

			Producto producto = new Producto(Convert.ToInt32(idProducto), nombreProducto, cantidadPorUnidad, precioUnidad);

			GestionProductos gestionProductos = new GestionProductos();
			gestionProductos.actualizarProducto(producto);
			gridviewProductos.EditIndex = -1;
			CargarGridView();
			
		}

        protected void gridviewProductos_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
			gridviewProductos.EditIndex = -1;
			CargarGridView();
        }
    }
}