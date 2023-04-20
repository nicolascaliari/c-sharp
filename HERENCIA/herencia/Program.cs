using Biblioteca;

namespace herencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            VehiculoTerrestre auto = new Automovil(4, 4, 5, 5, Colores.Azul);
            Camion camion = new Camion(8, 2, 6, 1000, Colores.Rojo);
            Moto moto = new Moto(2, 0, 3, Colores.Gris);


            Console.WriteLine($"Los datos del auto son {auto.MostrarDatos()}");
           
        }
    }
}