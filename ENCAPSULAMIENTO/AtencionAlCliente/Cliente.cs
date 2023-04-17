using System.Data.Common;

namespace AtencionAlCliente
{
    public class Cliente
    {
       private string _nombre;
       private int _numero;


        public string nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public int numero
        {
            get { return _numero; }
        }


        public Cliente(int numero)
        {
            _numero = numero;
        }


         public Cliente( int numero, string nombre):this(numero)
        {
            _numero = numero;
            _nombre = nombre;
         }


        public static bool operator ==(Cliente a, Cliente b)
        {
            return (a.numero == b.numero);
        }


        public static bool operator !=(Cliente a, Cliente b)
        {
            return !(a == b);
        }

    }
}