﻿using System;
using System.Text;


namespace test
{
    class GetEvenIndexSymbol // Get symbol with even index and output them
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("you need to pass input param!");
                Console.ReadLine();
            }

            string s = args[0];
            StringBuilder newline = new StringBuilder();

            for (int i = 0; i < s.Length; i+=2)
            {
                    newline.Append(s[i]);
            }

            Console.Write(newline);
            Console.ReadLine();

        }
    }
}