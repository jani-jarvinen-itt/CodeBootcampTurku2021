using System;

namespace ArvaaLukuPeli
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Arvaa luku -peli alkaa!");

            Random rand = new Random();
            int oikea = rand.Next(1, 21);
            // Console.WriteLine(oikea);

            for (int arvauskerta = 1; arvauskerta <= 3; arvauskerta++)
            {
                Console.WriteLine("Anna arvauksesi välillä 1-20:");
                string syöte = Console.ReadLine();
                int arvaus = int.Parse(syöte);

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
