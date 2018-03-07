using System;

namespace DEV3
{
    class DEV3
    {
         static void Main(string[] args)
        {
            int Number, Redix;
            try
            {
                if (args.Length != 2 || args == null)
                {
                    throw new Exception("Wrong number of argumets.");
                }
                Number = int.Parse(args[0]);
                Redix = int.Parse(args[1]);
                if(Redix <=1 || Redix >= 21)
                {
                    throw new Exception("Invalid redix.");
                }
                ConvertFrom10ToAnyRedix.Converte(Number, Redix);
            }
            catch (ArgumentException)
            {
                Console.Write("Write your numbers");
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            };
        }
    }
}
