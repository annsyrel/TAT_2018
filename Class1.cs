using System;
namespace ConvertDecimalToAnyRadix
{
    class ConvertFrom10ToAnyRadix  // This class consist of method for convertation numbers to other numeral system
    {
        public  string Convertation(int a, int b) // This method is for convertation numbers to other numeral system
        {

            string result = string.Empty;
            string ch = ("0123456789ABCDEFGH");

            while (a > 0)
            {
                result = ch[a % b] + result;
                a /= b;
            }
            return result;
        }
    }
}
