namespace ConsoleApp1
{
    internal class Program
    {
        //c# es de tipado estatico, o sea cuando declaro una variable le tengo qwe decir de que tipo es.
        //El ref se usa para pasar por referencia.(No la vamos a usar igualmente). Tambien se puede usar out.
        static void Main(string[] args)
        {
            Console.WriteLine("Primer clase de c#");

            int numero = 0;

            TomarNumero(ref numero);
            Console.WriteLine(numero);


            Persona juan = new Persona("Nico");

            tomarPersona(juan);

            Console.WriteLine(juan.name);
        }

        //metodo

        static void tomarPersona(Persona persona)
        {
            persona.name = "Nuevo nombre";
        }

        static void TomarNumero(ref int numero)
        {
            numero = numero + 1;

        }


        class Persona
        {
            public string name;
            public Persona(string name)
            {
                this.name = name;
            }


        }


    }
}