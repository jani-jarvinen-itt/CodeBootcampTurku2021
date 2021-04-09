using System;

namespace StringBuilderDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            DateTime alku = DateTime.Now;
            string html = "<table>";
            for (int i = 0; i < 100000; i++)
            {
                html += "<tr><td>" + i + "</td></tr>\r\n";
            }
            html += "</table>";
            Console.WriteLine("HTML-koodin pituus: " + html.Length);
            DateTime loppu = DateTime.Now;

            TimeSpan kesto = loppu - alku;
            Console.WriteLine($"HTML-koodin muodostus kesti: {kesto.TotalSeconds}.");
        }
    }
}
