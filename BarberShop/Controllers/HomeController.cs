using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BarberShop.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();              //grazins / arba /home adresa
        }

        public IActionResult Dovanos()
        {
            return View();              //grazins home/dovanos adresa
        }
    }
}