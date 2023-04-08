using System.Drawing;

namespace PruebaGeometria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creamos una instancia de la clase Punto
            Punto punto1 = new Punto(0, 0);

            // Creamos una instancia de la clase Rectangulo
            Rectangulo rectangulo1 = new Rectangulo(new Punto(0, 0), new Punto(5, 10));

            // Imprimimos por pantalla los valores de área y perímetro del rectángulo
            Console.WriteLine("Área del rectángulo: " + rectangulo1.getArea());
            Console.WriteLine("Perímetro del rectángulo: " + rectangulo1.GetPerimetro());

            // Imprimimos por pantalla los valores de los vértices del rectángulo
            Console.WriteLine("Vértice 1: (" + rectangulo1.GetVertice1().X + ", " + rectangulo1.GetVertice1().Y + ")");
            Console.WriteLine("Vértice 2: (" + rectangulo1.GetVertice2().X + ", " + rectangulo1.GetVertice2().Y + ")");
            Console.WriteLine("Vértice 3: (" + rectangulo1.GetVertice3().X + ", " + rectangulo1.GetVertice3 ().Y + ")");    
        }
    }
}