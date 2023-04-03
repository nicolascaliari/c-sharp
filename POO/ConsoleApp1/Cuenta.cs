using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prestamo
{
    internal class Cuenta
    {

        //Atributos
        private string titular;
        private int cantidad;

        //Constructor
        public Cuenta(string titular, int cantidad)
        {
            this.titular = titular;
            this.cantidad = cantidad;
        }

        //Metodos
        public string getTitular()
        {
            return titular;
        }

        public int getCantidad()
        {
            return cantidad;
        }


        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Los datos son: ");
            sb.AppendLine($"El titular es : {titular}");
            sb.AppendLine($"La cantidad es : {cantidad}");

            return sb.ToString();
        }

        public void Ingresar(int monto)
        {
            this.cantidad += monto;
        }

        public void Retirar(int retirar)
        {
            this.cantidad -= retirar;
        }
    }
}
