using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class MotoCross : VehiculoDeCarrera
    {
        private short _cilindrada;

        public short cilindrada
        {
            get => _cilindrada;
            set => _cilindrada = value;
        }


        public MotoCross(short numero, string escuderia) : base(numero, escuderia)
        {
            this.numero = numero;
            this.escuderia = escuderia;
        }

        public MotoCross(short numero, string escuderia, short cilindrada):this(numero, escuderia)
        {   
            this.cilindrada = cilindrada;
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            
            sb.AppendLine(base.MostrarDatosAuto());

            return sb.ToString();
        }


        public static bool operator ==(MotoCross m1, MotoCross m2)
        {
            bool retorno = false;
            if (m1.numero == m2.numero && m1.escuderia == m2.escuderia && m1.cilindrada == m2.cilindrada)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(MotoCross m1, MotoCross m2)
        {
            return !(m1.numero == m2.numero && m1.escuderia == m2.escuderia && m1.cilindrada == m2.cilindrada);
        }
    }
}
