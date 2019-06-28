using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortgeschritteneThemen
{
    // Vorraussetzung 1: eine statische Klasse
    static class Erweiterungsmethoden
    {
        // Vorraussetzung 2: this-schlüsselwort
        public static string Umdrehen(this string eingabe)
        {
            StringBuilder sb = new StringBuilder(); // Klasse, die sich speziell für das Zusammensetzen von Zeichenketten eignet

            for (int i = eingabe.Length - 1; i >= 0; i--)
            {
                sb.Append(eingabe[i]);
            }
            return sb.ToString();
        }

        public static int Verdoppeln(this int zahl)
        {
            return zahl * 2;
        }

        public static bool Fahren(this Zug zug)
        {
            return true; // wir fahren ....
        }
    }
}
