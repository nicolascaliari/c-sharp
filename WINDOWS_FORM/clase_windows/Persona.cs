using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase_windows
{
    public class Persona
    {
        private string _nombre;
        private int _legajo;

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public int Legajo
        {
            get { return _legajo; }
            set { _legajo = value; }
        }

        public Persona(string nombre, int legajo)
        {
            Nombre = nombre;
            Legajo = legajo;
        }

        public override string ToString()
        {
            // aca hago string builder seria lo mejor
            return Nombre + " " + Legajo;
        }

    }
}
