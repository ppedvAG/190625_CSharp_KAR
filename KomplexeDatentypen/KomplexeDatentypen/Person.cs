using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomplexeDatentypen
{
    class Person
    {
        public string Vorname { get; set; }
        public string Nachname { get; set; }
        public byte Alter { get; set; }
        public decimal Kontostand { get; set; }

        public override bool Equals(object obj)
        {
            if (!(obj is Person))
                return false;

            var otherPerson = (Person)obj;
            if (otherPerson.Vorname == Vorname &&
                otherPerson.Nachname == Nachname &&
                otherPerson.Alter == Alter)
                return true;
            else
                return false;

            // Reflection
            // typeof(Person).GetProperties()
            // -> In einer Schleife jedes Property vergleichen
        }
    }
}
