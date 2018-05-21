using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task_4
{
    public class AgeCounter
    {
        /// <summary>
        /// Method for counting middle age
        /// </summary>
        /// <param name="items"></param>
        public void MiddleAge(List<People> person)
        {
            double MiddleAge = 0;
            foreach (People i in person)
            {
                MiddleAge += i.Age;
            }
            MiddleAge /= person.Count;
            Console.WriteLine("Middle age: " + MiddleAge);
        }

        public void SeniorAge(List<People> person)
        {
            double max = person.Max(a => a.Age);
            var result = person.FirstOrDefault(a => a.Age == max);
            Console.WriteLine("The senior age: " + result.Age);
        }

        public void YoungerAge(List<People> person)
        {
            double min = person.Min(a => a.Age);
            var result = person.FirstOrDefault(a => a.Age == min);
            Console.WriteLine("The younger age: " + result.Age);
        }


    }
}

