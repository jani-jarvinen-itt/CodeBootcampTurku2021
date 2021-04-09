using System;

namespace Päivämäärät
{
    class Program
    {
        static void Main(string[] args)
        {
            // tehtävä 1
            DateTime syntymäaika = new DateTime(2000, 1, 15);
            Console.WriteLine(syntymäaika.DayOfWeek);

            // tehtävä 2
            Console.WriteLine("Anna päivämäärä:");
            string pvm = Console.ReadLine();

            try
            {
                DateTime päivä = DateTime.Parse(pvm);

                const int PäiviäViikossa = 7;
                DateTime viikonPäästä = päivä.AddDays(PäiviäViikossa);

                Console.WriteLine("Annettu päivä:");
                Console.WriteLine(päivä);
                Console.WriteLine(päivä.Year);
                Console.WriteLine(päivä.Month);
                Console.WriteLine(päivä.Day);

                Console.WriteLine("Viikon päästä:");
                Console.WriteLine(viikonPäästä);
                Console.WriteLine(viikonPäästä.Year);
                Console.WriteLine(viikonPäästä.Month);
                Console.WriteLine(viikonPäästä.Day);
            }
            catch
            {
                Console.WriteLine("Virheellinen päivämäärä.");
            }
        }
    }
}
