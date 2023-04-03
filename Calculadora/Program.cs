namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroUno = 0;
            int numeroDos = 0;
            char operador = ' ';
              
            
          bool Verificacion = Logica.PedirNumeros(ref numeroUno, ref numeroDos, ref operador);

            if( Verificacion )
            {
                Calculadora calculadora = new Calculadora();

                int respuesta = calculadora.Calcular(numeroUno, numeroDos, operador);

                if (respuesta != -1)
                {
                    Console.WriteLine(respuesta);
                }
                else
                {
                    Console.WriteLine("Algo salio mal en la division");
                }
            }
            else
            {
                Console.WriteLine("Algo salio mal en el ingreso de datos");
            }
           
            }
        }
    }
