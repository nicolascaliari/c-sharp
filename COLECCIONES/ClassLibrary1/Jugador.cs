using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca
{
    public class Jugador
    {
        private int dni;
        private string _nombre;

        public string nombre
        {
            get => _nombre; 
            set => _nombre = value;
        }

        private int partidosJugados;
        private float _promedioGoles;

        public float PromedioGoles
        {
            get => _promedioGoles;
            set => _promedioGoles = value;
        }

        private int totalGoles;


        private Jugador()
        {
            this.dni = 0;
            this.nombre = "";
            this.totalGoles = 0;
            this.partidosJugados = 0;

        }


        public Jugador(int dni, string nombre): this()
        {
            this.dni = dni; 
            this._nombre = nombre;
        }


        public Jugador(int dni, string nombre, int totalGoles, int totalPartidos): this(dni, nombre)
        {
            this.dni= dni;
            this._nombre = nombre;
            this.totalGoles = totalGoles;
            this.partidosJugados = totalPartidos;
        }


        public float GetPromedio()
        {
           return  PromedioGoles = (float)totalGoles / partidosJugados;
        }

        public  string MostrarDatos()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine($"Nombre del jugador: {_nombre}");
            stringBuilder.AppendLine($"Dni : {dni}");
            stringBuilder.AppendLine($"Partidos jugados: {partidosJugados}");
            stringBuilder.AppendLine($"Total goles: {totalGoles}");
            stringBuilder.AppendLine($"Promedio de goles { GetPromedio():0.##} ");

            return stringBuilder.ToString();    
        }


        public static bool operator ==(Jugador j1 , Jugador j2)
        {
            return j1.dni == j2.dni;
        }


        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1.dni == j2.dni);
        }



    }
}
