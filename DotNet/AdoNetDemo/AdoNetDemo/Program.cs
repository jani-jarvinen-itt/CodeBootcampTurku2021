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
        }
    }
}
