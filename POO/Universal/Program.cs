namespace Universal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Estudiante estudiante = new Estudiante("Nicolas", "Caliari", 100);
            Estudiante estudianteDos = new Estudiante("Malena", "Illan", 200 );
            Estudiante estudianteTres = new Estudiante("Agustina", "Fernandez", 300);


            estudiante.SetNotaPrimerParcial(10);
            estudiante.SetNotaSegundoParcial(7);


            estudianteDos.SetNotaPrimerParcial(6);
            estudianteDos.SetNotaSegundoParcial(7);



            estudianteTres.SetNotaPrimerParcial(2);
            estudianteTres.SetNotaSegundoParcial(7);



            Console.WriteLine(estudiante.Mostrar());
            Console.WriteLine(estudianteDos.Mostrar());
            Console.WriteLine(estudianteTres.Mostrar());
        }
    }
}