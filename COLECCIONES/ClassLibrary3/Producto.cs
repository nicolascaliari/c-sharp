using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary3
{
    public class Producto
    {

        private string _nombreProducto;
        private int _precioProducto;
        private int _codigoProducto;
        private int _cantidadProducto;

        public string NombreProducto
        {
            get { return _nombreProducto; }
            set { _nombreProducto = value; }
        }

        public int PrecioProducto
        {
            get { return _precioProducto; }
            set { _precioProducto = value; }
        }

        public int CodigoProducto
        {
            get { return _codigoProducto; }
            set { _codigoProducto = value; }
        }

        public int CantidadProducto
        {
            get { return _cantidadProducto; }
            set { _cantidadProducto = value; }
        }




        public Producto(string nombreProducto, int precioProducto, int codigoProducto, int cantidadProducto)
        {
            _nombreProducto = nombreProducto;
            _precioProducto = precioProducto;
            _codigoProducto = codigoProducto;
            _cantidadProducto = cantidadProducto;
        }
    
    }
}
