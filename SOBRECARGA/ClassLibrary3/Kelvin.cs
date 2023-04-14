using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary3
{
    public class Kelvin
    {
        public decimal temperaturaKelvin;

        public Kelvin(decimal temperatura)
        {
            this.temperaturaKelvin = temperatura;
        }


        public static Kelvin operator +(Kelvin k, Fahrenheit f)
        {
            return new Kelvin(k.temperaturaKelvin + Conversor.ConvertirFahrenheitAKelvin(f.temperaturaFahrenheit));
        }



        public static Kelvin operator +(Kelvin k , Celsius c)
        {
            return new Kelvin(k.temperaturaKelvin + Conversor.ConvertirCelsiusAKelvin(c.temperaturaCelsius));
        }
    }
}
