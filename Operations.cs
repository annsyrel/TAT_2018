using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV8
{
    public class Operations
    {
        
        public delegate void MethodContainer(Man a);

        public event MethodContainer onCount;

        public void LastNames(List<Man> l)
        {
            Man a = l[l.Count-1];
            int j = 0;
            while(l.Count-1 > j)
            {
                if (a.LastName == l[j].LastName)
                {
                    onCount(l[j]);
                }
                j++;
            }
        }

        public virtual void MiddleAge(List<Man> m)
        {
            double allAge = 0;
            foreach (Man i in m)
            {
                allAge+=i.Age;
            }
            allAge /= m.Count;
            Console.WriteLine("Middle age: " + allAge);
        }

        public virtual void OlderUser(List<Man> m)
        {
            var a = m[0];
            foreach(var i in m)
            {
                if(a.Age <= i.Age)
                {
                    a = i;
                }
            }
            Console.WriteLine(a.LastName + " " +a.FirstName);
        }

        public virtual void PopularName(List<Man> m)
        {
            var women = new List<Man>();
            foreach(Man i in m)
             {
                if(i.Gender == "female")
                {
                    women.Add(i);
                }
            }
            int[] c = new int[women.Count];
            int k = 0;
            foreach(Man i in women)
            {
                foreach(Man j in women)
                {
                    if(i.FirstName == j.FirstName)
                    {
                        c[k]++;
                    }
                }
                c[k]--;
                k++;
            }
            Console.WriteLine("The most popular name is " + women[IndexOfMaxElement(c)]);
        }

        public int IndexOfMaxElement(int[] a)
        {
            int max = a[0];
            int index = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > max)
                {
                    max = a[i];
                    index = i;
                }
            }
            return index;
        }
    }
}
