using System.Text;

namespace ClassLibrary1
{
    public class Ingresante
    {
        private string[] cursos;
        private string direccion;
        private int edad;
        public string genero;
        private string nombre;
        public string _pais;


        public Ingresante(string nombre, string direccion, string genero, string pais, string[] cursos, int edad)
        {
            this.nombre = nombre;
            this.direccion = direccion;
            this.genero = genero;
            this._pais = pais;
            this.cursos = cursos;
            this.edad = edad;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Datos del ingresante: ");

            sb.AppendLine($"Nombre : {nombre}");
            sb.AppendLine($"Direccion: {direccion} ");
            sb.AppendLine($"Genero: {genero} ");
            sb.AppendLine($"Pais: {_pais} ");
            sb.AppendLine($"Cursos: ");
            foreach (var item in cursos)
            {
                sb.AppendLine($"{item}");

            }
            sb.AppendLine($"Edad: {edad} ");

            return sb.ToString();   
        }
    }
}