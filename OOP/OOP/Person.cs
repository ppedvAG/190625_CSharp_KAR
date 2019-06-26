using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    /* Empfohlene Namenskonvention:
     * Felder werden klein geschrieben
     * 
     */ 

    class Person // Klasse == "Bauplan"
    {
        // Felder (immer private)
        private string vorname;
        private string nachname;
        private byte alter;
        private decimal kontostand;

        public void SetVorname(string neuerVorname) // Validierung
        {
            if(neuerVorname.Length < 3)
                Console.WriteLine("Vorname zu kurz");
            else
                vorname = neuerVorname;
        }
        public string GetVorname()
        {
            return vorname;
        }
    }
}
