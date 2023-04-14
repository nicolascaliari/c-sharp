using ClassLibrary3;
using System.Text;

namespace Maquina_expendedora
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //MaquinaExpendedora maquina = new MaquinaExpendedora();

            //Console.WriteLine(maquina.ElegirProducto());


            
            Dictionary<int, Stack<Producto>> maquinaExpendedora = new Dictionary<int, Stack<Producto>>();
            
            Stack<Producto> papasFritas = new Stack<Producto>();
            papasFritas.Push(new Producto("Papas Fritas", 25.50));
            papasFritas.Push(new Producto("Papas Fritas", 25.50));
            papasFritas.Push(new Producto("Papas Fritas", 25.50));
            papasFritas.Push(new Producto("Papas Fritas", 25.50));


            Stack<Producto> galletitas = new Stack<Producto>();
            galletitas.Push(new Producto("Oreo", 100));
            galletitas.Push(new Producto("Oreo", 100));
            galletitas.Push(new Producto("Oreo", 100));
            galletitas.Push(new Producto("Oreo", 100));
            galletitas.Push(new Producto("Oreo", 100));



            Stack<Producto> bebidas = new Stack<Producto>();
            bebidas.Push(new Producto("Agua", 50));
            bebidas.Push(new Producto("Agua", 50));
            bebidas.Push(new Producto("Agua", 50));
            bebidas.Push(new Producto("Agua", 50));
            bebidas.Push(new Producto("Agua", 50));



            maquinaExpendedora.Add(1, papasFritas);
            maquinaExpendedora.Add(2, galletitas);
            maquinaExpendedora.Add(3, bebidas);



            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Bienvenido: \n\n");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Gray;
            int entradaUsuario = 1;
            string entradaUsuarioString = "";
            while (maquinaExpendedora.Count > 0 && entradaUsuarioString != "S")
            {
                foreach (KeyValuePair<int, Stack<Producto>> estante in maquinaExpendedora)
                {
                    Console.WriteLine($"{estante.Key} - Producto: {estante.Value.Peek().Nombre} " +
                        $"- Precio: $ {estante.Value.Peek().Precio} - Cantidad {estante.Value.Count}");
                }
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Elija su producto o presione S para salir: \n");
                Console.ForegroundColor = ConsoleColor.Gray;
                entradaUsuarioString = Console.ReadLine();
                if (int.TryParse(entradaUsuarioString, out entradaUsuario) && maquinaExpendedora.ContainsKey(entradaUsuario))
                {
                    Producto productoElegido = maquinaExpendedora[entradaUsuario].Pop();
                    Console.WriteLine($"Se eligió el producto : {productoElegido.Nombre}, " +
                        $"que sale ${productoElegido.Precio}. Y su codigo es {productoElegido.Codigo}\n");
                    if (maquinaExpendedora[entradaUsuario].Count == 0)
                    {
                        maquinaExpendedora.Remove(entradaUsuario);
                    }
                }
                else if (entradaUsuarioString != "S")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Elija una opción correcta");
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
            }
            Console.WriteLine("Gracias, vuelva prontos!");


        }
    }
}