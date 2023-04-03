using Prestamo;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cuenta cuenta = new Cuenta("nico", 1000);
            Console.WriteLine(cuenta.Mostrar());


            cuenta.Ingresar(3000);

            Console.WriteLine(cuenta.Mostrar());

            cuenta.Retirar(3000);

            Console.WriteLine(cuenta.Mostrar());
        }
    }
}