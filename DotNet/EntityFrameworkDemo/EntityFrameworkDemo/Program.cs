using EntityFrameworkDemo.Models;
using System;
using System.Linq;

namespace EntityFrameworkDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            NorthwindContext konteksti = new();
            // var quedenTilaukset = konteksti.Orders.Where(o => o.CustomerId == "QUEDE");

            // LINQ-kysely
            var suomalaiset = konteksti.Customers.Where(c => c.Country == "Finland");
            foreach (var asiakas in suomalaiset)
            {
                Console.WriteLine(asiakas.CompanyName);
            }

            /*
            // toimii, mutta suorituskyvyn kannalta heikko
            NorthwindContext konteksti = new();
            foreach (var asiakas in konteksti.Customers)
            {
                if (asiakas.Country == "Finland")
                {
                    Console.WriteLine(asiakas.CompanyName);
                }
            }
            */
        }

        /*
        private bool Testi(Customer c)
        {
            return c.Country == "Finland";
        }
        */
    }
}
