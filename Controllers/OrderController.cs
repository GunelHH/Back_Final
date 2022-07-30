using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using OnlineShop.DAL;
using OnlineShop.Models;
using OnlineShop.ViewModels.Basket;

namespace OnlineShop.Controllers
{
    public class OrderController : Controller
    {
        private readonly AppDbContext context;

        public OrderController(AppDbContext context)
        {
            this.context = context;
        }
        public IActionResult Cart()
        {
            return View();
        }
        public IActionResult Checkout()
        {
            return View();
        }
    }
}