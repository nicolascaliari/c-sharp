using ClassLibrary3;
using System.Text;

namespace Maquina_expendedora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MaquinaExpendedora maquina = new MaquinaExpendedora();
            maquina.EelegirProducto();
        }
    }
}