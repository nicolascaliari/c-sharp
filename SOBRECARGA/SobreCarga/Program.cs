namespace SobreCarga
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sumador sumador = new Sumador();

            Console.WriteLine(sumador.Sumar("2", "3"));
            Console.WriteLine(sumador.Sumar(4, 3));

            Console.WriteLine($"La cantidad de sumar que se hicieron son: {sumador.cantidadSumar}");


            Sumador sumadorDos = new Sumador(4);

            int cantidad = (int)sumadorDos;

            Console.WriteLine($"La cantidad de sumas por explicito es: {cantidad}");

            long cantidadPorSobrecaga = sumador + sumadorDos;

            Console.WriteLine($"La suma de las cantidad de ambos objetos por sobrecarga es: {cantidadPorSobrecaga}");
        
            bool tienenIgualCantidad = sumador | sumadorDos;

            Console.WriteLine($"sumador y sumadorDos tienen igual cantidad de sumas: {tienenIgualCantidad}");

        }
    }
}