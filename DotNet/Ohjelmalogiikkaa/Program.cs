using System;

namespace Ohjelmalogiikkaa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            const int Viikonpäiviä = 7;
            int luku = 987;
            Console.WriteLine(luku);
            Console.WriteLine(Viikonpäiviä);

            if (luku > 1000)
            {
                Console.WriteLine("Luku on suurempi kuin tuhat!");
            }
            else
            {
                Console.WriteLine("Luku on pienempi tai sama kuin tuhat!");
            }

            /*
            Console.WriteLine(1);
            Console.WriteLine(2);
            Console.WriteLine(3);
            Console.WriteLine(4);
            Console.WriteLine(5);
            Console.WriteLine(6);
            Console.WriteLine(7);
            */

            for (int laskuri = 1; laskuri <= 10; laskuri++)
            {
                Console.WriteLine(laskuri);
            }
        }
    }
}
