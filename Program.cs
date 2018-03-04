using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class GetEvenIndexSymbol // Get symbol with even index and output them
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("you need to pass input param!");
                Console.ReadKey();

                return;
            }



            string s = args[0];
            StringBuilder newline = new StringBuilder();

            for (int i = 0; i < s.Length; i++)
            {
                if (i % 2 == 0)
                {
                    newline.Append(s[i]);


                }


            }
            Console.Write(newline);
            Console.ReadKey();
        }
    }
}