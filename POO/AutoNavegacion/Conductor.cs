using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoNavegacion
{
    internal class Conductor
    {
        public string Nombre { get; set;}
        public int[] Kilometros { get; set;} 
    

        public Conductor(int[] Kilometros, string Nombre ) { 
        
            this.Nombre = Nombre;  
            this.Kilometros = Kilometros;
        
        }


        public string getNombre()
        {
            return Nombre;
        }

        public int getKilometrosTotales()
        {
           return  Kilometros.Sum();
        }


    }
}
