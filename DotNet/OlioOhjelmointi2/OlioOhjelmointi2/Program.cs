using System;

namespace OlioOhjelmointi2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Moikka Visual Studio!");

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
