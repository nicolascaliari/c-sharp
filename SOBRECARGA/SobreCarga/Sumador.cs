using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobreCarga
{
    internal class Sumador
    {
        public int cantidadSumar
        {
            get => _cantidadSumar;
            set => _cantidadSumar = value;
        }


        private int _cantidadSumar {  get; set; }

        //Constructores con sobrecarga
        public Sumador(int cantidadSumar)
        {
            _cantidadSumar = cantidadSumar;
        }


        public Sumador()
        {
            _cantidadSumar = 0;
        }

        //Metodos con sobrecarga

        public long Sumar(long a, long b)
        {
            _cantidadSumar++;

            long suma = a + b;

            return suma;

        }

        public string Sumar(string a, string b)
        {
            _cantidadSumar++;

            string suma = a + b;

            return suma;
        }

        //Sobrecarga de operadores de conversion

        //Firma ==>  [acceso] static implicit/explicit operator NombreTipo(Tipo a)


        public static explicit operator int(Sumador a)
        {
            return a.cantidadSumar;
        }


        //Sobrecarga de operadores

        public static long operator +(Sumador a, Sumador b)
        {
            return a.cantidadSumar + b.cantidadSumar ;
        }


        public static bool operator |(Sumador a, Sumador b)
        {
            return a.cantidadSumar == b.cantidadSumar;
        }
    }
}
