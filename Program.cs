using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV8
{
    class Program
    {

        static void Main(string[] args)
        {            
            Operations o = new Operations();
            Handler Handler1 = new Handler();
            o.onCount += Handler1.SimilarLastName;
            var m = new List<Man>();
            bool a = true;
            while (a)
            {
                Man i = new Man();
                m.Add(i);
                o.LastNames(m);
                Console.WriteLine("Do U want to add person? ");
                if (Console.ReadLine() == "no")
                {
                    a = false;
                }
            }
            o.MiddleAge(m);
            o.OlderUser(m);
            o.PopularName(m);
            Console.ReadKey();
        }
    }
}
