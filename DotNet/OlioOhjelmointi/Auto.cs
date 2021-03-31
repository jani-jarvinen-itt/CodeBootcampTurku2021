using System;

namespace OlioOhjelmointi
{
    public class Auto
    {
        // ominaisuudet eli propertyt
        public string Merkki { get; set; }
        public string Malli { get; set; }
        public string Väri { get; set; }
        public int Huippunopeus { get; set; }


        // toiminnot eli metodit
        public void TulostaRuudulle()
        {
            Console.WriteLine($"Merkki = {Merkki}, Malli = {Malli}, ...");
        }
    }
}
