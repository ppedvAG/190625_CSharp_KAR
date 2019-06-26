using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Fahrzeug
    {
        public Fahrzeug(string meinText)
        {
            // ....
        }

        public Person Inhaber { get; set; }

        private int geschwindigkeit;

        public int Geschwindigkeit
        {
            get { return geschwindigkeit; }
            set
            {
                if (value > 0 && value <= 250)
                    geschwindigkeit = value;
                else
                    Console.WriteLine("Ungültiger Geschwindigkeitswert");
            }
        }

        private int kilometerstand;
        public int Kilometerstand
        {
            get => kilometerstand;
            private set
            {
                if (value > kilometerstand)
                    kilometerstand = value;
                else
                    Console.WriteLine("Der Kilometerstand darf nicht verringert werden !");
            }
        }

        public void Beschleunigen(int wert)
        {
            if(wert < 0)
            {
                Console.WriteLine("Ungültiger Wert fürs Beschleunigen");
                return;
            }
            Geschwindigkeit += wert;
            Console.WriteLine("BRUMMMM.....");
        }
        public void Bremsen(int wert)
        {
            if (wert < 0)
            {
                Console.WriteLine("Ungültiger Wert fürs Bremsen");
                return;
            }
            Geschwindigkeit -= wert;
            Console.WriteLine("QUIETSCH");
        }
        public void Fahren(int stunden)
        {
            if(stunden < 0)
            {
                Console.WriteLine("Sie können nicht in die Vergangenheit fahren !");
                return;
            }
            Kilometerstand += stunden * Geschwindigkeit;
        }

    }
}
