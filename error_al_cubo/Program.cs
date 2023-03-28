namespace error_al_cubo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            Console.WriteLine("Ingrese un numero ");

            string input = Console.ReadLine();

            int.TryParse(input, out numero);

            if(numero > 0)
            {
                double resultado_cuadrado = Math.Pow(numero, 2);
                double resultado_cubo = Math.Pow(numero, 3);

                Console.WriteLine("El resultado del cuadrado de {0} es {1}", numero, resultado_cuadrado);
                Console.WriteLine("El resultado del cubo de {0} es {1}", numero, resultado_cubo);
            }
            else
            {
                Console.WriteLine("El numero debe ser mayor a cero");
            }

        }
    }
}