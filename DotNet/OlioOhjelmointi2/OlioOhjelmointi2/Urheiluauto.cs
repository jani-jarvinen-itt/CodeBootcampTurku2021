using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlioOhjelmointi2
{
    public class Urheiluauto : Auto
    {
        public Urheiluauto(int huippunopeus) : base(huippunopeus)
        {
        }

        public bool KattoAlhaalla { get; set; }
    }
}
