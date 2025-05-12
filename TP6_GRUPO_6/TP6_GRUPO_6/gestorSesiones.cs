using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace TP6_GRUPO_6
{
    public class gestorSesiones
    {
        private const string TABLA_PRODUCTOS = "Tabla";

        public static DataTable tablaProductos
        {
            get
            {
                if(HttpContext.Current.Session[TABLA_PRODUCTOS] == null)
                {
                    HttpContext.Current.Session[TABLA_PRODUCTOS] = crearTabla();
                }
                return (DataTable)HttpContext.Current.Session[TABLA_PRODUCTOS];
            }
            set
            {
                HttpContext.Current.Session[TABLA_PRODUCTOS] = value;
            }
        }

        private static DataTable crearTabla()
        {
            DataTable dataTable = new DataTable();
            DataColumn dataColumn = new DataColumn("IdProducto", System.Type.GetType("System.Int32"));
            dataTable.Columns.Add(dataColumn);
            dataColumn = new DataColumn("NombreProducto", System.Type.GetType("System.String"));
            dataTable.Columns.Add(dataColumn);
            dataColumn = new DataColumn("IdProveedor", System.Type.GetType("System.Int32"));
            dataTable.Columns.Add(dataColumn);
            dataColumn = new DataColumn("PrecioUnitario", System.Type.GetType("System.Single"));
            dataTable.Columns.Add(dataColumn);
            return dataTable;
        }

        public static bool agregarProducto(int idProducto, string nombreProducto, int idProveedor, decimal precioUnidad)
        {
            foreach (DataRow row in tablaProductos.Rows)
            {
                if(Convert.ToInt32(row["idProducto"]) == idProducto)
                {
                    return false;
                }

            }
            DataRow datarow = tablaProductos.NewRow();
            datarow["IdProducto"] = idProducto;
            datarow["NombreProducto"] = nombreProducto;
            datarow["IdProveedor"] = idProveedor;
            datarow["PrecioUnitario"] = precioUnidad;
            tablaProductos.Rows.Add(datarow);
            return true;
        }

        public static void limpiarTablaProductosSesion()
        {
            HttpContext.Current.Session.Remove(TABLA_PRODUCTOS);
        }
    }
}