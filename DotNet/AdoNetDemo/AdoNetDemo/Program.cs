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
            sql = "INSERT INTO [dbo].[Customers] ([CustomerID],[CompanyName],[ContactName],[ContactTitle],[Address], "+
                  "[City],[Region],[PostalCode],[Country],[Phone],[Fax]) "+
                  "VALUES ('UUSIA', 'Uusi Yritys Oy', 'Teppo Testaaja', "+
                  "'Pääjehu', 'Teollisuuskatu 17', 'Forssa', "+
                  "NULL, '21450', 'Finland', '0400 98765', NULL)";
            SqlCommand komento2 = new(sql, yhteys);
            int rivienMäärä = komento2.ExecuteNonQuery();
            Console.WriteLine($"Lisätty {rivienMäärä} uusi asiakas tietokantaan.");
        }
    }
}
