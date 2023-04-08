using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria
{
    internal class Cliente
    {
        private string Domicilio { get ; set; }
        private string Nombre { get; set; }
        private string Apellido { get; set; }
        private string Telefono { get; set; }

        public List<Mascota> Mascotas { get; set; }
        // public Mascota[] Mascotas { get; set; }



        public Cliente(string Domicilio, string Nombre, string Apellido, string Telefono)
        {
            this.Telefono = Telefono;   
            this.Apellido = Apellido;   
            this.Nombre = Nombre;
            this.Domicilio = Domicilio;
            //Mascotas = new Array<Mascota>();

            Mascotas = new List<Mascota>();
            // this.mascota = mascota;

        }

        public void AddPet(Mascota pet)
        {
            Mascotas.Add(pet);
        }

  
        public static Cliente AgregarCliente()
        {

            string name = Input.ValidateString("Ingrese el nombre del cliente: ", 4, 10);
            string surname = Input.ValidateString("Ingrese el apellido del cliente: ", 4, 10);
            string adress = Input.ValidateAdress("Ingrese el domicilio del cliente: ");
            string phoneNumber = Input.ValidatePhoneNumber("Ingrese el telefono del cliente: ");
            Cliente client = new Cliente(adress, name, surname, phoneNumber);

            while (Input.ValidateAnswer("Desea agregar una mascota? (s/n)"))
            {
                Mascota mascota = Mascota.AddPet();

                client.AddPet(mascota);
            }
            return client;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Nombre: {Nombre} {Apellido}\n");
            sb.Append($"Domicilio: {Domicilio}\n");
            sb.Append($"Teléfono: {Telefono}\n");
            sb.Append("Mascotas:\n");
            foreach (Mascota mascota in Mascotas)
            {
                sb.Append(mascota.MostrarMascota());
            }
            return sb.ToString();
        }
    }
}
