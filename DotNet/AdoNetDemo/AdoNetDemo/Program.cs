using System;
using System.Data.SqlClient;

namespace AdoNetDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // tietokantayhteyden avaus
            string yhteysmerkkijono = "Server=localhost\\SQLEXPRESS;Database=Northwind;Trusted_Connection=True;";
            SqlConnection yhteys = new(yhteysmerkkijono);
            yhteys.Open();
            Console.WriteLine("Tietokantayhteys avattu!");

            // SQL-kyselyn ajaminen
            string sql = "SELECT * FROM Customers WHERE Country = 'Finland'";
            SqlCommand komento = new(sql, yhteys);
            SqlDataReader lukija = komento.ExecuteReader();

            // tietojen lukeminen
            while (lukija.Read())
            {
                string yritysNimi = lukija["CompanyName"].ToString();
                Console.WriteLine(yritysNimi);
            }
            lukija.Close();

            // INSERT-esimerkki
            Console.WriteLine("Aloitetaan uuden asiakkaan lisääminen...");
            Asiakas asiakas = LueTiedot();

            /*
            // Vaarallinen tapa, älä käytä! SQL-injektion riski ilmeinen!
            sql = "INSERT INTO [dbo].[Customers] ([CustomerID],[CompanyName],[ContactName],[ContactTitle],[Address], "+
                  "[City],[Region],[PostalCode],[Country],[Phone],[Fax]) "+
                  $"VALUES ('{asiakas.Avain}', '{asiakas.YrityksenNimi}', "+
                  $"'{asiakas.Kontaktihenkilö}', '{asiakas.Titteli}', "+
                  "'Teollisuuskatu 17', 'Forssa', "+
                  "NULL, '21450', 'Finland', '0400 98765', NULL)";
            */

            // parametroitu kysely
            sql = "INSERT INTO [dbo].[Customers] ([CustomerID],[CompanyName],[ContactName],[ContactTitle],[Address], " +
                  "[City],[Region],[PostalCode],[Country],[Phone],[Fax]) " +
                  $"VALUES (@avain, @nimi, @kontakti, @titteli, " +
                  "'Teollisuuskatu 17', 'Forssa', " +
                  "NULL, '21450', 'Finland', '0400 98765', NULL)";
            SqlCommand komento2 = new(sql, yhteys);

            // parametrien arvojen asetus
            komento2.Parameters.AddWithValue("@avain", asiakas.Avain);
            komento2.Parameters.AddWithValue("@nimi", asiakas.YrityksenNimi);
            komento2.Parameters.AddWithValue("@kontakti", asiakas.Kontaktihenkilö);
            komento2.Parameters.AddWithValue("@titteli", asiakas.Titteli);
            int rivienMäärä = komento2.ExecuteNonQuery();

            Console.WriteLine($"Lisätty {rivienMäärä} uusi asiakas tietokantaan.");
        }

        private static Asiakas LueTiedot()
        {
            Asiakas asiakas = new();

            Console.WriteLine("Anna asiakkaan avainkoodi (5 merkkiä):");
            string syöte = Console.ReadLine();
            asiakas.Avain = syöte;

            Console.WriteLine("Anna asiakkaan nimi:");
            syöte = Console.ReadLine();
            asiakas.YrityksenNimi = syöte;

            Console.WriteLine("Anna asiakkaan kontaktihenkilö:");
            syöte = Console.ReadLine();
            asiakas.Kontaktihenkilö = syöte;

            Console.WriteLine("Anna asiakkaan titteli:");
            syöte = Console.ReadLine();
            asiakas.Titteli = syöte;

            return asiakas;
        }
    }
}
