using System;
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

            #region Ausgabe von Strings
            //int zahl1 = 5;
            //int zahl2 = 10;

            //int ergebnis = zahl1 + zahl2;

            //// Variante 1:
            //Console.WriteLine("Die Summe von " + zahl1 + " und " + zahl2 + " ist " + ergebnis);
            //// Variante 2;
            //// cw + TAB + TAB
            //Console.WriteLine("Die Summe von {0} und {1} ist {2}",zahl1,zahl2,ergebnis);
            //// Variante 3:
            //Console.WriteLine($"Die Summe von {zahl1} und {zahl2} ist {ergebnis}");
            //Console.WriteLine($"Die Summe von {zahl1} und {zahl2} ist {zahl1 + zahl2}"); 
            #endregion

            #region Konvertieren
            //string eingabe = Console.ReadLine(); // eine ganze Zeile einlesen

            //// Variante 1:
            //int zahl1 = int.Parse(eingabe);
            //// Variante 2:
            //int zahl2 = Convert.ToInt32(eingabe);

            //Console.WriteLine(zahl1 + zahl2);

            //// Implizites Konvertieren:
            //int z1 = 42;            // Int32 Wertebereich
            //long großeZahl = 5;     // Int64 Wertebereich

            //großeZahl = z1; // alles, was technisch gesehen in Int32 reinpasst, passt auch in Int64 rein

            //großeZahl = 2;
            //// z1 = großeZahl; // Kompiler-Fehler: Es "könnte" was größeres als Int32 drinnen stehen

            //// Explizit Konvertieren
            //z1 = Convert.ToInt32(großeZahl);// oder int.Parse();
            //// Cast
            //z1 = (int)großeZahl; 
            #endregion

            #region Operatoren
            //int zahl1 = 5;
            //double zahl2 = 3;

            //double ergebnis = zahl1 / zahl2;
            //Console.WriteLine(ergebnis); 
            #endregion

            #region If
            //Console.WriteLine("Bitte geben Sie eine Zahl ein:");
            //string eingabe = Console.ReadLine();

            //int zahl = Convert.ToInt32(eingabe);

            //if(zahl < 10)
            //{
            //    Console.WriteLine("kleiner als 10");
            //}
            //else if(zahl == 10)
            //    Console.WriteLine("exakt 10"); // Klammern bei einer einzelnen Zeile weglassbar
            //else
            //{
            //    Console.WriteLine("größer als 10");
            //}
            // // Environment.NewLine  // <- Macht ein NewLine wie \n\r 
            #endregion

            #region Arrays
            //int[] meinezahlen = new int[5]; // Index: 0,1,2,3,4
            //meinezahlen[0] = 9;
            //meinezahlen[1] = 18;
            //meinezahlen[2] = 3;
            //Console.WriteLine(meinezahlen[0]);

            //// ArrayInitialisierer
            //int[] zahlen = new int[] { 1, 2, 3, 4, 5 };
            //Console.WriteLine(zahlen[1]);
            //int[] megafaul = { 9, 1, 2, 3, 4 };

            //// Mehrdimensionales Array

            //int[,] schachbrett = new int[8, 8];
            //schachbrett[0, 5] = 12;

            //int[,,] dreidimensional = new int[9, 18, 27];

            //// Array in dem Arrays drinnen sind
            //int[][] arrayImArray = new int[5][];
            //arrayImArray[0] = new int[10];
            //arrayImArray[1] = new int[3];
            //arrayImArray[2] = new int[5];

            //Console.WriteLine(arrayImArray[1][3]); 
            #endregion

            Console.ReadKey(); // Alternative: ReadLine();
        }
    }
}
