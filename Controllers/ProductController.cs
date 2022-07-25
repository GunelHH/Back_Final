using System;
using Microsoft.AspNetCore.Mvc;

namespace OnlineShop.Controllers
{
    public class ProductController:Controller
    {
       public IActionResult Index()
        {
            return View();
        }
        public IActionResult Defaut()
        {
            return View();
        }
    }
}

