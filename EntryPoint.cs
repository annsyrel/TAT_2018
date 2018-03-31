using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_7
{
    class EntryPoint
    {
        public static void Main(string[] args)
        {
            ConsoleMenu a = new ConsoleMenu();
            a.SearchTheItem();
            Console.ReadKey();
        }
    }
}
