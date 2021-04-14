using AspNetWebApiDemo.Mallit;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetWebApiDemo.Controllers
{
    [Route("api/testi")]
    [ApiController]
    public class TestiApiController : ControllerBase
    {
        [HttpGet]
        [Route("satunnainen")]
        public int Luku()
        {
            Random satunnainen = new();
            int luku = satunnainen.Next(1, 10000);
            return luku;
        }

        [HttpGet]
        [Route("auto")]
        public Auto AutoEsimerkki()
        {
            return new()
            {
                Merkki = "Porsche",
                Malli = "Taycan",
                Huippunopeus = 300
            };
        }

        /*[HttpGet]
        [Route("kellonaika")]*/
        [HttpGet("kellonaika")]
        public DateTime Kellonaika()
        {
            return DateTime.Now;
        }
    }
}
