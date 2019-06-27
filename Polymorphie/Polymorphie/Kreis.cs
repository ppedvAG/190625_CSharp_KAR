using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphie
{
    class Kreis : Grafik
    {
        public Kreis(int radius)
        {
            Radius = radius;
        }
        public int Radius { get; set; }

        // Override von Zeichnen
        public override void Zeichnen()
        {
            Console.WriteLine($"Ein Kreis mit der Farbe {Farbe} und dem Radius {Radius} wird gezeichnet");
        }
    }
}
