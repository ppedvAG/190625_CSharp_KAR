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

            // Dokumentation erstellen:
            // Einstellungen -> Build -> XML Documentation File - Option aktivieren

            //MachEtwas();
            //MachEtwas();
            //MachEtwas();

            //MachEtwas("Hallo Welt");

            //GibMirEineZufallszahl(100); // rückgabe verfällt

            //int zufallsZahl = GibMirEineZufallszahl(0, 1000);
            //Console.WriteLine(zufallsZahl);


            //int meineZahl = 12;

            //int veränderteZahl = VerändereDieZahl(ref meineZahl);

            //Console.WriteLine($"MeineZahl: {meineZahl}");
            //Console.WriteLine($"VeränderteZahl: {veränderteZahl}");


            int ergebnis = 0;
            // bool erfolg = KonvertiereEtwas("123", ref ergebnis);
            bool erfolg = KonvertiereEtwas("123", out ergebnis);

            Console.WriteLine(erfolg);
            Console.WriteLine(ergebnis);

            Console.WriteLine(Addieren(3,4));
            Console.WriteLine(Addieren(3,4,6,4,2,3,5,7,78,9654));

            Console.WriteLine("---ENDE---");
            Console.ReadKey();
        }
        // Einzeilig
        /* 
         * 
         * Mehrzeilig
         */
        // Dokumentationskommentar: Über einer Klasse oder einer Methode /// schreiben

        #region Funktionen
        /// <summary>
        /// Diese Methode macht etwas
        /// </summary>
        public static void MachEtwas() // void => keine Rückgabe
        {
            Console.WriteLine("Ich mache etwas ...");
        }

        /// <summary>
        /// Diese Methode macht etwas mit einem String-Parameter
        /// </summary>
        /// <param name="text">Der Inhalt dieses Parameters wird in die Konsole geschrieben</param>
        public static void MachEtwas(string text)
        {
            Console.WriteLine($"Ich mache etwas mit einem Text: {text} ...");
        }
        public static int GibMirEineZufallszahl()
        {
            Random generator = new Random();
            return generator.Next(1, 10);
        }
        public static int GibMirEineZufallszahl(int maxValue)
        {
            Random generator = new Random();
            return generator.Next(1, maxValue);
        }
        public static int GibMirEineZufallszahl(int minimum, int maximum)
        {
            Random generator = new Random();
            return generator.Next(minimum, maximum);
        }
        #endregion


        public static int VerändereDieZahl(ref int zahl) // Ref -> Es wird eine Referenz auf die Variable übergeben
        {
            zahl *= 50;
            return zahl;
        }

        // out funktioniert wie ref mit dem Unterschied, dass eine neuzuweisung ERZWUNGEN wird
        // bei ref kann man einen wert setzen, man muss aber nicht ...
        public static bool KonvertiereEtwas(string eingabe,out int ergebnis)
        {
            // konvertiert ....
            ergebnis = int.Parse(eingabe);
            return true; // War die Konvertierung erfolgreich ? 
        }

        // in -> funktioniert wie ref, macht aber die Variable schreibgeschützt
        public static int VerändereDieReadonlyZahl(in int zahl)
        {
            // zahl *= 50; // <- wirft einen Fehler beim setzen der Variable
            return zahl;
        }

        //public static int Addieren(int z1, int z2)
        //{
        //    return z1 + z2;
        //}
        //public static int Addieren(int z1, int z2, int z3)
        //{
        //    return z1 + z2 + z3;
        //}
        //public static int Addieren(int z1, int z2, int z3, int z4)
        //{
        //    return z1 + z2 + z3 + z4;
        //}

        public static int Addieren(params int[] alleZahlen)
        {
            return alleZahlen.Sum();
        }

    }
}
