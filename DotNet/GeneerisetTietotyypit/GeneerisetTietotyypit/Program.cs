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

            List<Auto> autot = new();
            autot.Add(a1);
            autot.Add(a2);

            foreach (Auto auto in autot)
            {
                Console.WriteLine(auto.Merkki);
            }
        }
    }
}
