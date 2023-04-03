using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversor_binario
{
    internal class Conversor
    {

        public string ConvertirDecimalABinario(int numeroEntero) {

            string binaryString = Convert.ToString(numeroEntero, 2);
            
            return binaryString;
        }

     //   public int ConvertirBinarioADecimal(int numeroEntero) { 
        
        
       // }
    }
}
