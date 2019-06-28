using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortgeschritteneThemen
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Enumerator
            //Zug ICE = new Zug();
            //ICE.Wagons = new List<Wagon>();
            //ICE.Wagons.Add(new Wagon(21, true));
            //ICE.Wagons.Add(new Wagon(22, false));
            //ICE.Wagons.Add(new Wagon(23, true));
            //ICE.Wagons.Add(new Wagon(24, true));
            //ICE.Wagons.Add(new Wagon(25, false));

            //foreach (Wagon wagon in ICE)
            //{
            //    string klimaAusgabe = (ICE.Wagons[0].Klimatisiert) ? "klimatisiert" : "nicht klimatisiert";

            //    Console.WriteLine($"Der Wagon mit der Nummer {wagon.Wagonnummer} ist {klimaAusgabe}");
            //}

            //// Tenärer Operator:
            ////string text;
            ////if (ICE.Wagons[0].Klimatisiert)
            ////    text = "Ja";
            ////else
            ////    text = "Nein";

            ////            (Bedingung) ? true : false;
            //string text = (ICE.Wagons[0].Klimatisiert) ? "Ja" : "Nein";
            //Console.WriteLine(text);
            #endregion

            #region Indexer

            //int[] zahlen = { 12, 12, 12, 12, 23, 23, 23 };
            //Console.WriteLine(zahlen[2]);

            //Console.WriteLine(ICE[1]); // Indexer in der Klasse definieren


            //Text meinText = new Text("Das ist ein langer Satz");

            //Console.WriteLine(meinText);
            //Console.WriteLine(meinText[2]);
            //meinText[2] = "kein";
            //Console.WriteLine(meinText);
            //Console.WriteLine(meinText[2]); 
            #endregion

            #region Operatorüberladung
            //Zug ICEnachKarlruhe = new Zug();
            //ICEnachKarlruhe.Wagons = new List<Wagon>();
            //ICEnachKarlruhe.Wagons.Add(new Wagon(21, true));
            //ICEnachKarlruhe.Wagons.Add(new Wagon(22, false));
            //ICEnachKarlruhe.Wagons.Add(new Wagon(23, true));
            //ICEnachKarlruhe.Wagons.Add(new Wagon(24, true));
            //ICEnachKarlruhe.Wagons.Add(new Wagon(25, false));

            //Zug ICEnachZürich = new Zug();
            //ICEnachZürich.Wagons = new List<Wagon>();
            //ICEnachZürich.Wagons.Add(new Wagon(31, true));
            //ICEnachZürich.Wagons.Add(new Wagon(32, true));
            //ICEnachZürich.Wagons.Add(new Wagon(33, true));
            //ICEnachZürich.Wagons.Add(new Wagon(34, true));
            //ICEnachZürich.Wagons.Add(new Wagon(35, true));

            //Zug neuerICE = ICEnachKarlruhe + ICEnachZürich;  
            #endregion

            #region Erweiterungsmethoden
            //string meinText = "Hallo Welt !";

            //Console.WriteLine(meinText.Umdrehen());

            //// In Wirklichkeit:
            //// Erweiterungsmethoden.Umdrehen(meinText);

            //Console.WriteLine(12345.Verdoppeln());

            //// Name der Erweiterungsmethode identisch mit dem Namen einer Methode:
            //Zug ICE = new Zug();
            //var zustand = ICE.Fahren();
            //Console.WriteLine(zustand); // original wird ausgeführt 
            #endregion

            string[] personen = { "Tom Ate","Anna Nass", "Peter Silie", "Franz Ose","Martha Pfahl"};

            string result = personen.Where(x => x.StartsWith("A"))
                                    .OrderByDescending(x => x)
                                    .First();

            // https://code.msdn.microsoft.com/101-LINQ-Samples-3fb9811b

#if DEBUG
            Console.WriteLine("LOGGING");
#endif
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("---FortgeschrittenesENDE---");
            Console.ReadKey();
        }



        public static int Add(int z1, int z2)
        {
            return z1 + z2;
        }

        public static int Sub(int z1, int z2) => z1 - z2;

        private int myVar;

        public int MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }

        private int myvar2;


        public Program(string eingabe) => Eingabe = eingabe;
        private string Eingabe;
    }
}
