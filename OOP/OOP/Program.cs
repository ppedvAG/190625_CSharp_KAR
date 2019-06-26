using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();
            Person p1 = new Person();

            p1.SetVorname("Ka");
            Console.WriteLine(p1.GetVorname());

            p1.SetVorname("Kai");
            Console.WriteLine(p1.GetVorname());

            

            Console.WriteLine("---ENDE---");
            Console.ReadKey();
        }
    }
}
