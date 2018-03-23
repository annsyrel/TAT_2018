using System;
using System.Collections.Generic;

namespace DEV_6
{
   /// <summary>
   /// Class contains functions 
   /// </summary>
   class Function
    {
        /// <summary>
        /// Method for counting average price
        /// </summary>
        /// <param name="items"></param>
        public static void Average(List<Product> items)
        {
            double AverageCost = 0;
            foreach(Product i in items)
            {
                AverageCost += i.Pcost;
            }
            AverageCost /= items.Count;
            Console.WriteLine("Average price: " + AverageCost);
        }

        /// <summary>
        /// Method for counting types of products
        /// </summary>
        /// <param name="item"></param>
        /// <param name="type"></param>
        public static void AverageType(List<Product> item, string type)
        {
            double cost = 0;
            int j = 0;
            foreach(Product i in item)
            {
                if(i.Ptype == type)
                {
                    cost += i.Pcost;
                    j++;
                }
            }
            cost /= j;
            Console.WriteLine("Average price " + type + ": " + cost);
        }

        /// <summary>
        /// Method for counting all items
        /// </summary>
        /// <param name="items"></param>
        public static void countAll(List<Product> items)
        {
            int all = 0;
            foreach(Product i in items)
            {
                all += i.Pcount;
            }
            Console.WriteLine("Count of all itmes: " + all);
        }

       /// <summary>
       /// Method for counting one type items
       /// </summary>
       /// <param name="items"></param>
       public static void countType(List<Product> items)
        {
            int count = items.Count;
            for(int i = 0; i < items.Count; i++)
            {
                for(int j=1+i; j < items.Count; j++)
                {
                    if(items[i].Ptype == items[j].Ptype)
                    {
                        count--;
                    }
                }
            }
            Console.WriteLine("count types: " + count);
        }
    }
}
