using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desea_continuar
{
    internal class Validador
    {

        public static bool ValidarRespuesta(string input)
        {
           int numero;
           bool retorno =  int.TryParse(input, out numero);

            return retorno;
        }


        public static bool IngresarNumero()
        {
            int acumulador = 0;
            bool continuar = true;
            while(continuar)
            {
                Console.WriteLine("Ingrese un numero entero para sumarlo");
                string numero = Console.ReadLine();

                if(ValidarRespuesta(numero))
                {
                    int respuesta = int.Parse(numero);

                    acumulador = Sumador(respuesta, acumulador);
                    Console.WriteLine($"Suma total: {acumulador}");
                }
                else
                {
                    break;
                }
                Console.WriteLine("Desea continuar? Ingrese S para continuar / Ingrese N para salir");


                string seguir = Console.ReadLine();

                if(seguir == "n" || seguir == "N")
                {
                    continuar = false;
                }

            }
            return continuar;
        }

        public static int Sumador(int numero, int acumulador)
        {    
           return acumulador += numero;
        }
        
    }
}
