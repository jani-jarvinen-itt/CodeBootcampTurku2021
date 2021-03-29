using System;
using System.IO;

namespace TiedostonLukujenSumma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Avataan tiedosto.");

            string tiedostoNimi = @"C:\Bootcamp\Turku\JavaScript\Numerot.txt";
            string[] rivit = File.ReadAllLines(tiedostoNimi);

            int summa = 0;
            foreach (string rivi in rivit)
            {
                int luku = int.Parse(rivi);
                summa += luku;
            }

            Console.WriteLine("Summa on: " + summa);
        }
    }
}
