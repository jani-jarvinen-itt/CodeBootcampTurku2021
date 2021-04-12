using System;
using System.Globalization;

namespace Kulttuurit
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime nyt = DateTime.Now;
            Console.WriteLine(nyt);

            CultureInfo fi = new("fi");
            CultureInfo enUs = new("en-US");
            CultureInfo enGb = new("en-GB");
            CultureInfo de = new("de");

            Console.WriteLine(nyt.ToString(fi));
            Console.WriteLine(nyt.ToString(enUs));
            Console.WriteLine(nyt.ToString(enGb));
            Console.WriteLine(nyt.ToString(de));

            Console.WriteLine(nyt.ToString("dddd", fi));
            Console.WriteLine(nyt.ToString("dddd", enUs));
            Console.WriteLine(nyt.ToString("dddd", de));

            Console.WriteLine(nyt.ToString("R"));
            Console.WriteLine(nyt.ToString("s"));

        }
    }
}
