using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primavera
{
    internal class Persona
    {
        private string nombre;
        private DateTime fechaDeNacimiento;
        private int dni;

        public Persona(string nombre, DateTime fechaDeNacimiento, int dni)
        {
            this.nombre = nombre;   
            this.fechaDeNacimiento = fechaDeNacimiento;
            this.dni = dni; 
        }

        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public void setNacimiento(DateTime fechaDeNacimiento)
        {
            this.fechaDeNacimiento = fechaDeNacimiento;
        }

        public void setDni(int dni)
        {
            this.dni = dni;
        }

        public string getNombre()
        {
            return this.nombre; 
        }


        public DateTime getNacimiento()
        {
            return this.fechaDeNacimiento;
        }

        public int getDni()
        {
            return this.dni;
        }


        private int CalcularEdad()
        {
            DateTime fecha = getNacimiento();

            DateTime fechaActual = DateTime.Now;

            TimeSpan diferencia = fechaActual.Subtract(fecha);

            double edadEnAnios = diferencia.TotalDays / 365.25;

            int edad = (int)Math.Round(edadEnAnios);

            Console.WriteLine($"la edad es: {edad}");

            return edad;

        }


        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Datos de la persona: ");
            sb.AppendLine($"Nombre : {nombre}");
            sb.AppendLine($"Fecha de nacimiento : {fechaDeNacimiento}");
            sb.AppendLine($"Dni : {dni}");

            EsMayorDeEdad();


            return sb.ToString();
        }

        public void EsMayorDeEdad()
        {
            int edad = CalcularEdad();

            if(edad >= 18)
            {
                Console.WriteLine($"Es mayor de edad ({edad})");
            }
            else
            {
                Console.WriteLine($"No es mayor de edad ({edad})");
            }
        }
    }
}
