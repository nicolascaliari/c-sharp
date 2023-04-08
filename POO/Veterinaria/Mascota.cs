using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Veterinaria
{
    internal class Mascota
    {
        public string Especie
        {
            get => _Especie;
            set => _Especie = value;
        }

        private string _Especie { get; set; }
        private string NombreMascota { get; set; }
        private DateTime FechaDeNacimiento { get; set; }

        
        public Mascota(string Especie, string NombreMascota, DateTime FechaDeNacimiento)
        {
            _Especie   = Especie;
            this.NombreMascota = NombreMascota; 
            this.FechaDeNacimiento = FechaDeNacimiento;
        }


        public static Mascota AddPet()
        {
            string species = Input.ValidateString("Ingrese la especie de la mascota: ", 4, 10);
            string name = Input.ValidateString("Ingrese el nombre de la mascota: ", 4, 10);
            DateTime birthDate = Input.ValidateDate("Ingrese la fecha de nacimiento de la mascota (dd/mm/yyyy): ");
            Mascota pet = new(species, name, birthDate);
         //   while (Input.ValidateAnswer("Desea agregar una vacuna? (s/n)"))
        //    {
        //        pet.AddVaccine();
        //    }
            return pet;
        }


        public string MostrarMascota()
        {
            StringBuilder sb = new();
            sb.AppendLine($"Mascota. \nEspecie: {Especie} - Nombre: {NombreMascota} -Fecha de cumpleaños: {FechaDeNacimiento}");
            sb.AppendLine("Vacunas:");
          //  foreach (Vaccine vaccine in Vaccines)
         //   {
         //       sb.AppendLine(vaccine.ToString());
         //   }
            return sb.ToString();
        }
    }
}
