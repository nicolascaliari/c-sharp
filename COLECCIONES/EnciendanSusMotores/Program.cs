using ClassLibrary2;

namespace EnciendanSusMotores
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Competencia competencia = new Competencia(2, 4);


            AutoF1 primerAuto = new AutoF1(2, "Ferrari");
            AutoF1 SegundoAuto = new AutoF1(3, "Mercedes");
            AutoF1 TercerAuto = new AutoF1(4, "Alpha");
            AutoF1 CuartoAuto = new AutoF1(5, "Alpha");


            //============================
            if (competencia + primerAuto)
            {
               // Console.WriteLine(primerAuto.MostrarDatosAuto());
                Console.WriteLine(competencia.MostrarDatos());
            }
            else
            {
                Console.WriteLine("No se pudo cargar");    
            }


            //=============================
            
            
            if (competencia + SegundoAuto)
            {
               // Console.WriteLine(SegundoAuto.MostrarDatosAuto());
                Console.WriteLine(competencia.MostrarDatos());
            }
            else
            {
                Console.WriteLine("No se pudo cargar");
            
            
            }
            //==========================


            if (competencia + TercerAuto)
            {
                Console.WriteLine(competencia.MostrarDatos());
            }
            else
            {
                Console.WriteLine("No se pudo cargar");


            }
            ////==========================



            if (competencia + CuartoAuto)
            {
                Console.WriteLine(competencia.MostrarDatos());
            }
            else
            {
                Console.WriteLine("No se pudo cargar");
            }
        }
    }
}