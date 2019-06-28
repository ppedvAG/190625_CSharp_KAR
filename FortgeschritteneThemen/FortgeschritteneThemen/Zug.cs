using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortgeschritteneThemen
{
    class Zug : IEnumerable
    {
        public string Zugname { get; set; }
        public List<Wagon> Wagons { get; set; }

        public IEnumerator GetEnumerator()
        {
            foreach (var item in Wagons)
            {
                if(item.Klimatisiert)
                    yield return item; // Die meiste Arbeit hat hier der Compiler ;)
            }
        }


        // indexer + TAB + TAB
        public Wagon this[int wagenNummer]
        {
            get { return Wagons[wagenNummer]; }
            set { Wagons[wagenNummer] = value; }
        }

        // neuer Operator

        public static Zug operator +(Zug left, Zug right)
        {
            Zug result = new Zug();
            result.Wagons = new List<Wagon>();

            result.Wagons.AddRange(left.Wagons);
            result.Wagons.AddRange(right.Wagons);

            return result;
        }

        // Müssen immer Paarweise implementiert werden
        public static Zug operator <(Zug left, Zug right)
        {
            return null;
        }
        public static Zug operator >(Zug left, Zug right)
        {
            return null;
        }

        public bool Fahren()
        {
            return false; // wir fahren nicht
        }
    }
}
