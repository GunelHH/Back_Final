using System;
using Microsoft.AspNetCore.Mvc;

namespace OnlineShop.Controllers
{
    public class HomeController:Controller
    {
       public IActionResult Index()
        {
            return View();
        }

        public IActionResult Shop()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }
    }
}

