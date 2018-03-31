using System;
using System.Runtime.Serialization.Json;

namespace DEV_7
{
    /// <summary>
    /// Class for user menu
    /// </summary>
    public class ConsoleMenu
     {

        DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(Car[]));
        Output a = new Output();
        Search find = new Search();

        /// <summary>
        /// Method for defenition users requests
        /// </summary>
        public void SearchTheItem()
        {
            bool question = true;
            Console.WriteLine("Do U want to start? ");
            if (Console.ReadLine() == "no") question = false;
            while (question)
            {
                Console.WriteLine("Do U want to look at all catalog? ");
                if (Console.ReadLine() != "yes")
                {
                    Console.WriteLine("Do U want to look at stock? ");
                    if (Console.ReadLine() != "yes")
                    {
                        Console.WriteLine("Do U want to seacrh? ");
                        if(Console.ReadLine() == "yes")
                        {
                            find.search_catalog();
                        }
                        else
                        {
                            question = false;
                        }
                    }
                    else
                    {                            
                        a.output_stock();
                    }
                }
                else
                {
                    a.output_catalog();
                }                    
            }
            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine("I'm CODE HEEEROOO!!! ");
            }
        }        
     }
    
}
