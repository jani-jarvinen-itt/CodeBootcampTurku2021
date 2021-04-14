﻿using Microsoft.AspNetCore.Http;
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
        public int Luku()
        {
            Random satunnainen = new();
            int luku = satunnainen.Next(1, 10000);
            return luku;
        }
    }
}
