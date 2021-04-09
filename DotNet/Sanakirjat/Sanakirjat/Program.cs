using System;
using System.Collections.Generic;

namespace Sanakirjat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Dictionary<int, string> asiakkaat = new();
            asiakkaat.Add(100, "Teppo Testaaja");
            asiakkaat.Add(101, "Antti Asiakas");
            asiakkaat.Remove(100);

            // tapa 1
            foreach (var /*KeyValuePair<int, string>*/ asiakas in asiakkaat)
            {
                Console.WriteLine(asiakas.Key + ": " + asiakas.Value);
            }

            // tapa 2
            foreach (int avain in asiakkaat.Keys)
            {
                string nimi = asiakkaat[avain];
                Console.WriteLine(avain + ": " + nimi);
            }







            /*Dictionary<int, Pelihahmo> pelihahmot = new();*/
        }
    }
}
