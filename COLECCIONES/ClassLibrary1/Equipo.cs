namespace biblioteca
{
    public class Equipo
    {
        private short _catidadDeJugadores;

        public short cantidadDeJugadores
        {
            get => _catidadDeJugadores;
            set => _catidadDeJugadores = value ;
        }


        private List<Jugador> _jugadores;


        public List<Jugador> jugadores
        {
            get => _jugadores;
            set => _jugadores = value;  
        }

        private string nombre;


        private Equipo()
        {
               jugadores = new List<Jugador>();
        }

        public Equipo(short cantidad, string nombre):this()
        {
            this._catidadDeJugadores = cantidad;
            this.nombre = nombre;
        }




        public static bool operator ==(Equipo e, Jugador j)
        {
            bool retorno = false;
            foreach (Jugador item in e.jugadores)
            {
                if(item == j)
                {
                    retorno = true;
                }
                else
                {
                    retorno = false;
                }

            }
            return false;      
        }


        public static bool operator !=(Equipo e, Jugador j)
        {
                return !(e == j);
        }


        public static bool operator +(Equipo e, Jugador j)
        {

            if(e._jugadores.Count < e._catidadDeJugadores && e != j)
            {
                e._jugadores.Add(j);
                return true;
            }
            else
            {
                return false;
            }
        }



    }
}