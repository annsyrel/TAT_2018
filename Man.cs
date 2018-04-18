using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV8
{
    public class Man
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }

        public Man()
        {
            Console.Write("Last name: ");
            this.LastName = Console.ReadLine();
            Console.Write("First name: ");
            this.FirstName = Console.ReadLine();
            Console.Write("Gender: ");
            this.Gender = Console.ReadLine();
            Console.Write("Age: ");
            this.Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
        }        
    }
}
