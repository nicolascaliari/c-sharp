using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public enum Colores
    {
        Rojo, Blanco, Azul, Gris, Negro
    }
    public class Automovil : VehiculoTerrestre
    {
        //private short _cantidadRuedas;
        //private short _cantidadPuertas;
        //private Colores color;
        private short _cantidadMarchas;
        private int _cantidadPasajeros;

        public Automovil(short cantidadRuedas, short cantidadPuertas, short cantidadMarchas, int cantidadPasajeros, Colores color): base(cantidadRuedas, cantidadPuertas, color)
        {
            _cantidadMarchas = cantidadMarchas;
            _cantidadPasajeros = cantidadPasajeros;
        }

        //public short CantidadRuedas
        //{
        //    get
        //    {
        //        return _cantidadRuedas;
        //    }
        //    set
        //    {
        //        _cantidadRuedas = value;
        //    }
        //}

        //public short CantidadPuertas
        //{
        //    get
        //    {
        //        return _cantidadPuertas;
        //    }
        //    set
        //    {
        //        _cantidadPuertas = value;
        //    }
        //}

        public short CantidadMarchas
        {
            get
            {
                return _cantidadMarchas;
            }
            set
            {
                _cantidadMarchas = value;
            }
        }

        public int CantidadPasajeros
        {
            get
            {
                return _cantidadPasajeros;
            }
            set
            {
                _cantidadPasajeros = value;
            }
        }


        public override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.MostrarDatos());
            sb.AppendLine("Cantidad de marchas: " + _cantidadMarchas);
            sb.AppendLine("Cantidad de pasajeros: " + _cantidadPasajeros);
            return sb.ToString();
        }
    }
}
