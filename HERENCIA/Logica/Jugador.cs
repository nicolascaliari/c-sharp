using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Jugador
    {
        private int dni;
        private string _nombre;
        private int partidosJugados;
        private int totalGoles;

        public string nombre
        {
            get => _nombre;
            set => _nombre = value;
        }

        public int Dni
        {
            get => dni;
            set => dni = value;
        }

        public int PartidosJugados
        {
            get => partidosJugados;
        }

        public int TotalGoles
        {
            get => totalGoles;
        }

        public float PromedioGoles
        {
            get => (float)totalGoles / partidosJugados;
        }




        private Jugador()
        {
            this.dni = 0;
            this.nombre = "";
            this.totalGoles = 0;
            this.partidosJugados = 0;

        }


        public Jugador(int dni, string nombre) : this()
        {
            this.dni = dni;
            this._nombre = nombre;
        }


        public Jugador(int dni, string nombre, int totalGoles, int totalPartidos) : this(dni, nombre)
        {
            this.dni = dni;
            this._nombre = nombre;
            this.totalGoles = totalGoles;
            this.partidosJugados = totalPartidos;
        }



        public string MostrarDatos()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine($"Nombre del jugador: {_nombre}");
            stringBuilder.AppendLine($"Dni : {dni}");
            stringBuilder.AppendLine($"Partidos jugados: {partidosJugados}");
            stringBuilder.AppendLine($"Total goles: {totalGoles}");
            stringBuilder.AppendLine($"Promedio de goles {PromedioGoles:0.##} ");

            return stringBuilder.ToString();
        }


        public static bool operator ==(Jugador j1, Jugador j2)
        {
            return j1.dni == j2.dni;
        }


        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1.dni == j2.dni);
        }
    }
}
