using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TP6_GRUPO_6
{
    public class Producto
    {
        //Propiedades
        private int _idProducto;
        private string _nombreProducto;
        private string _cantidadporunidad;
        private string _precioporunidad;

        public Producto()
        {
            //constructor por defecto.
        }

        public Producto(int idproducto)
        {
            _idProducto = idproducto;
        }
        public Producto(int idProducto, string nombreProducto, string cantidadporunidad, string precioporunidad)
        {
            _idProducto = idProducto;
            _nombreProducto = nombreProducto;
            _cantidadporunidad = cantidadporunidad;
            _precioporunidad = precioporunidad;
        }

        //getters y setters
        public int IdProducto
        {
            get
            {
                return _idProducto;
            }
            set
            {
                _idProducto = value;
            }
        }
        public string NombreProducto
        {
            get
            {
                return _nombreProducto;
            }
            set
            {
                _nombreProducto = value;
            }
        }
        public string Cantidadporunidad
        {
            get
            {
                return _cantidadporunidad;
            }
            set
            {
                _cantidadporunidad = value;
            }
        }
        public string Precioporunidad
        {
            get
            {
                return _precioporunidad;
            }
            set
            {
                _precioporunidad = value;
            }
        }
    }
}
}