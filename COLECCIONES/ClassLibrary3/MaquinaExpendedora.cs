using System.Diagnostics.Metrics;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ClassLibrary3
{
    public class MaquinaExpendedora
    {
        private Dictionary<int, Stack<Producto>> productos;


        public MaquinaExpendedora()
        {
            productos = new Dictionary<int, Stack<Producto>>();
            CargarProductos();
        }


        private void CargarProductos()
        {

            Producto papasFrita = new Producto("Papas fritas", 20, 1, 4);
            Producto coca_cola = new Producto("Coca cola", 20, 2, 6);
            Producto sprite = new Producto("Spirte", 20, 3, 2);



            Stack<Producto> papasFritas = new Stack<Producto>();
            papasFritas.Push(papasFrita);
            papasFritas.Push(papasFrita);
            papasFritas.Push(papasFrita);

            Stack<Producto> cocaCola = new Stack<Producto>();
            cocaCola.Push(coca_cola);
            cocaCola.Push(coca_cola);
            cocaCola.Push(coca_cola);
            cocaCola.Push(coca_cola);
            cocaCola.Push(coca_cola);
            cocaCola.Push(coca_cola);

            Stack<Producto> Gomitas = new Stack<Producto>();
            Gomitas.Push(sprite);
            Gomitas.Push(sprite);
            Gomitas.Push(sprite);
            Gomitas.Push(sprite);
            Gomitas.Push(sprite);


            productos.Add(1,papasFritas);
            productos.Add(2, cocaCola);
            productos.Add(3, Gomitas);
            //productos.Add(4, new Producto("sprite", 40));
            //productos.Add(5, new Producto("agua", 10));
            //productos.Add(6, new Producto("gaseosa", 20));
            //productos.Add(7, new Producto("cerveza", 50));
            //productos.Add(8, new Producto("vino", 100));
            //productos.Add(9, new Producto("coca cola light", 20));
            //productos.Add(10, new Producto("pepsi light", 30));

        }   

        public void MostrarProductos()
        {

            Console.WriteLine("Bienvenido a la maquina expendedora");
            Console.WriteLine("===================================");
            foreach (var producto in productos)
            {
                int posicion = producto.Key;
                Producto productoSeleccionado = producto.Value.Peek();
                int cantidad = producto.Value.Count;
                Console.WriteLine($"ID: {posicion}. {productoSeleccionado.NombreProducto}. {productoSeleccionado.PrecioProducto} . Cantidad : {cantidad}");
            }
        }
        
        public bool EliminarProducto(int numeroSeleccionado)
        {
            if(productos.ContainsKey(numeroSeleccionado))
            {
                Stack<Producto> productoSeleccionado = productos[numeroSeleccionado];
                productos.Remove(numeroSeleccionado);

                Console.WriteLine("Producto seleccionado: " + productoSeleccionado);

                return true;
            }
            else
            {
                Console.WriteLine("El numero seleccionado no es valido");
                return false;
            }
        }


        public void EelegirProducto()
        {
            MostrarProductos();

            while(true)
            {
                Console.WriteLine("Seleccione un producto o para salir ingrese la letra S");
                string seleccion = Console.ReadLine().ToUpper();

                if(seleccion == "S")
                {
                    Console.WriteLine("Gracias por usar la maquina");
                    break;
                }

                if(int.TryParse(seleccion, out int numeroSeleccionado) && productos.ContainsKey(numeroSeleccionado))
                {
                    productos[numeroSeleccionado].Pop();

                    if (productos[numeroSeleccionado].Count == 0)
                    {
                        EliminarProducto(numeroSeleccionado);
                    }

                    Console.WriteLine("Productos restantes");

                    MostrarProductos();
                }
                else
                {
                    Console.WriteLine("La seleccion del producto debe ser de un numero");
                }
            }    
        }

    }
}