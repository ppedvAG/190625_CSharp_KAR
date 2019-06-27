using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bitte geben Sie eine Zahl ein:");
            string eingabe = Console.ReadLine();



            // try + TAB + TAB
            int zahl = 0;
            try
            {
                zahl = Convert.ToInt32(eingabe);
            }
            catch (Exception)
            {
                Console.WriteLine("Es gibt einen Fehler 😭");
                // Console.WriteLine(ex.Message); // originale Fehlermeldung ausgeben
                // throw; // Fehler weiterwerfen

                return; // beende das programm wegen einem fehler
            }
            finally
            {
                Console.WriteLine("Ich werde immer ausgeführt, egal ob es eine Exception gibt oder nicht");
                Console.ReadKey();
            }

            Console.WriteLine($"Das Doppelte ist : {zahl * 2}");
            Console.WriteLine("---ENDE---");
            Console.ReadKey();
        }
    }
}
