using System;

namespace RajapinnatJaLuokat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Auto a = new()
            {
                Merkki = "Ford",
                Malli = "Fiesta"
            };
            Koira k = new()
            {
                Nimi = "Musti",
                Rotu = "Collie",
                Ikä = 7
            };

            ITulostus tulostus = k;
            Raportoi(a);
            Raportoi(tulostus);
        }

        static void Raportoi(ITulostus t)
        {
            t.Tulosta();
        }
    }
}
