

namespace Conversor_binario



{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero");

            Conversor conversor = new Conversor();

            string numero = Console.ReadLine();

            int.TryParse(numero, out int valor);    

            conversor.ConvertirDecimalABinario(valor);
           
        }
    }
}