using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Person
            //Random generator = new Random();
            //Person p1 = new Person();

            ////p1.SetVorname("Ka");
            ////Console.WriteLine(p1.GetVorname());

            ////p1.SetVorname("Kai");
            ////Console.WriteLine(p1.GetVorname());

            //p1.Vorname = "Peter";
            //Console.WriteLine(p1.Vorname);
            //Console.WriteLine(p1.Kontostand);

            //p1.Alter = 10;
            //p1.Alter = 200; 
            #endregion

            Fahrzeug audi = new Fahrzeug();
            audi.Inhaber = new Person("Tom","Ate");
            //audi.Inhaber = new Person();
            //audi.Inhaber.Vorname = "Tom";
            //audi.Inhaber.Nachname = "Ate";
            audi.Inhaber.Alter = 80;

            // Objektinitialisierer
            // Array: int[] zahlen = new int[] { 12, 12, 12, 12, 12 };
            // Objekt: Person p1 = new Person() { Vorname = "10", Nachname = "12" };

            Console.WriteLine($"{audi.Inhaber.Vorname}: Aktuelle Geschwindigkeit: {audi.Geschwindigkeit}kmh, Kilometerstand: {audi.Kilometerstand}");
            audi.Beschleunigen(10);            
            audi.Beschleunigen(20);
            audi.Beschleunigen(-20);
            Console.WriteLine($"{audi.Inhaber.Vorname}: Aktuelle Geschwindigkeit: {audi.Geschwindigkeit}kmh, Kilometerstand: {audi.Kilometerstand}");
            audi.Bremsen(5);
            audi.Bremsen(-50);
            Console.WriteLine($"{audi.Inhaber.Vorname}: Aktuelle Geschwindigkeit: {audi.Geschwindigkeit}kmh, Kilometerstand: {audi.Kilometerstand}");
            audi.Fahren(7);
            audi.Fahren(-17);
            Console.WriteLine($"{audi.Inhaber.Vorname}: Aktuelle Geschwindigkeit: {audi.Geschwindigkeit}kmh, Kilometerstand: {audi.Kilometerstand}");

            Console.WriteLine("---ENDE---");
            Console.ReadKey();
        }
    }
}
