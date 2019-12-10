using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace bitNow.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public string Get()
        {
            HttpClient http = new HttpClient();
            var data = http.GetAsync("https://api.coinbase.com/v2/prices/spot?currency=USD").Result.Content.ReadAsStringAsync().Result;
            return data;
        }
    }
}
