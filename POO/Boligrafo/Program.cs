namespace InventoArgentino
{
    internal class Program
    {


        static void Main(string[] args)
        {
            Boligrafo boligrafoAzul = new Boligrafo(100, ConsoleColor.Blue);


            Boligrafo boligrafoRed = new Boligrafo(50, ConsoleColor.Red);

            Console.WriteLine("Bolígrafo Azul:");
            Console.WriteLine("Color: " + boligrafoAzul.getColor());
            Console.WriteLine("Tinta: " + boligrafoAzul.getTinta());
            Console.WriteLine("============================");




            Console.WriteLine("Bolígrafo Red:");
            Console.WriteLine("Color: " + boligrafoRed.getColor());
            Console.WriteLine("Tinta: " + boligrafoRed.getTinta());
            Console.WriteLine("Dibujo: " + boligrafoRed.Pintar(10, "Hola"));
            Console.WriteLine("============================");
           

            boligrafoRed.Recargar();

            Console.WriteLine("Bolígrafo Red:");
            Console.WriteLine("Cargando tinta...");
            Console.WriteLine("Tinta: " + boligrafoRed.getTinta());
            Console.WriteLine("============================");
        }
    }
}