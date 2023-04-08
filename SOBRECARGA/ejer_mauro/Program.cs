using biblioteca;


namespace ejer_mauro
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Universidad universidad = new Universidad("UTN");
            Estudiante estudianteUno = new Estudiante("Nicolas", 10);
            Estudiante estudianteDos = new Estudiante("pepe", 10);
            string universidadUtn = (string)universidad;

           // Universidad suma = estudianteUno + estudianteDos;
           Console.WriteLine(estudianteDos + estudianteUno);   
           Console.WriteLine(universidadUtn); 
        
        }
    }
}