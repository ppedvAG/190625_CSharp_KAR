using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphie
{
    class Program
    {
        static void Main(string[] args)
        {
            Grafik g1 = new Grafik();
            g1.Farbe = "Rot";
            Kreis k1 = new Kreis(20);
            k1.Farbe = "Gelb";
            Rechteck r1 = new Rechteck(20,10);
            r1.Farbe = "Grün";

            g1.Zeichnen();
            k1.Zeichnen();
            r1.Zeichnen();

            // Polymorphie: Ein Objekt der Subklasse kann wie ein Objekt der Basisklasse verwendet werden

            Grafik g2 = new Kreis(50);
            g2.Farbe = "Orange";
            g2.Zeichnen();

            // Casten
            Kreis k2 = (Kreis)g2; // ich weiß das in wirklichkeit ein kreis drinnen ist
            k2.Zeichnen();

            // as - Operator
            Kreis k3 = g2 as Kreis;
            k3.Zeichnen();

            // Unterschied:
            // Wenn der Cast fehlschlägt: InvalidCastException
            // as: null

            // Lösung: is - Operator
            if(g2 is Kreis)
            {
                // .... mach daraus einen Kreis
            }

            Console.WriteLine("---Verstecken---");


            Grafik g4 = new Rechteck(50, 100);
            g4.Farbe = "Violett";
            g4.Zeichnen();

            Rechteck r4 = (Rechteck)g4;
            r4.Zeichnen();

            Console.WriteLine("---ENDE---");
            Console.ReadKey();
        }
    }
}
