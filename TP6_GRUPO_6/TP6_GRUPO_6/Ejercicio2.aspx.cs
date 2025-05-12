using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP6_GRUPO_6
{
	public partial class Ejercicio2 : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

        }

        protected void linkbuttonEliminar_Click(object sender, EventArgs e)
        {
            if (Session["Tabla"] != null) {
                Session["Tabla"] = null;
                lblMensaje.Text = "Todos los productos seleccionados han sido eliminados";
            }
            else
            {
                lblMensaje.Text = "No hay productos seleccionados para eliminar";
            }
        }
    }
}