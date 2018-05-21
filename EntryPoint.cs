using System;

namespace Task_2
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            try
            {
                try
                {
                    double lenght = Convert.ToDouble(args[0]), width = Convert.ToDouble(args[1]);
                    Console.WriteLine(value: "Square of a rectangle: " + (lenght * width));
                }
                catch (FormatException)
                {
                    Console.WriteLine("Enter right numbers");
                }
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Enter lenght and width.");
            }
            Console.ReadKey();

        }
    }
}
