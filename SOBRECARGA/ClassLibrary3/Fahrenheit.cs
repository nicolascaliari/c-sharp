namespace ClassLibrary3
{
    public class Fahrenheit
    {
        public decimal temperaturaFahrenheit;

        public Fahrenheit(decimal temperatura)
        {
            this.temperaturaFahrenheit = temperatura;
        }


        public static Fahrenheit operator +(Fahrenheit f, Kelvin k)
        {
            return new Fahrenheit(f.temperaturaFahrenheit + Conversor.ConvertirKelvinAFahrenheit(f.temperaturaFahrenheit));
        }


        public static Fahrenheit operator +(Fahrenheit f, Celsius c)
        {
            return new Fahrenheit(f.temperaturaFahrenheit + Conversor.ConvertirCelsiusAFahrenheit(c.temperaturaCelsius));
        }

    }
}