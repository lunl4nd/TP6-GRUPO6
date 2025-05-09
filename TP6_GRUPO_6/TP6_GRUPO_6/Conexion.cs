using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

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
    }
}