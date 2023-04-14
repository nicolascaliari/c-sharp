using ClassLibrary3;

namespace Fahrenheit_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kelvin kelvinDegree = new(1);
            Celsius celsiusDegree = new(1);
            Fahrenheit fahrenheitDegree = new(1);




            Console.WriteLine("=================================");    
            Celsius convertirDeFahrenheitACelsius = celsiusDegree + fahrenheitDegree;
            Celsius convertirDeKelvinACelsius = celsiusDegree + kelvinDegree;
            Console.WriteLine($"1 fahrenheit es en celsius : {convertirDeFahrenheitACelsius.temperaturaCelsius}");
            Console.WriteLine($"1 kelvin es en celsius : {convertirDeKelvinACelsius.temperaturaCelsius}");




            Console.WriteLine("=================================");
            Fahrenheit convertirDeCelsiusAFahrenheit = fahrenheitDegree + celsiusDegree;
            Fahrenheit convertirDeKelvinAFahrenheit = fahrenheitDegree + kelvinDegree;
            Console.WriteLine($"1 kelvin es en fahrenheit : {convertirDeKelvinAFahrenheit.temperaturaFahrenheit}");
            Console.WriteLine($"1 celsius es en fahrenheit : {convertirDeCelsiusAFahrenheit.temperaturaFahrenheit}");





            Console.WriteLine("=================================");
            Kelvin convertirDeFahrenheitAKelvin = kelvinDegree + fahrenheitDegree;
            Kelvin convertirDeCelsiusAKelvin = kelvinDegree + celsiusDegree;
            Console.WriteLine($"1 fahrenheit es en kelvin : {convertirDeFahrenheitAKelvin.temperaturaKelvin}");
            Console.WriteLine($"1 celsius es en kelvin : {convertirDeCelsiusAKelvin.temperaturaKelvin}");
            Console.WriteLine("=================================");



        }
    }
}