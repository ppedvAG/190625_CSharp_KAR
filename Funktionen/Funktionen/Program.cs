using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funktionen
{
    class Program
    {
        static void Main(string[] args)
        {
            // STRG + D => Duplizieren
            // STRG + C => (Ohne Markierung) Ganze Zeile Kopieren
            // STRG + V => (Ohne Markierung) Ganze Zeile einfügen
            // STRG + X => (Ohne Markierung) Ganze Zeile ausschneiden
            // ALT + Pfeiltaste => Codezeile rauf/runter verschieben

            // Programmstart:
            // F5 -> Start mit Debugger
            // STRG + F5 -> Start ohne Debugger
            // F10 und F11 -> Starte im Einzelschrittmodus
            //   -> F10: Methoden überspringen
            //   -> F11: In Methoden hineinspringen

            MachEtwas();
            MachEtwas();
            MachEtwas();


            Console.WriteLine("---ENDE---");
            Console.ReadKey();
        }

        public static void MachEtwas() // void => keine Rückgabe
        {
            Console.WriteLine("Ich mache etwas ...");
        }

    }
}
