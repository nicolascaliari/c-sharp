using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary4
{
    public class NumeroDecimal
    {
        private double numeroDecimal;


        private NumeroDecimal(double numero) 
        {
            numeroDecimal = numero; 
        }
        

        public static explicit operator double(NumeroDecimal numero)
        {
            return numero.numeroDecimal;
        }


        public static implicit operator NumeroDecimal(double numero)
        {
            return new NumeroDecimal(numero);   
        }

        public static double operator +(NumeroDecimal numeroDecimal, NumeroBinario numeroBinario)
        {
            return numeroDecimal + numeroBinario;
        }

        public static double operator -(NumeroDecimal numeroDecimal, NumeroBinario numeroBinario)
        {
            return numeroDecimal - numeroBinario;
        }

        public static bool operator ==(NumeroDecimal numeroDecimal, NumeroBinario numeroBinario)
        {
            return (numeroDecimal == numeroBinario);    
        }

        public static bool operator !=(NumeroDecimal numeroDecimal, NumeroBinario numeroBinario)
        {
            return !(numeroDecimal == numeroBinario);
        }
    }
}
