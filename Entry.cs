using System;
using System.Collections.Generic;

namespace DEV_6
{
    class Entry
    {
        /// <summary>
        /// Call methods for programm
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {           
            List<Product> items = new List<Product>();
            bool add = true;
            while(add)
            {
                string[] attr = null;
                attr = Console.ReadLine().Split(' ');
                items.Add(new Product(attr[0], attr[1], Convert.ToInt32(attr[2]), Convert.ToDouble(attr[3])));
                Console.WriteLine("Do U want one more item?(0/1)");
                if(Console.ReadLine()== "0")
                {
                    add = false;
                }
            }
            while (true)
            {
                string func = null;
                Console.WriteLine("Enter U comannd: ");
                func = Console.ReadLine();
                if (func == "count all")
                {
                    Function.countAll(items);
                }
                else
                {
                    if(func == "average price")
                    {
                        Function.Average(items);
                    }
                    else
                    {
                        if (func == "count types")
                        {
                            Function.countType(items);
                        }
                        else
                        {
                            if (func == "exit")
                            {
                                break;
                            }
                            else
                            {
                                foreach(Product i in items)
                                {
                                    string type = "average price ";
                                    type += i.Ptype;
                                    if(func == type)
                                    {
                                        Function.AverageType(items, i.Ptype);
                                        break;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
