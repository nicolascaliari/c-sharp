namespace Colecciones
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> numeros = new List<int>(); 

            Random random = new Random();
 

            for(int i = 0; i < 20; i++)
            {
                numeros.Add(random.Next(1, 100));
            }

            foreach (var item in numeros)
            {
                Console.WriteLine(item);          
            }
           Console.WriteLine("==========================");
           Console.WriteLine("FORMA DECRECIENTE");
            numeros.Sort((numeroUno, numeroDos) => numeroDos.CompareTo(numeroUno));
           
            foreach (var item in numeros)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine("==========================");
            Console.WriteLine("FORMA CRECIENTE");

            numeros.Sort((numeroUno, numeroDos) => numeroUno.CompareTo(numeroDos));

            foreach (var item in numeros)
            {
                Console.WriteLine(item);
            }
        }
    }
}