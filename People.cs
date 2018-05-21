using System;
using System.Collections.Generic;

namespace task_4
{
    public class People
    {
        public string FirstName;
        public string LastName;
        public double Age;

        public People(string firstname, string lastname, double age)
        {
            FirstName = firstname;
            LastName = lastname;
            Age = age;
        }


        public void people()
        {
            Console.WriteLine("Enter First Name:");
            this.FirstName = Console.ReadLine();
            Console.WriteLine("Enter Last Name:");
            this.LastName = Console.ReadLine();
            Console.WriteLine("Enter Age:");
            this.Age = Convert.ToDouble(Console.ReadLine());
        }

        public void Output(List <People> list)
        {
            foreach (People i in list)
            {
                    Console.WriteLine(i.FirstName + " " + i.LastName + " " + i.Age);
            }
        }
    }
}
