using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hola_Windows_form
{
    public class Persona
    {
        public string Nombre { get; set; }
        public int legajo { get; set; }


        public Persona(string nombre, int legajo)
        {
            this.Nombre = nombre;
            this.legajo = legajo;   
        }


        public override string ToString()
        {
            return Nombre + " " + legajo;
        }
    }
}
