using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RandomPasscode.Models;
using Microsoft.AspNetCore.Http;

namespace RandomPasscode.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        
        public string CreatePasscode(int passcodeSize)
        {
            Random rand = new Random(); 
            string randPasscode = ""; 
            string values = "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890"; 
                for(var i = 0; i < passcodeSize; i++)
                randPasscode += values[rand.Next(values.Length)]; 
                Console.WriteLine(randPasscode);
                return randPasscode;
        }

        public IActionResult Index()
        {   
            if(HttpContext.Session.GetString("Passcode") == null)
            {
                HttpContext.Session.SetString("Passcode", "New Passcode Generating...");
            }


            ViewBag.Passcode = HttpContext.Session.GetString("Passcode");
            int? countVar = HttpContext.Session.GetInt32("Count");
            ViewBag.Count = countVar;
            
            return View();
        }

        [HttpGet("Generate")]
        public IActionResult NewPasscode()
        {
            int? countVar = HttpContext.Session.GetInt32("Count");

            if(countVar == null)
            {
                HttpContext.Session.SetInt32("Count", 1);
            }
            else
            {
                HttpContext.Session.SetInt32("Count", (int)countVar + 1);
            }
            
            // Calling on function CreatePasscode to generate the random passcode.
            HttpContext.Session.SetString("Passcode", CreatePasscode(25));

            return RedirectToAction("Index");
        }

        [HttpGet("Reset")]
        public IActionResult Reset()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
