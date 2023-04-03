using System.Text;

namespace AprenderTablas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero");

            bool respuesta = int.TryParse(Console.ReadLine(), out int numero);
           Console.WriteLine(CalcularTablasDeMultiplicacion(numero));
        
        }

        public static string CalcularTablasDeMultiplicacion(int numero)
        {
            StringBuilder sb = new StringBuilder();
            int resultado;
            for (int i = 1; i < 10; i++)
            {
                resultado = numero * i;
                sb.AppendLine($"{numero} x {i} =  {resultado}");
            }

           return sb.ToString();
        }
    }
}