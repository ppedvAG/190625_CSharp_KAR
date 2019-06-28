using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortgeschritteneThemen
{
    class Wagon
    {
        public Wagon(int wagonnummer, bool klimatisiert)
        {
            Wagonnummer = wagonnummer;
            Klimatisiert = klimatisiert;
        }
        public int Wagonnummer { get; set; }
        public bool Klimatisiert { get; set; }
    }
}
