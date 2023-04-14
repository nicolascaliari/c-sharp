using ClassLibrary4;

namespace ConvesorBinario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NumeroBinario objBinario = "1001";
            NumeroDecimal objDecimal = 9;



            string binario = (string)objBinario;
            double numeroDecimal = (double)objDecimal;

            Console.WriteLine(binario);
            Console.WriteLine(numeroDecimal);

        }
    }
}