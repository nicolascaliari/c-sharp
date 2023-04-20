using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Competencia
    {
        private short cantidadCompetidores;

        private short cantidadVueltas;

        private List<VehiculoDeCarrera> competidores;

        private TipoCompetencia tipo;


        private Competencia()
        {
            competidores = new List<VehiculoDeCarrera>();
        }

        public Competencia(short cantidadVueltas, short cantidadCompetidores, TipoCompetencia tipo) : this()
        {
            this.cantidadVueltas = cantidadVueltas;
            this.cantidadCompetidores = cantidadCompetidores;
            this.tipo = tipo;
        }

        public enum TipoCompetencia
        {
            F1, MotoCross
        }


        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();


            sb.AppendLine("Datos del equipo");

            //  sb.AppendLine($"Cantidad de vueltas: {cantidadVueltas}");
            sb.AppendLine($"Cantidad de competidores: {cantidadCompetidores}, Tipo de competencia: {tipo}");



            foreach (VehiculoDeCarrera item in competidores)
            {
                sb.AppendLine(item.MostrarDatosAuto());
            }

            return sb.ToString();
        }


        public static bool operator +(Competencia c, VehiculoDeCarrera a)
        {
            if (c.competidores.Count < c.cantidadCompetidores && c != a && c.tipo == TipoCompetencia.F1)
            {

                if(c.tipo == TipoCompetencia.F1)
                {
                    AutoF1 auto = new AutoF1(a.numero, a.escuderia);
                    a = auto;
                }
                else
                {
                    MotoCross moto = new MotoCross(a.numero, a.escuderia);
                    a = moto;
                }


                c.competidores.Add(a);
                a.enCompetencia = true;
   


                Random random = new Random();
                a.vueltasRestantes = c.cantidadVueltas;     
                a.cantidadCombustible = (short)random.Next(15, 100);

                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator -(Competencia c, VehiculoDeCarrera a)
        {
            return c - a;
        }


        public static bool operator ==(Competencia c, VehiculoDeCarrera a)
        {
            foreach (VehiculoDeCarrera item in c.competidores)
            {
                if (item == a)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            return false;
        }



        public static bool operator !=(Competencia c, VehiculoDeCarrera a)
        {
            return !(c == a);
        }
    }
}
