using System;
using System.Collections.Generic;

namespace Sanakirjat
{
    public enum Prioriteetti
    {
        Matala,
        Tavallinen,
        Korkea,
        Superkorkea
    }

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

            // lueteltu tyyppi (enum) ja lista
            Dictionary<Prioriteetti, List<string>> tehtävät = new();
            tehtävät.Add(Prioriteetti.Matala, new List<string>());
            tehtävät.Add(Prioriteetti.Tavallinen, new List<string>());
            tehtävät.Add(Prioriteetti.Korkea, new List<string>());
            tehtävät.Add(Prioriteetti.Superkorkea, new List<string>());

            tehtävät[Prioriteetti.Matala].Add("Paikkaa fillarin rengas.");
            tehtävät[Prioriteetti.Tavallinen].Add("Käy kaupassa.");
            tehtävät[Prioriteetti.Tavallinen].Add("Vie koira lenkille.");
            tehtävät[Prioriteetti.Korkea].Add("Vie roskat.");

            // sisäkkäinen
            Dictionary<int, Dictionary<string, Prioriteetti>> testi = new();
            testi.Add(100, new Dictionary<string, Prioriteetti>());
            testi[100].Add("AAAA", Prioriteetti.Tavallinen);
        }
    }
}
