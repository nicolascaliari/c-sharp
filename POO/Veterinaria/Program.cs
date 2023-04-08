namespace Veterinaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cliente client = Cliente.AgregarCliente();

            Console.WriteLine(client.Mostrar());
        }
    }
}