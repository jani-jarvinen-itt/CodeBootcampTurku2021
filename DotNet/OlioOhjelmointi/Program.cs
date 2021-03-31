using System;

namespace OlioOhjelmointi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Auto auto1 = new Auto();
            auto1.Merkki = "Toyota";
            auto1.Malli = "Corolla";
            auto1.TulostaRuudulle();

            Auto auto2 = new Auto();
            auto2.Merkki = "Ford";
            auto2.Malli = "Focus";
            auto2.TulostaRuudulle();

            Auto auto3 = new Auto();
        }
    }
}
