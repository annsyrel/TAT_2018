using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV8
{
    class Handler
    {
        public void SimilarLastName(Man i)
        {
            Console.Write("Last name: ");
            Console.WriteLine(i.LastName);
            Console.Write("First name: ");
            Console.WriteLine(i.FirstName);
            Console.Write("Gender: ");
            Console.WriteLine(i.Gender);
            Console.Write("Age: ");
            Console.WriteLine(i.Age);
            Console.WriteLine();
        }
    }
}
