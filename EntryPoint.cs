using System;


namespace task_1
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, world!");
            Console.WriteLine("And hi again");
            Random rnd = new Random();
            int value = rnd.Next(5, 50);
            for(int i=0; i<value; i++)
            {
                Console.Write("!");
            }
        }
    }
}
