using System;
namespace DEV3
{
    class ConvertFrom10ToAnyRedix
    {
        public static void Converte(int a, int b)
        {
            string result = string.Empty;
            char[] elements =  { '0','1','2','3','4','5','6','7','8','9',
            'A','B','C','D','E','F','G','H','I','J'};

            while (a > 0)
            {
                result = elements[a % b] + result;
                a /= b;
            }

            Console.WriteLine(result);            
        }
    }
}
