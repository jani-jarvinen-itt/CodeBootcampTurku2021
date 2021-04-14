using AspNetWebApiDemo.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetWebApiDemo.Controllers
{
    [Route("api/asiakkaat")]
    [ApiController]
    public class AsiakkaatApiController : ControllerBase
    {
        [HttpGet]
        [Route("kaikki")]
        public List<Customer> PalautaKaikki()
        {
            NorthwindContext konteksti = new();
            List<Customer> asiakkaat = konteksti.Customers.ToList();
            return asiakkaat;
        }

        /*
        NorthwindContext konteksti = new();

        [HttpGet]
        [Route("kaikki2")]
        public List<Customer> PalautaKaikki2() =>
            konteksti.Customers.ToList();
        */

        [HttpGet]
        [Route("yksiMaa/{maanNimi}")]
        public List<Customer> PalautaYhdenMaan(string maanNimi)
        {
            NorthwindContext konteksti = new();
            List<Customer> asiakkaat = konteksti.Customers.
                Where(c => c.Country == maanNimi).ToList();
            return asiakkaat;
        }

        [HttpPost]
        [Route("")]
        public void LisääUusi([FromBody] Customer asiakas)
        {
            NorthwindContext konteksti = new();
            konteksti.Customers.Add(asiakas);
            konteksti.SaveChanges();
        }
    }
}
