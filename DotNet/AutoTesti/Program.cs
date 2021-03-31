using System;

namespace AutoTesti
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string auto1Merkki = "Toyota";
            string auto1Malli = "Corolla";
            string auto1Väri = "harmaa";
            int auto1Huippunopeus = 190;
            TulostaRuudulle(auto1Merkki, auto1Malli, "...");

            string auto2Merkki = "Ford";
            string auto2Malli = "Focus";
            string auto2Väri = "musta";
            int auto2Huippunopeus = 180;

        }

        private static void TulostaRuudulle(string merkki, string malli, string nnn)
        {
            Console.WriteLine($"Merkki = {merkki}, Malli = {malli}, ...");
        }
    }
}
