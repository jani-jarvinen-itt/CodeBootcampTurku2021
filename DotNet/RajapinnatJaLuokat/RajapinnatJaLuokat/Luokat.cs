using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RajapinnatJaLuokat
{
    public class Auto : ITulostus
    {
        public string Merkki { get; set; }
        public string Malli { get; set; }

        public void Tulosta()
        {
            Console.WriteLine($"Auto: merkki={Merkki}, malli={Malli}.");
        }
    }

    public class Koira : ITulostus
    {
        public string Nimi { get; set; }
        public string Rotu { get; set; }
        public int Ikä { get; set; }

        public void Tulosta()
        {
            Console.WriteLine($"Koira: nimi={Nimi}, rotu={Rotu}, ikä={Ikä}.");
        }
    }

    public interface ITulostus
    {
        void Tulosta();
    }
}
