using System.ComponentModel;

namespace ejer1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int acumulador = 0;
            int numeroMaximo = 0;
            int numeroMinimo = 0;
            bool bandera = true;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese un numero : ");
                string input = Console.ReadLine();
                int numero;

                int.TryParse(input, out numero);

                acumulador += numero;
                Console.WriteLine("El numero ingresa es {0}", numero);


                if (bandera == true)
                {
                    numeroMaximo = numero;
                    numeroMinimo = numero;
                    bandera = false;

                }
                else
                {
                    if(numero > numeroMaximo)
                    {
                        numeroMaximo = numero;
                    }
                    else if(numero < numeroMinimo)
                    {
                        numeroMinimo = numero;
                    }
                }

            }


            float promedio = acumulador / 5;





            Console.WriteLine("El promedio es: {0}", promedio);
            Console.WriteLine("El numero mas grande es: {0}", numeroMaximo);
            Console.WriteLine("El numero minimo es: {0}", numeroMinimo);

        }
    }
}