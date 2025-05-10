using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace TP6_GRUPO_6
{
	public class Conexion
	{
        private const string rutaSQL = "Data Source=localhost\\sqlexpress;Initial Catalog = Neptuno; Integrated Security = True";
        public SqlConnection GetConnection()
        {
            SqlConnection connection = new SqlConnection(rutaSQL);
            try
            {
                connection.Open();
                return connection;
            }
            catch (Exception exception)
            {
                return null;
            }
        }

        public int ejecutarProcedimientoAlmacenado(SqlCommand comando, string nombreProcedimientoAlmacenado)
        {
            int filasAfectadas;
            SqlConnection conexion = GetConnection();
            SqlCommand command = new SqlCommand();
            command = comando;
            command.Connection = conexion;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = nombreProcedimientoAlmacenado;
            filasAfectadas = command.ExecuteNonQuery();
            conexion.Close();
            return filasAfectadas;

        }
    }
}