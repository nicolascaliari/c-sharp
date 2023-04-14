//using System.Security.Cryptography.X509Certificates;
//using System.Text;

//namespace ClassLibrary3
//{
//    public class MaquinaExpendedora
//    {
//        Stack<Producto> papasFritas = new Stack<Producto>();
//        Stack<Producto> cocacola = new Stack<Producto>();
//        Stack<Producto> pepsi = new Stack<Producto>();


//        public Dictionary<int, Producto> MostrarProductos()
//        {
//            Dictionary<int, Producto> maquinaExpendedora = new Dictionary<int, Producto>();


//            maquinaExpendedora.Add(1, new Producto("Papas fritas",20));
//            maquinaExpendedora.Add(2, new Producto("Doritos", 30));
//            maquinaExpendedora.Add(3, new Producto("Chetos", 40));
//            maquinaExpendedora.Add(4, new Producto("Fanta", 50));
//            maquinaExpendedora.Add(5, new Producto("Sprite", 60));
//            maquinaExpendedora.Add(6, new Producto("Coca-cola", 70));
//            maquinaExpendedora.Add(7, new Producto("Seven-up", 10));
//            maquinaExpendedora.Add(8, new Producto("Gomitas", 90));


//            foreach (var item in maquinaExpendedora)
//            {
//                Console.WriteLine($"Numero id:{item.Key} y contiene: {item.Value.nombre} y su precio es: {item.Value.precio}");
//            }

//            return maquinaExpendedora;
//        }



//        public bool ElegirProducto()
//        {
//            string ingresoString = "";
//            int ingreso = 1;
//            bool seguir = true;
//            StringBuilder sb = new StringBuilder();
           



//            while(seguir == true)
//            {
//                Dictionary<int, Producto> maquina = MostrarProductos();

//                Console.WriteLine("Ingrese el producto que desea ");    

//                ingresoString = Console.ReadLine();

//                if (int.TryParse(ingresoString, out ingreso) && maquina.ContainsKey(ingreso))
//                {

//                    maquina.TryGetValue(ingreso, out Producto producto);

//                    Console.WriteLine($"Compraste {producto.nombre}");
//                    maquina.Remove(ingreso);

//                    MostrarProductos();
//                }
//                else
//                {
//                    Console.WriteLine("El codigo ingresado esta mal o es invalido");    
//                    continue;
//                }



//              bool respuesta = Input.ValidateAnswer("Desea seguir?");

//                if (respuesta)
//                {
//                    seguir = true;
//                }
//                else
//                {
//                    seguir = false;
//                }

                
//            }

//            return true;
//        }
//    }
//}