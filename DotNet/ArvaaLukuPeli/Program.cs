// Arvaa luku -peli. Versio 1.0/30.3.2021. Tekijä: N.N.
// Copyright (C) Yritys Oy, 2021.
using System;

namespace ArvaaLukuPeli
{
    class Program
    {
        const int SuurinLuku = 20;
        const int ArvauskertojenMäärä = 3;

        static void Main(string[] args)
        {
            Console.WriteLine("Arvaa luku -peli alkaa!");

            // kone arpoo pelin oikean luvun
            Random rand = new Random();
            int oikea = rand.Next(1, SuurinLuku + 1);
            // Console.WriteLine(oikea);

            // aloitetaan käyttäjän arvausten kysyminen
            for (int arvauskerta = 1; arvauskerta <= ArvauskertojenMäärä; arvauskerta++)
            {
                Console.WriteLine($"Anna arvauksesi välillä 1-{SuurinLuku}:");
                string syöte = Console.ReadLine();
                int arvaus = int.Parse(syöte);

                // tarkistetaan, oliko vastaus oikea
                if (arvaus < oikea)
                {
                    Console.WriteLine("Oikea luku on suurempi!");
                }
                else if (arvaus > oikea)
                {
                    Console.WriteLine("Oikea luku on pienempi!");
                }
                else
                {
                    Console.WriteLine("Jee! Arvasit oikein! Voitit pelin!");
                    break;
                }
            }

            Console.WriteLine("Peli on päättynyt.");
        }
    }
}
