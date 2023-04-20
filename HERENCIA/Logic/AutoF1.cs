using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class AutoF1 : VehiculoDeCarrera
    {
        private short _caballosDeFuerza;

        public short caballosDeFuerza
        {
            get => _caballosDeFuerza;
            set => _caballosDeFuerza = value;
        }



        public AutoF1(short numero, string escuderia) : base(numero, escuderia) 
        {
            this.numero = numero;
            this.escuderia = escuderia;
            //this.cantidadCombustible = 0;
            //this.vueltasRestantes = 0;
        }


        public AutoF1(short numero, string escuderia, short caballosDeFuerza) : this(numero, escuderia)
        {
            this.caballosDeFuerza = caballosDeFuerza;
        }

     public string MostrarDatosAuto()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Cantidad de combustible: {cantidadCombustible}");
            sb.AppendLine($"Escuderia:  {escuderia}");
            sb.AppendLine($"Numero : {numero}");
            sb.AppendLine($"Vueltas restantes: {vueltasRestantes}");

            return sb.ToString();
        }



        public static bool operator ==(AutoF1 a1, AutoF1 a2)
        {
            return (a1.numero == a2.numero && a1.escuderia == a2.escuderia);
        }
        public static bool operator !=(AutoF1 a1, AutoF1 a2)
        {
            return !(a1.numero == a2.numero && a1.escuderia == a2.escuderia);
        }

    }
}
