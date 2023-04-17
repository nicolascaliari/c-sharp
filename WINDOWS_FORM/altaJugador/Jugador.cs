using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace altaJugador
{
    public class Jugador
    {
        private int id;
        private string _nombreJugador;
        private string _apellidoJugador;
        private int _dni;
        public static List<Jugador> jugadores;

        public string NombreJugador
        {
            get { return _nombreJugador; }
            set { _nombreJugador = value; }
        }

        public string ApellidoJugador
        {
            get { return _apellidoJugador; }
            set { _apellidoJugador = value; }
        }

        public int Dni
        {
            get { return _dni; }
            set { _dni = value; }
        }

        public Jugador(string nombreJugador, string apellidoJugador, int dni)
        {
            jugadores = new List<Jugador>();
            _nombreJugador=nombreJugador;
            _apellidoJugador = apellidoJugador;
            _dni = dni;
        }
    }
}
