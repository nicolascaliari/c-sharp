using System.Text;

namespace ClassLibrary2
{
    public class Competencia
    {
        private short cantidadCompetidores;

        private short cantidadVueltas;

        private List<AutoF1> competidores;


        private Competencia()
        {
            competidores = new List<AutoF1>();  
        }

        public Competencia(short cantidadVueltas, short cantidadCompetidores):this()
        {
            this.cantidadVueltas = cantidadVueltas; 
            this.cantidadCompetidores = cantidadCompetidores;
        }


        public  string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();


            sb.AppendLine("Datos del equipo");

          //  sb.AppendLine($"Cantidad de vueltas: {cantidadVueltas}");
            sb.AppendLine($"Cantidad de competidores: {cantidadCompetidores}");



            foreach (AutoF1 item in competidores)
            {
                sb.AppendLine(item.MostrarDatosAuto());
            }

            return sb.ToString();
        }


        public static bool operator +(Competencia c, AutoF1 a)
        {
            if(c.competidores.Count < c.cantidadCompetidores  &&  c != a)
            {
                c.competidores.Add(a);
                a.SetEncompetencia(true);


                Random random = new Random();
                a.SetVueltasRestantes(c.cantidadVueltas);

                a.SetCantidadCombustible((short)random.Next(15,100));
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator -(Competencia c, AutoF1 a)
        {
            return c - a;
        }


        public static bool operator ==(Competencia c, AutoF1 a)
        {
            foreach (AutoF1 item in c.competidores)
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
    


        public static bool operator !=(Competencia c, AutoF1 a)
        {
            return !(c == a);
        }




    }
}