using System;
using Microsoft.AspNetCore.Mvc;

namespace OnlineShop.Controllers
{
    public class ProductController:Controller
    {
        public IActionResult Detail(int? id)
        {
            if (id is null || id == 0) return RedirectToAction("notfound", "error");
            return View();
        }
    }
}

