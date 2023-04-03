using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Logica
    {

       public static bool PedirNumeros(ref int numero_uno, ref int numero_dos,ref char operador_)
        {
            bool retorno = false;

            Console.WriteLine("Ingrese el primer numero");

            bool respuestaUno = int.TryParse(Console.ReadLine(), out  numero_uno);

            Console.WriteLine("Ingrese el segundo numero");

            bool respuestaDos = int.TryParse(Console.ReadLine(), out  numero_dos);

            Console.WriteLine("Ingrese el operador + / - /  % / *");
            bool respuestaTres = char.TryParse(Console.ReadLine(), out operador_);

            if(respuestaUno &&  respuestaDos && respuestaTres)
            {
                retorno = true;
            }
            return retorno;
        }
    }
}
