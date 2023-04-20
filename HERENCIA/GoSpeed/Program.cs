using Logic;

namespace GoSpeed
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
          Competencia competenciaUno = new Competencia(5, 5, Competencia.TipoCompetencia.F1);
          Competencia competenciaDos = new Competencia(5, 5, Competencia.TipoCompetencia.MotoCross);
          MotoCross motoCross = new MotoCross(1, "moto", 100);
          AutoF1 autoF1 = new AutoF1(1, "ferrari", 100);

            if(competenciaUno + autoF1)
            {
                Console.WriteLine($"se pudo agregar");
            }
            else
            {
                Console.WriteLine($"No se pudo agregar");    
            }


            if (competenciaUno + motoCross)
            {
                Console.WriteLine($"se pudo agregar");
            }
            else
            {
                Console.WriteLine($"No se pudo agregar");
            }



            if (competenciaDos + motoCross)
            {
                Console.WriteLine($"se pudo agregar");
            }
            else
            {
                Console.WriteLine($"No se pudo agregar");
            }


            Console.WriteLine(competenciaUno.MostrarDatos());
           
        }
    }
}