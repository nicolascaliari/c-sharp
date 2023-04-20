using System.Text;

namespace Logica
{
    public abstract class Persona
    {
        private long dni;
        private string nombre;

        public Persona(string nombre)
        {
            this.nombre = nombre;
        }


        public Persona(long dni, string nombre)
        {
            this.dni = dni;
            this.nombre = nombre;
        }

        public long Dni
        {
            get => dni;
            set => dni = value;
        }

        public string Nombre
        {
            get => nombre;
            set => nombre = value;
        }


        public string Mostrar()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine($"Nombre: {this.nombre}");
            stringBuilder.AppendLine($"DNI: {this.dni}");
            return stringBuilder.ToString();
        }


    }
}