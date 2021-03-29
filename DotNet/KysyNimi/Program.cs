using System;

namespace KysyNimi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna nimesi:");
            string nimi = Console.ReadLine();

            // tapa 1:
            Console.WriteLine("Hei " + nimi + "!");

            // tapa 2:
            Console.WriteLine("Hei {0}!", nimi);

            // tapa 3:
            Console.WriteLine($"Hei {nimi}!");
        }
    }
}
