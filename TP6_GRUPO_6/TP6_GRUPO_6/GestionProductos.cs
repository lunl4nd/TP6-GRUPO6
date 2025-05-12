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

		public DataTable obtenerProductos()
        {
			return ObtenerTabla("Productos", "SELECT * FROM Productos");
        }

		private void armarParametrosActualizar(ref SqlCommand comando, Producto producto)
        {
			SqlParameter parametros = new SqlParameter();
			parametros = comando.Parameters.Add("@IdProducto", SqlDbType.Int);
			parametros.Value = producto.IdProducto;
			parametros = comando.Parameters.Add("@NombreProducto", SqlDbType.NVarChar, 40);
			parametros.Value = producto.NombreProducto;
			parametros = comando.Parameters.Add("@CantidadPorUnidad", SqlDbType.NVarChar, 20);
			parametros.Value = producto.Cantidadporunidad;
			parametros = comando.Parameters.Add("@PrecioUnidad", SqlDbType.Money);
			parametros.Value = producto.Precioporunidad;
        }

		private void armarParametrosEliminar(ref SqlCommand comando, Producto producto)
		{
			SqlParameter parametro = new SqlParameter();
            parametro = comando.Parameters.Add("@IdProducto", SqlDbType.Int);
			parametro.Value = producto.IdProducto;
        }

		public bool actualizarProducto(Producto producto)
        {
			SqlCommand comando = new SqlCommand();
			armarParametrosActualizar(ref comando, producto);
			Conexion conexion = new Conexion();
			int filasAfectadas = conexion.ejecutarProcedimientoAlmacenado(comando, "spActualizarProducto");
			
			if(filasAfectadas == 1)
            {
				return true;
            }
            else
            {
				return false;
            }
		}

		public bool eliminarProducto(Producto producto)
		{
			SqlCommand comando = new SqlCommand();
			armarParametrosEliminar(ref comando, producto);
			Conexion conexion = new Conexion();
			int filasAfectadas = conexion.ejecutarProcedimientoAlmacenado(comando, "spEliminarProducto");
            if (filasAfectadas == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

		


	}
}