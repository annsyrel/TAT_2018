using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_1
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0) {
                Console.WriteLine("requires input param!");
                Console.ReadKey();

                return;
            }

            string s = args[0];


            int count = 1;
            int max_count = 1;

            for (int i = 0; i < s.Length-1; i++)
            {
                if (s[i] == s[i+1])
                {
                    count++;
                }
                else
                {
                    count = 1;
                }

                if(max_count < count)
                {
                    max_count = count;
                }

            }
            
            string res = String.Format("String '{0}' has max {1} equal elements in series", s, max_count);
            Console.WriteLine(res);

            Console.ReadKey();
        }


    }
}
