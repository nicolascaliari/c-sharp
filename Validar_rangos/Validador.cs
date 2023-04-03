using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validar_rangos
{
    internal class Validador
    {

        public static bool ValidarRangos(int valor, int min, int max)
        {
            bool retorno = true;

            if(valor < min || valor > max)
            {
                retorno =  false;
            }

            return retorno;
        }


        public static bool PedirNumeros(int cantidad)
        {
            int numero;
            bool retorno = true;
            for (int i = 0; i < cantidad; i++)
            {
                string input = Console.ReadLine();
                bool numero_ingresado = int.TryParse(input, out numero);

                bool retorno_validar = ValidarRangos(numero, -100, 100);

                if (retorno_validar == false)
                {
                    retorno = false;
                    break;
                }

            }
            return retorno;
        }
    }
}
