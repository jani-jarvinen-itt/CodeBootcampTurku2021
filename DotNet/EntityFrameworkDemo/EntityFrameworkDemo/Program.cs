using EntityFrameworkDemo.Models;
using System;

namespace EntityFrameworkDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            NorthwindContext konteksti = new();
            foreach (var asiakas in konteksti.Customers)
            {
                Console.WriteLine(asiakas.CompanyName);
            }
        }
    }
}
