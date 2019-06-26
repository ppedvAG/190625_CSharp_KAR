using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    abstract class Grafik
    {
        public virtual void Zeichnen() // Methode wird überschreibbar
        {
            Console.WriteLine("Eine Grafik wird gezeichnet ...");
        }

        public abstract void MachEtwas(string text);
    }

    class Kreis : Grafik
    {
        public override void MachEtwas(string lalala)
        {
            Console.WriteLine("ich mach was...");
        }

        // override: Methode auswählen
        // sealed override: verhindert weiteres überschreiben
        public override void Zeichnen() // eine Methode, die das override-Schlüsselwort hat, ist ebenfalls überschreibbar (wie virtual)
        {
            // base.Zeichnen(); // original
            Console.WriteLine("Ein Kreis wird gezeichnet ...");
        }
    }

}
