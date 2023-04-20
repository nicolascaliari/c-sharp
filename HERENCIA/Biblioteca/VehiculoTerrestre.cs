using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public abstract class VehiculoTerrestre
    {

        private short _cantidadRuedas;
        private short _cantidadPuertas;
        private Colores color;

        public short CantidadRuedas
        {
            get
            {
                return _cantidadRuedas;
            }
            set
            {
                _cantidadRuedas = value;
            }
        }

        public VehiculoTerrestre(short cantidadRuedas, short cantidadPuertas , Colores color)
        {
            _cantidadRuedas = cantidadRuedas;
            _cantidadPuertas = cantidadPuertas;
            this.color = color;
        }


        public virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Cantidad de ruedas: " + _cantidadRuedas);
            sb.AppendLine("Cantidad de puertas: " + _cantidadPuertas);
            sb.AppendLine("Color: " + color);
            return sb.ToString();
        }

    }
}
