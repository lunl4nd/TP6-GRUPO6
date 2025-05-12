using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace TP6_GRUPO_6
{
    public partial class MostrarProductos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["Tabla"] != null)
                {
                    DataTable table = (DataTable)Session["Tabla"];
                    gvMostrar.DataSource = table;
                    gvMostrar.DataBind();
                }
                else
                {
                    lblMensaje.Text = "No hay productos seleccionados.";
                }
            }
        }
    }
}