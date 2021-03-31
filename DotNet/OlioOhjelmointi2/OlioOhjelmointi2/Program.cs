using System;

namespace OlioOhjelmointi2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Moikka Visual Studio!");

            Auto auto = new(160)
            {
                // Nopeus = 0
            };

            Auto auto2 = new(210)
            {
                // Nopeus = 0
            };
            auto.Kiihdytä();
            auto.Kiihdytä();
            auto.Kiihdytä();

            // auto2.Nopeus = 8421;

            Console.WriteLine(auto.Nopeus);  // tulostaa: 15
            Console.WriteLine(auto2.Nopeus); // tulostaa: 0

            Urheiluauto u = new(300)
            {
                KattoAlhaalla = true
            };

            // C# 9.0 (2020) alkaen:
            Asiakas asiakas = new()
            {
                Nimi = "Teppo Testaaja",
                Osoite = "Kotikatu 12 B",
                Puhelin = "0500 111 222",
                Sähköposti = "teppo@testaajat.fi"
            };

            // C# 1.0 (2002) alkaen:
            Tilaus tilaus = new Tilaus();
            tilaus.Päivämäärä = DateTime.Today;
            tilaus.Tuote = "Peruna";
            tilaus.Lukumäärä = 5;
        }
    }
}
