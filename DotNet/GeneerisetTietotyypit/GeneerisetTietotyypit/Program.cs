using System;
using System.Collections.Generic;

namespace GeneerisetTietotyypit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // merkkijonot
            List<string> merkkijonot = new();
            merkkijonot.Add("Testi");
            merkkijonot.Add("Toinen");
            merkkijonot.Add("Kolmas");
            // merkkijonot.Add(1234);
            // merkkijonot.Add(true);

            merkkijonot.Remove("Toinen");
            merkkijonot.RemoveAt(1);

            foreach (string merkkijono in merkkijonot)
            {
                Console.WriteLine(merkkijono);
            }

            // autot
            Auto a1 = new()
            {
                Merkki = "Toyota",
                Malli = "Corolla",
                Huippunopeus = 190
            };
            Auto a2 = new()
            {
                Merkki = "Audi",
                Malli = "A4",
                Huippunopeus = 230
            };

            Urheiluauto u = new()
            {
                Merkki = "Porsche",
                Huippunopeus = 315,
                KattoAlhaalla = true
            };

            List<Auto> autot = new();
            autot.Add(a1);
            autot.Add(a2);
            autot.Add(u);

            foreach (Auto auto in autot)
            {
                if (auto is Auto)
                {
                    Console.WriteLine("Auto: " + auto.Merkki);
                }
                if (auto is Urheiluauto urhAuto)
                {
                    Console.WriteLine("Urheiluauto: katto alhaalla = "
                        + urhAuto.KattoAlhaalla);
                }
            }

            // yleinen lista
            List<object> oliot = new();
            oliot.Add(1234);
            oliot.Add("ABCD");
            oliot.Add(a2);
        }
    }
}
