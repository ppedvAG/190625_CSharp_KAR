using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphie
{
    // STRG + Shift + A  => Dialog für "Neues Item" öffnen
    class Grafik
    {
        public string Farbe { get; set; }
        public virtual void Zeichnen()
        {
            Console.WriteLine($"Eine Grafik mit der Farbe {Farbe} wird gezeichnet" );
        }
    }
}
