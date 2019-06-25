﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalloWelt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hallo Welt");

            #region Variablen
            //int zahl1 = 42; // Direkt zuweisen
            //Console.WriteLine(zahl1);

            //int zahl2; // Standardwert: 0
            //// ...
            //zahl2 = 12;
            //Console.WriteLine(zahl2);

            //// Mehrere Variablen in einer Zeile deklarieren:
            //int z1, z2, z3;
            //// Direkt Werte vergeben:
            //int z4 = 4, z5 = 5, z6 = 6;

            //string text = "Demo";
            #endregion

            int zahl1 = 5;
            int zahl2 = 10;

            int ergebnis = zahl1 + zahl2;

            // Variante 1:
            Console.WriteLine("Die Summe von " + zahl1 + " und " + zahl2 + " ist " + ergebnis);
            // Variante 2;
            // cw + TAB + TAB
            Console.WriteLine("Die Summe von {0} und {1} ist {2}",zahl1,zahl2,ergebnis);
            // Variante 3:
            Console.WriteLine($"Die Summe von {zahl1} und {zahl2} ist {ergebnis}");
            Console.WriteLine($"Die Summe von {zahl1} und {zahl2} ist {zahl1 + zahl2}");

            Console.ReadKey(); // Alternative: ReadLine();
        }
    }
}
