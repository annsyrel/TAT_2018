using System;
using System.Collections.Generic;



namespace task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            bool key = false;
            List<People> persons = new List<People>();
            People person = new People();
            while (!key)
            {
                Console.WriteLine("Do U want to add person? ");
                if (Console.ReadLine() != "no")
                {
                    People man = new People();
                    man.people();
                    persons.Add(man);
                }
                else
                {
                    key = true;
                }
            }
            person.Output(persons);
            AgeCounter age = new AgeCounter();
            age.MiddleAge(persons);
            age.SeniorAge(persons);
            age.YoungerAge(persons);
        }
    }
}


    