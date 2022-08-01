using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
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
        private readonly UserManager<AppUser> userManager;

        public OrderController(AppDbContext context,UserManager<AppUser> userManager)
        {
            this.context = context;
            this.userManager = userManager;
        }

        public IActionResult Checkout()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Checkout(Order order)
        {
            AppUser user = await userManager.FindByNameAsync(User.Identity.Name);
            List<BasketItem> basket = await context.BasketItems.Include(o => o.User)
                .Include(o => o.Clothes)
                .Where(o => o.UserId == user.Id).ToListAsync();
            order.Date = System.DateTime.Now;
            order.TotalPrice = default;
            order.User = user;
            order.BasketItems = basket;
            foreach (BasketItem item in basket)
            {
                order.TotalPrice += item.Price * item.Quantity;
            }
            await context.Orders.AddAsync(order);
            await context.SaveChangesAsync();

            return RedirectToAction("Index", "Home");
        }
    }
}