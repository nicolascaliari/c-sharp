using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary3
{
    public class Conversor
    {
        public static decimal ConvertirCelsiusAFahrenheit(decimal celcius)
        {
            return celcius * (9 / 5m) + 32;
        }


        public static decimal ConvertirKelvinAFahrenheit(decimal kelvin)
        {
            return kelvin * (9 / 5m) - 459.67m;
        }


        public static decimal ConvertirFahrenheitAClesius(decimal fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9m;
        }

        public static decimal ConvertirFahrenheitAKelvin(decimal fahrenheit)
        {
            return (fahrenheit + 459.67m) * 5 / 9m;
        }

        public static decimal ConvertirCelsiusAKelvin(decimal celsius)
        {
            return celsius + 273.15m;
        }

        public static decimal ConvertirKelvinACelsius(decimal kelvin)
        {
            return kelvin - 273.15m;
        }
    }
}
