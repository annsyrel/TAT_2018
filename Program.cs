using System;

namespace ConvertDecimalToAnyRadix
{
    class DEV3 
    {
        static void Main(string[] args)
        {
            int NumberForConvertation, RadixOfConvertation;
            var a = new ConvertFrom10ToAnyRadix();
            try
            {
                if (args.Length != 2 || args == null)
                {
                    throw new Exception("Wrong number of argumets.");
                }

                NumberForConvertation = int.Parse(args[0]);
                RadixOfConvertation = int.Parse(args[1]);

                if (RadixOfConvertation <= 1 || RadixOfConvertation >= 21)
                {
                    throw new Exception("Invalid radix.");
                }

                
                string answer = a.Convertation(NumberForConvertation, RadixOfConvertation);
                Console.WriteLine(answer);
                Console.ReadKey();
            }
            catch (ArgumentException)
            {
                Console.Write("Write your numbers");
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }
        }
    }
}
