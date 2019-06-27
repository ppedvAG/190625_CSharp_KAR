using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphie
{
    class Rechteck : Grafik
    {
        public Rechteck(int höhe, int breite)
        {
            Höhe = höhe;
            Breite = breite;
        }

        public int Höhe { get; set; }
        public int Breite { get; set; }

        // Verstecken 
        // Vorteil vom Verstecken: man kann ALLES verstecken
        public new void Zeichnen() // new-schlüsselwort ist optional
        {
            Console.WriteLine($"Ein Rechteck mit der Höhe {Höhe}, der Breite {Breite} und der Farbe {Farbe} wird gezeichnet");
        }
    }
}
