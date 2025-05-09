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
    }
}