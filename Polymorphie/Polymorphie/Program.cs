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

            Console.WriteLine("----------------Anwendungsfall----------------");
            #region Variante ohne Polymorphie
            //Grafik[] meineGrafiken = new Grafik[3];
            //meineGrafiken[0] = new Grafik() { Farbe = "Türkis" };
            //meineGrafiken[1] = g1;
            //meineGrafiken[2] = new Grafik() { Farbe = "Weiß" };

            //Kreis[] meineKreise = new Kreis[3];
            //meineKreise[0] = new Kreis(9) { Farbe = "Schwarz" };
            //meineKreise[1] = k1;
            //meineKreise[2] = new Kreis(123) { Farbe = "Grau" };

            //Rechteck[] meineRechtecke = new Rechteck[3];
            //meineRechtecke[0] = new Rechteck(10,10) { Farbe = "Kaffemilchbeige" };
            //meineRechtecke[1] = r1;
            //meineRechtecke[2] = new Rechteck(50,49) { Farbe = "Ocker" };

            //foreach (Grafik item in meineGrafiken)
            //{
            //    item.Zeichnen();
            //}

            //foreach (Kreis item in meineKreise)
            //{
            //    item.Zeichnen();
            //}

            //foreach (Rechteck item in meineRechtecke)
            //{
            //    item.Zeichnen();
            //}
            #endregion


            Grafik[] meineGrafiken = new Grafik[9];
            meineGrafiken[0] = new Grafik() { Farbe = "Türkis" };
            meineGrafiken[1] = g1;
            meineGrafiken[2] = new Grafik() { Farbe = "Weiß" };
            meineGrafiken[3] = new Kreis(9) { Farbe = "Schwarz" };
            meineGrafiken[4] = k1;
            meineGrafiken[5] = new Kreis(123) { Farbe = "Grau" };
            meineGrafiken[6] = new Rechteck(10, 10) { Farbe = "Kaffemilchbeige" };
            meineGrafiken[7] = r1;
            meineGrafiken[8] = new Rechteck(50, 49) { Farbe = "Ocker" };

            foreach (var item in meineGrafiken)
            {
                //if(item is Rechteck)
                //{
                //    var rechteck = (Rechteck)item;
                //    rechteck.Zeichnen();
                //}
                if (item is Rechteck r) // Seit C#7
                    r.Zeichnen();
                else
                    item.Zeichnen();
            }

            Console.WriteLine("---ENDE---");
            Console.ReadKey();
        }
    }
}
