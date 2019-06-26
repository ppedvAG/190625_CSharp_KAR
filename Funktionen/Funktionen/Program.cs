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

            MachEtwas();
            MachEtwas();
            MachEtwas();

            MachEtwas("Hallo Welt");

            GibMirEineZufallszahl(100); // rückgabe verfällt

            int zufallsZahl = GibMirEineZufallszahl(0, 1000);
            Console.WriteLine(zufallsZahl);

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
    }
}
