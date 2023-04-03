using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Calculadora
    {
        /// <summary>
        /// esta funcion realiza calculos matematicos
        /// </summary>
        /// <param name="numeroUno"></param>
        /// <param name="numeroDos"></param>
        /// <param name="operador"></param>
        public int Calcular(int numeroUno, int numeroDos, char operador)
        {
            int resultado = 0;
                switch (operador)
                {
                    case '+':
                        resultado = numeroUno + numeroDos;
                        break;

                    case '-':
                        resultado = numeroUno - numeroDos;
                        break;
                    case '/':
                        bool verificacion = Validar(numeroDos);
                        if(verificacion)
                         {
                            resultado = numeroUno / numeroDos;
                         }
                        else
                        {
                            Console.WriteLine("No se puede dividir por cero");
                            resultado = -1;
                        }
                        break;
                    case '*':
                        resultado = numeroUno * numeroDos;
                        break;
                    default:
                        resultado = -1;
                        break; 
            }
            return resultado;
        }

       /// <summary>
       /// Esta funcion verifica en el caso que el operador sea division que el segundo numero no sea 0.
       /// </summary>
       /// <param name="numeroDos"></param>
        private static bool Validar(int numeroDos)
        {
            bool retorno = true;


            if(numeroDos == 0)
            {
                retorno = false;
            }
                
         return retorno;
        }
    }
}
