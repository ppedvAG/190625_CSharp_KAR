using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class LKW : Fahrzeug
    {
        // : this = Konstruktur von der eigenen Klasse
        // : base = Konstruktor von der Basisklasse
        public LKW() : base("Hallo ich bin ein LKW")
        {
            // nur noch sachen, die im LKW neu sind
        }

        public double Höhe { get; set; }
        public int MaximalesLadegewicht { get; set; }
    }
}
