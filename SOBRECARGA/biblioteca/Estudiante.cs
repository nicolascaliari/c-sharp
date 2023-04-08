using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca
{
    public class Estudiante
    {
        public string NombreEstudiante;
        public int legajo { get; set; }
       public Estudiante(string NombreEstudiante, int legajo)
        {
        this.NombreEstudiante = NombreEstudiante;
        this.legajo = legajo;
        }








        public static int operator +(Estudiante estudianteUno, Estudiante estudianteDos)
        {
            return estudianteUno.legajo + estudianteDos.legajo;
        }
    }
}
