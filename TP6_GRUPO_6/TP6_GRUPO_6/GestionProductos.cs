using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
namespace TP6_GRUPO_6
{
	public class GestionProductos
	{
		Conexion sqlConnection = new Conexion();
		public GestionProductos() 
		{

		}
		public DataTable ObtenerTabla(string nombreTabla, string consultaSQL)
		{
			DataSet dataset = new DataSet();
			SqlDataAdapter dataAdapter = new SqlDataAdapter(consultaSQL,sqlConnection.GetConnection());
			dataAdapter.Fill(dataset, nombreTabla);
			return dataset.Tables[nombreTabla];
		}
	}
}