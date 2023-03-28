using System.Data;

namespace primos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool bandera = true;
            int numero;

            //coomit desde visual
            while(bandera)
            {
               Console.WriteLine("Ingrese un numero: ");
                string input = Console.ReadLine();  
              bool numero_ingresado =  int.TryParse(input, out numero);

                while(numero_ingresado == false)
                {
                    Console.WriteLine("Lo que ingreso no es un numero, intentelo nuevamente: ");

                    input  = Console.ReadLine();

                     numero_ingresado = int.TryParse(input, out numero);
                }

                Console.WriteLine("Los numeros primos hasta {0}", numero);
                for (int i = 2; i <= numero; i++)
                {
                    bool esPrimo = true;
                    for (int j = 2; j < i; j++)
                    {
                        if (i % j == 0)
                        {
                            esPrimo = false;
                            break;
                        }
                    }

                    if(esPrimo)
                    {
                        Console.WriteLine(i);
                    }
                }

                Console.WriteLine("Desea seguir? Ingrese S para seguir/ Ingrese N para no seguir");
                string input2 = Console.ReadLine();

                if(input2 == "s")
                {
                    bandera = true;
                }
                else
                {
                    bandera = false;
                }

            }
        }
    }
}