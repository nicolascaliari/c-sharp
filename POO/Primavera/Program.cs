namespace Primavera
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona("Nicolas", new DateTime(2001, 10, 28, 6, 34, 53), 222222222);
            Persona personaDos = new Persona("Malena", new DateTime(2002, 10, 5, 6, 34, 53), 333333333);
            Persona personaTres = new Persona("Juani", new DateTime(2016, 4, 20, 6, 34, 53), 444444444);

            // persona.setNombre("pepe");
            Console.WriteLine(persona.Mostrar());
            Console.WriteLine(personaDos.Mostrar());
            Console.WriteLine(personaTres.Mostrar());

           // Console.WriteLine(persona.CalcularEdad());    
        }
    }
}