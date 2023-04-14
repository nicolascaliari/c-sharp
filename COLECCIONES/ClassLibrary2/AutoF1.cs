using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    public class AutoF1
    {
        private short cantidadCombustible;
        private bool enCompetencia;
        private string escuderia;
        private short numero;
        private short vueltasRestantes;


        private AutoF1()
        {
            this.enCompetencia = false;
            this.cantidadCombustible = 0;
            this.vueltasRestantes= 0;
        }


        public AutoF1(short numero, string escuderia):this()
        {
            this.numero = numero;   
            this.escuderia = escuderia;
        }


        public void SetCantidadCombustible(short cantidad)
        {
            this.cantidadCombustible = cantidad;
        }

        public void SetEncompetencia(bool enCompetencia)
        {
           this.enCompetencia = enCompetencia;
        }

        public void SetVueltasRestantes (short cantidad)
        {
           this.vueltasRestantes = cantidad;
        }


        public short GetCantidadCombustible()
        {
            return this.cantidadCombustible;
        }

        public bool GetEncompetencia()
        {
            return this.enCompetencia;
        }

        public short GetVueltasRestantes()
        {
            return this.vueltasRestantes;
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
