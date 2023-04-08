using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Universal
{
    internal class Estudiante
    {
        private string nombre;
        private int legajo;
        private string apellido;
        private float notaPrimerParcial;
        private float notaSegundoParcial;
        private static Random random = new Random();

        //Constructor de instancia
        public Estudiante(string nombre, string apellido, int legajo)
        {
            this.nombre = nombre;   
            this.apellido = apellido;
            this.legajo = legajo;
        }

        //Contructor estatico
        //static Estudiante()
        //{
        //}

        public void SetNotaPrimerParcial(int notaPirmerParcial)
        {
            this.notaPrimerParcial = notaPirmerParcial;
        }

        public void SetNotaSegundoParcial(int notaSegundoParcial)
        {
            this.notaSegundoParcial = notaSegundoParcial;
        }

        private float CalcularPromedio()
        {
            return (notaPrimerParcial + notaSegundoParcial) / 2;
        }


        public int CalcularNotaFinal()
        {
            int notaFinal = -1;
            if(notaPrimerParcial >= 4 && notaSegundoParcial >= 4)
            {
                notaFinal = random.Next(6,11);
            }

            return notaFinal;
        }


        public string Mostrar()
        {
           int notaFinal = CalcularNotaFinal();

            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Datos : ");
            sb.AppendLine($"Nombre: {nombre}, apellido: {apellido}, legajo: {legajo}");
            sb.AppendLine($"Nota primer parcial : {notaPrimerParcial}");
            sb.AppendLine($"Nota segundo parcial: {notaSegundoParcial}");
            sb.AppendLine($"Promedio : {CalcularPromedio()}");


            if(notaFinal != -1)
            {
                sb.AppendLine($"Nota final: {notaFinal}");
            }
            else
            {
                sb.AppendLine("Alumno desaprobado");
            }
          

            return sb.ToString();
        }
    }
}
