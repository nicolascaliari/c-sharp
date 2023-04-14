using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary3
{
    public class Celsius
    {
        public decimal temperaturaCelsius;

        public Celsius(decimal temperatura)
        {
            this.temperaturaCelsius = temperatura;
        }    


        public static Celsius operator +(Celsius c, Kelvin k)
        {
            return new Celsius(c.temperaturaCelsius + Conversor.ConvertirKelvinACelsius(k.temperaturaKelvin));
        }



        public static Celsius operator +(Celsius c, Fahrenheit f)
        {
            return new Celsius(c.temperaturaCelsius + Conversor.ConvertirFahrenheitAClesius(f.temperaturaFahrenheit));
        }
    }
}
