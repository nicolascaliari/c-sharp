using System.Text;

namespace Logic
{
    public class VehiculoDeCarrera
    {
        private short _cantidadCombustible;
        private bool _enCompetencia;
        private string _escuderia;
        private short _numero;
        private short _vueltasRestantes;


        public short cantidadCombustible
        {
            get => _cantidadCombustible;
            set => _cantidadCombustible = value;
        }

        public bool enCompetencia
        {
            get => _enCompetencia;
            set => _enCompetencia = value;
        }

        public string escuderia
        {
            get => _escuderia;
            set => _escuderia = value;
        }

        public short numero
        {
            get => _numero;
            set => _numero = value;
        }

        public short vueltasRestantes
        {
            get => _vueltasRestantes;
            set => _vueltasRestantes = value;
        }


        public VehiculoDeCarrera(short numero, string escuderia)
        {
            this.numero = numero;
            this.escuderia = escuderia;
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



    }
}