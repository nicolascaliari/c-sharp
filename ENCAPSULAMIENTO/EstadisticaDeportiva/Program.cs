using Biblioteca;

namespace EstadisticaDeportiva
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Equipo equipo = new Equipo(2, "bacelona");

            Jugador jugadorUno = new Jugador(11111, "Nicolas", 10, 2);
            Jugador jugadorDos = new Jugador(11111, "pepe", 10, 2);
            Jugador jugadorTres = new Jugador(11111, "ricardo", 10, 2);
            Jugador jugadorCuatro = new Jugador(11111, "mariano", 10, 2);
            Jugador jugadorCinco = new Jugador(11111, "santiago", 10, 2);



            if (equipo + jugadorUno)
            {
                Console.WriteLine(jugadorUno.MostrarDatos());
            }
            else
            {
                Console.WriteLine($"No se cargo el jugador {jugadorUno.nombre}");
            }


            if (equipo + jugadorDos)
            {
                Console.WriteLine(jugadorDos.MostrarDatos());
            }
            else
            {
                Console.WriteLine($"No se cargo el jugador {jugadorDos.nombre}");
            }


            if (equipo + jugadorTres)
            {
                Console.WriteLine(jugadorTres.MostrarDatos());
            }
            else
            {
                Console.WriteLine($"No se cargo el jugador {jugadorTres.nombre}");
            }


            if (equipo + jugadorCuatro)
            {
                Console.WriteLine(jugadorCuatro.MostrarDatos());
            }
            else
            {
                Console.WriteLine($"No se cargo el jugador {jugadorCuatro.nombre}");
            }


            if (equipo + jugadorCinco)
            {
                Console.WriteLine(jugadorCinco.MostrarDatos());
            }
            else
            {
                Console.WriteLine($"No se cargo el jugador {jugadorCinco.nombre}");
            }

        }
    }
}