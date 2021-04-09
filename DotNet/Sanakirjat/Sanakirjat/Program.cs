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

            // oman luokan käyttö
            Console.WriteLine();
            Dictionary<string, Pelihahmo> pelihahmot = new();
            Pelihahmo p1 = new()
            {
                Pistemäärä = 50,
                Elinvoima = 88,
                AmmustenMäärä = 3200
            };
            Pelihahmo p2 = new()
            {
                Pistemäärä = 143,
                Elinvoima = 66,
                AmmustenMäärä = 412
            };

            pelihahmot.Add("ShadowRider", p1);
            pelihahmot.Add("LightWarrior", p2);

            foreach (string nimi in pelihahmot.Keys)
            {
                Pelihahmo hahmo = pelihahmot[nimi];
                Console.WriteLine(nimi + ": " + hahmo.Elinvoima);
            }
        }
    }
}
