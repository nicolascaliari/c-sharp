using Logica;


namespace UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DirectorTecnico directorUno = new DirectorTecnico("Nicolas",222222 , new DateTime(1990, 10, 10));
            DirectorTecnico directorDos = new DirectorTecnico("Nicolas", 333333, new DateTime(1990, 10, 10));
            DirectorTecnico directorTres = new DirectorTecnico("Santiago",3444521 ,new DateTime(1990, 10, 10));
            DirectorTecnico directorCuatro = new DirectorTecnico("Pedro", 3455314,new DateTime(1990, 10, 10));


            if(directorUno == directorDos)
            {
                Console.WriteLine($"Son iguales, Directos uno: {directorUno.MostrarDatos()},  director dos: {directorDos.MostrarDatos()}");
            }
            else
            {
                Console.WriteLine("Son distintos");
            }

            if(directorUno == directorTres)
            {
                Console.WriteLine("Son iguales");
            }
            else
            {
                Console.WriteLine("Son distintos");
            }

            if(directorUno == directorCuatro)
            {
                Console.WriteLine("Son iguales");
            }
            else
            {
                Console.WriteLine("Son distintos");
            }
        }
    }
}