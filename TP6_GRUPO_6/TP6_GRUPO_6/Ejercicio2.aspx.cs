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
            lblMensaje.Text = string.Empty;
        }

        protected void linkbuttonEliminar_Click(object sender, EventArgs e)
        {
            gestorSesiones.limpiarTablaProductosSesion();
            if(gestorSesiones.cantidadSeleccionada > 0)
            {
                gestorSesiones.cantidadSeleccionada = 0;
                lblMensaje.Text = "Se eliminaron los productos seleccionados!";
            }else
            {
                lblMensaje.Text = "No hay productos seleccionados!";
            }
            
        }
    }
}