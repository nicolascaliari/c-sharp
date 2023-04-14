using biblioteca;


namespace estanteria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creo un estante
           Estante estante = new Estante(5, 1);
         

            // Creo 4 productos
            Producto p1 = new Producto("Pepsi", "PESDS97413", (float)18.5);
            Producto p2 = new Producto("Coca-Cola", "COSDS55752", (float)11.5);
            Producto p3 = new Producto("Manaos", "MASDS51292", (float)20.5);
            Producto p4 = new Producto("Crush", "CRSDS54861", (float)10.75);

            // Agrego los productos al estante
            if (estante + p1)
            {
                Console.WriteLine("Agregó {0} {1} {2}", p1.marca, (string)p1, p1.precio);
            }
            else
            {
                Console.WriteLine("¡NO agregó {0} {1} {2}!", p1.marca, (string)p1, p1.precio);
            }

            //if (estante + p1)
            //{
            //    Console.WriteLine("Agregó {0} {1} {2}", p1.marca, (string)p1, p1.precio);
            //}
            //else
            //{
            //    Console.WriteLine("¡NO agregó {0} {1} {2}!", p1.marca, (string)p1, p1.precio);
            //}

            if (estante + p2)
            {
                Console.WriteLine("Agregó {0} {1} {2}", p2.marca, (string)p2, p2.precio);
            }
            else
            {
                Console.WriteLine("¡NO agregó {0} {1} {2}!", p2.marca, (string)p2, p2.precio);
            }

            if (estante + p3)
            {
                Console.WriteLine("Agregó {0} {1} {2}", p3.marca, (string)p3, p3.precio);
            }
            else
            {
                Console.WriteLine("¡NO agregó {0} {1} {2}!", p3.marca, (string)p3, p3.precio);
            }

            if (estante + p4)
            {
                Console.WriteLine("Agregó {0} {1} {2}", p4.marca, (string)p4, p4.precio);
            }
            else
            {
                Console.WriteLine("¡NO agregó {0} {1} {2}!", p4.marca, (string)p4, p4.precio);
            }

            // Muestro todo el estante
            Console.WriteLine();
            Console.WriteLine("<------------------------------------------------->");
            Console.WriteLine(Estante.MostrarEstante(estante));
        }
    }
}