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
            catch (FormatException)
            {
                Console.WriteLine("Bitte geben Sie nur ganze Zahlen ein");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Ihre Zahl war zu groß oder zu klein");
            }
            catch (Exception)// fängt alles ab
            {
                Console.WriteLine("Unbekannter Fehler :/ ");
            }
            finally
            {
                Console.WriteLine("Ich werde immer ausgeführt, egal ob es eine Exception gibt oder nicht");
                Console.ReadKey();
            }

            Console.WriteLine($"Das Doppelte ist : {zahl * 2}");

            try
            {

                int erg1 = Dividieren(10, 2);
                int erg2 = Dividieren(10, 0);
            }
            catch(ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("---ENDE---");
            Console.ReadKey();
        }


        public static int Dividieren(int z1, int z2)
        {
            if (z2 == 0)
                throw new ArgumentNullException("Man darf nicht durch 0 dividieren");

            int ergebnis = z1 / z2;
            return ergebnis;
        }

    }
}
