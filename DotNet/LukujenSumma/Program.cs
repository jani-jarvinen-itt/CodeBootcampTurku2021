using System;

namespace LukujenSumma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna ensimmäinen luku:");
            string luku1 = Console.ReadLine();

            Console.WriteLine("Anna toinen luku:");
            string luku2 = Console.ReadLine();

            int summa = int.Parse(luku1) + int.Parse(luku2);
            Console.WriteLine("Summa on: " + summa);
        }
    }
}
