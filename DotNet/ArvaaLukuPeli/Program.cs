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
            Console.WriteLine(oikea);

            Console.WriteLine("Peli on päättynyt.");
        }
    }
}
