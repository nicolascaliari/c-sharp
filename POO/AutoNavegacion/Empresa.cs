using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoNavegacion
{
    internal class Empresa
    {
        private Conductor[] conductores;


        public Empresa(Conductor[] conductor) { 
            
            this.conductores = conductor; 
        }




        public Conductor ObtenerConductorMaxKmSemana()
        {
            Conductor conductorMaxKmSemana = null;
            int maxKmSemana = 0;

            foreach (Conductor conductor in conductores)
            {
                Console.WriteLine(conductor.Nombre);
                int kmSemana = 0;

                for (int i = 0; i < conductor.Kilometros.Length; i++)
                {
                    kmSemana += conductor.Kilometros[i];
                }

                if (kmSemana > maxKmSemana)
                {
                    maxKmSemana = kmSemana;
                    conductorMaxKmSemana = conductor;
                }
            }

            return conductorMaxKmSemana;
        }

        public Conductor ObtenerConductorMaxKmDia(int dia)
        {
            Conductor conductorMaxKmDia = null;
            int maxKmDia = 0;

            foreach (Conductor conductor in conductores)
            {
                int kmDia = conductor.Kilometros[dia - 1];

                if (kmDia > maxKmDia)
                {
                    maxKmDia = kmDia;
                    conductorMaxKmDia = conductor;
                }
            }

            return conductorMaxKmDia;
        }
    }
}
