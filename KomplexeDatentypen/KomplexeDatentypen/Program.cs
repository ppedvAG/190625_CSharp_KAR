﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomplexeDatentypen
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Arrays
            //int[] zahlen = { 12, 3, 6, 8, 3, 2 };
            //int[] zahlen2 = new int[1000]; 
            #endregion

            #region ArrayList  -> Vergrößert sich automatisch
            //ArrayList meineListe = new ArrayList();
            //meineListe.Add(12);
            //meineListe.Add(3);
            //meineListe.Add(new Random());
            //meineListe.Add(8);
            //meineListe.Add("alles");

            //foreach (var item in meineListe)
            //{
            //    Console.WriteLine(item);
            //}

            //// Problem: es gibt keine Typensicherheit
            //int zahl = (int)meineListe[0]; 
            #endregion

            #region List<T> -> Generische Liste
            //List<string> textListe = new List<string>();
            //textListe.Add("Hallo");
            //textListe.Add("Welt");
            //textListe.Add("!");

            //for (int i = 0; i < textListe.Count; i++) // statt Length wie beim Array heißt es in Listen Count
            //{
            //    Console.WriteLine(textListe[i]);
            //} 

            //List<int> meineZahlen = new List<int>();
            //meineZahlen.Add(12);
            //meineZahlen.Add(3);
            //meineZahlen.Add(9);
            //meineZahlen.Add(15);

            //var resultIndex = meineZahlen.IndexOf(9); // welcher index hat 9 ?
            //var resultElement = meineZahlen.ElementAt(0); // welches Element ist bei 0 ?

            #endregion

            #region Stack<T> -> LIFO-Struktur
            //Stack<int> zahlenStapel = new Stack<int>();
            //zahlenStapel.Push(12);
            //zahlenStapel.Push(9);
            //zahlenStapel.Push(3);

            //Console.WriteLine(zahlenStapel.Pop());
            //Console.WriteLine(zahlenStapel.Pop());
            //Console.WriteLine(zahlenStapel.Pop());

            //// Console.WriteLine(zahlenStapel.Pop()); // Exception 
            #endregion

            #region Queue<T> -> FIFO-Struktur
            //Queue<string> meineReihe = new Queue<string>();

            //meineReihe.Enqueue("Hallo");
            //meineReihe.Enqueue("Welt");
            //meineReihe.Enqueue("!");

            //Console.WriteLine(meineReihe.Dequeue());
            //Console.WriteLine(meineReihe.Dequeue());
            //Console.WriteLine(meineReihe.Dequeue());

            //// Console.WriteLine(meineReihe.Dequeue()); // Exception 
            #endregion

            #region Dictionary<TKey,TValue>
            //Dictionary<string, string> eu = new Dictionary<string, string>();

            //eu.Add("Österreich", "Wien");
            //eu.Add("Deutschland", "Berlin");
            //eu.Add("Frankreich", "Paris");
            //eu.Add("Italien", "Rom");
            //eu.Add("Ungarn", "Budapest");
            //eu.Add("Tschechei", "Prag");
            //eu.Add("Slowakei", "Pressburg");
            //eu.Add("Slovenien", "Laibach");

            //Console.WriteLine(eu["Italien"]);

            //foreach (var item in eu.Keys)
            //{
            //    Console.WriteLine(eu[item]);
            //}

            //// Console.WriteLine(eu.Count);

            //if(eu.ContainsKey("Großbritannien"))
            //    Console.WriteLine(eu["Großbritannien"]);
            //else
            //    Console.WriteLine("Gibts nimma ");

            //for (int i = 0; i < eu.Count; i++)
            //{
            //    string key = eu.Keys.ElementAt(i);
            //    Console.WriteLine($"Key: {key}, Value: {eu[key]}");
            //}

            //// GUID erzeugen (für einen Key interessant):
            //Console.WriteLine(Guid.NewGuid().ToString());
            #endregion

            #region Wertetypen: Wertevergleich und die Wertekopie
            //int zahl1 = 42;
            //int zahl2 = 42;

            //if(zahl1 == zahl2) // Wertevergleich
            //    Console.WriteLine("Zahlen sind gleich");
            //else
            //    Console.WriteLine("Zahlen sind nicht gleich");

            //int zahl3 = zahl1; // Wertekopie

            //if(zahl1 == zahl3)
            //    Console.WriteLine("Kopie ist gleich");
            //else
            //    Console.WriteLine("Kopie ist nicht gleich"); 
            #endregion

            Person p1 = new Person { Vorname = "Tom", Nachname = "Ate", Alter = 10, Kontostand = 10000 };
            Person p2 = new Person { Vorname = "Tom", Nachname = "Ate", Alter = 10, Kontostand = 10000 };

            if(p1 == p2) // Referenzvergleich
                Console.WriteLine("Die Personen sind gleich");
            else
                Console.WriteLine("Die Personen sind nicht gleich");

            Person p3 = p1; // Referenzkopie

            if (p1 == p3) // Referenzvergleich
                Console.WriteLine("Die Personenkopie ist identisch");
            else
                Console.WriteLine("Die Personenkopie sind nicht identisch");


            // Echter Vergleich der Werte:
            // Variante mühsam:
            // if(p1.Vorname == p2.Vorname && ....)

            if(p1.Equals(p2))
                Console.WriteLine("Die Werte sind identisch");
            else
                Console.WriteLine("Die Werte sind nicht identisch");

            Console.WriteLine("---ENDE---");
            Console.ReadKey();
        }
    }
}
