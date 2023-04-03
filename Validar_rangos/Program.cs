namespace Validar_rangos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese 10 numeros dentro del rango de -100 y 100");

          bool respuesta =  Validador.PedirNumeros(10);

            if(respuesta){
                Console.WriteLine("Todo esta dentro del rango");
            }
            else
            {
                Console.WriteLine("No esta dentro del rango");
            }


           
        }
    }
}