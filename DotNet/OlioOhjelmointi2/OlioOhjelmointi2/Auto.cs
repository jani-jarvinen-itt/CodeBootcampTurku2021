using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlioOhjelmointi2
{
    public class Auto
    {
        public int Nopeus { get; set; }

        public void Kiihdytä()
        {
            Nopeus += 5;
        }

        public void Jarruta()
        {
            Nopeus -= 5;
        }
    }
}
