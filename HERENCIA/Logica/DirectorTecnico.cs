using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class DirectorTecnico : Persona
    {
        private DateTime fechaNacimiento;

        private DirectorTecnico(string nombre) : base(nombre)
        {
            this.Nombre = nombre;
        }

        public DirectorTecnico(string nombre, int dni , DateTime fechaNacimiento): base( dni ,nombre)
        {
            this.fechaNacimiento = fechaNacimiento;
        }



        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Mostrar());
            sb.AppendLine($"Fecha de nacimiento: {this.fechaNacimiento}");
            return sb.ToString();
        }


        public static bool operator ==(DirectorTecnico dt, DirectorTecnico dt2)
        {
            bool retorno = false;
            if (dt.Nombre == dt2.Nombre && dt.fechaNacimiento == dt2.fechaNacimiento)
            {
                retorno = true;
            }
            return retorno;

        }

        public static bool operator !=(DirectorTecnico dt, DirectorTecnico dt2)
        {
            return !(dt == dt2);
        }
    }
}
