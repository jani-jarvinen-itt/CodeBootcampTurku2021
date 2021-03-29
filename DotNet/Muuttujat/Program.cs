using System;

namespace Muuttujat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int luku = 123;
            Console.WriteLine(luku);

            // luku = "ABCD";
            // Console.WriteLine(luku);

            Testi(123);
            // Testi("AAAA");
        }

        private static void Testi(int luku)
        {
            int plusYksi = luku + 1;
            Console.WriteLine(plusYksi);
        }
    }
}
