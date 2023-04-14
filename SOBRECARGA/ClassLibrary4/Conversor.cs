using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary4
{
    public class Conversor
    {

        //methods to convert from decimal to binary and viceversa
        public static string ConvertDecimalToBinary(double number)
        {
            return Convert.ToString((int)number, 2);
        }
        public static double ConvertBinaryToDecimal(string number)
        {
            return Convert.ToInt32(number, 2);
        }

 
    }
}
