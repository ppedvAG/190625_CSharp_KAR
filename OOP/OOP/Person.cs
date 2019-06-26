using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    /* Empfohlene Namenskonvention:
     * Felder werden klein geschrieben (alternativ auch mit voranstehendem _ )
     * Properties und Methoden werden groß geschrieben
     * Klassennamen werden groß geschrieben
     */

    class Person // Klasse == "Bauplan"
    {
        #region Variante ohne Properties
        //// Felder (immer private)
        //private string vorname;
        //private string nachname;
        //private byte alter;
        //private decimal kontostand;

        //public void SetVorname(string neuerVorname) // Validierung
        //{
        //    if(neuerVorname.Length < 3)
        //        Console.WriteLine("Vorname zu kurz");
        //    else
        //        vorname = neuerVorname;
        //}
        //public string GetVorname()
        //{
        //    return vorname;
        //} 
        #endregion

        private string vorname; // wird klein geschrieben !
        public string Vorname
        {
            get // Lesezugriff
            {
                return vorname;
            }
            set // Schreibzugriff
            {
                // vorname = value; // value ist der neue Wert, der gesetzt wird

                if (value.Length < 3)
                    Console.WriteLine("Vorname zu kurz");
                else
                    vorname = value;
            }
        }

        // propfull + TAB + TAB
        private string nachname;

        public string Nachname
        {
            get { return nachname; }
            set { nachname = value; }
        }

        // Seit C# 7.0: Kurzschreibweise mit Lambda-Ausdruck
        // public string Nachname
        // {
        //    get => nachname; 
        //    set => nachname = value; 
        // }

        // Autoproperty:
        // prop + TAB + TAB

        private byte alter;
        public byte Alter
        {
            get => alter;
            set
            {
                if (value < 120)
                    alter = value;
                else
                    Console.WriteLine("Man darf nicht älter als 120 werden");
            }
        } // macht der Compiler ein propfull daraus

        public decimal Kontostand { get; private set; }


    }
}
