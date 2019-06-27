using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphie
{
    // Anwendungsfall Verstecken: Logger dranhängen
    class CustomRandomGenerator : Random
    {
        public int Next(int min, int max)
        {
            Console.WriteLine("Logeintrag vor Next");
            var result = base.Next(min, max);
            Console.WriteLine("Logeintrag nach Next");
            return result;
        }
    }
}
