using System;
using System.Text;

namespace StringBuilderDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            /*
            // suoritusaika n. 90 sekuntia
            DateTime alku = DateTime.Now;
            string html = "<table>";
            for (int i = 0; i < 100000; i++)
            {
                html += "<tr><td>" + i + "</td></tr>\r\n";
            }
            html += "</table>";
            Console.WriteLine("HTML-koodin pituus: " + html.Length);
            DateTime loppu = DateTime.Now;
            */

            DateTime alku = DateTime.Now;
            StringBuilder html = new("<table>");
            for (int i = 0; i < 100000; i++)
            {
                html.AppendLine("<tr><td>" + i + "</td></tr>");
            }
            html.AppendLine("</table>");
            string valmisHtml = html.ToString();
            Console.WriteLine("HTML-koodin pituus: " + valmisHtml.Length);
            DateTime loppu = DateTime.Now;

            TimeSpan kesto = loppu - alku;
            Console.WriteLine($"HTML-koodin muodostus kesti: {kesto.TotalSeconds}.");


            string etunimi = "Teppo";
            string sukunimi = "Testaaja";
            string kokoNimi = etunimi + " " + sukunimi;

        }
    }
}
