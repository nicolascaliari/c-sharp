namespace AutoNavegacion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Conductor conductor = new Conductor(new int[] {100,200, 300, 0, 500,600,700 }, "Nicolas");
            Conductor conductorDos = new Conductor(new int[] { 300, 700,700,0, 800, 600, 700 }, "Juan");
            Conductor conductorTres = new Conductor(new int[] { 40, 50, 100, 0, 900, 800, 100 }, "Marcos");
            Console.WriteLine(conductor.getNombre());
            Console.WriteLine (conductor.getKilometrosTotales());



            Empresa empresa = new Empresa(new Conductor[] { conductor, conductorDos, conductorTres });

            // Mostrar los resultados
            Console.WriteLine("El conductor que hizo más kilómetros en la semana es: " + empresa.ObtenerConductorMaxKmSemana().Nombre);
            Console.WriteLine("El conductor que hizo más kilómetros el día 3 es: " + empresa.ObtenerConductorMaxKmDia(3).Nombre);
            Console.WriteLine("El conductor que hizo más kilómetros el día 5 es: " + empresa.ObtenerConductorMaxKmDia(5).Nombre);

        }
    }
}