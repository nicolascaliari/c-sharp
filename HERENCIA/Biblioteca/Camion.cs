using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Camion : VehiculoTerrestre
    {
        //private short _cantidadRuedas;
        //private short _cantidadPuertas;
        //private Colores color;
        private short _cantidadMarchas;
        private int _pesoCarga;

        public Camion(short cantidadRuedas, short cantidadPuertas, short cantidadMarchas, int pesoCarga, Colores color): base(cantidadRuedas, cantidadPuertas, color)
        {
            //_cantidadRuedas = cantidadRuedas;
            //_cantidadPuertas = cantidadPuertas;
            _cantidadMarchas = cantidadMarchas;
            _pesoCarga = pesoCarga;
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

        public int PesoCarga
        {
            get
            {
                return _pesoCarga;
            }
            set
            {
                _pesoCarga = value;
            }
        }

    }
}
