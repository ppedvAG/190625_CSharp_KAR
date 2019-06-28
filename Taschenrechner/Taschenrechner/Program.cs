using OOP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taschenrechner_Lib;

namespace TaschenrechnerKonsole // Namespace == Projektname
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = Taschenrechner.Add(12, 4);

            Console.WriteLine(result);

            

            Console.WriteLine("---ENDE---");
            Console.ReadKey();
        }
    }
}
