using System;

namespace OlioOhjelmointi2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Moikka Visual Studio!");

            Asiakas asiakas = new Asiakas();
            asiakas.Nimi = "Teppo Testaaja";
            asiakas.Osoite = "Kotikatu 12 B";
            asiakas.Puhelin = "0500 111 222";
            asiakas.Sähköposti = "teppo@testaajat.fi";

            Tilaus tilaus = new Tilaus();
            tilaus.Päivämäärä = DateTime.Today;
            tilaus.Tuote = "Peruna";
            tilaus.Lukumäärä = 5;
        }
    }
}
