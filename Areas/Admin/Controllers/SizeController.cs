using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace OnlineShop.Areas.Admin.Controllers
{
    public class SizeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}