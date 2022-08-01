using System;
using OnlineShop.DAL;
using System.Collections.Generic;
using OnlineShop.Models;
using System.Linq;
using OnlineShop.ViewModels.Basket;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Identity;

namespace OnlineShop.Services
{
    public class LayoutService
    {
        private readonly AppDbContext _context;
        private readonly IHttpContextAccessor http;
        private readonly Microsoft.AspNetCore.Identity.UserManager<AppUser> userManager;

        public LayoutService(AppDbContext context, IHttpContextAccessor http,UserManager<AppUser> userManager)
        {
            this._context = context;
            this.http = http;
            this.userManager = userManager;
        }

       public List<Setting> GetSettings()
        {
            List<Setting> settings = _context.Settings.ToList();
            return settings;
        }
        public List<Category> GetCategories()
        {
            List<Category> categories = _context.Categories.ToList();
            return categories;
        }

        public CartCheckOutVM GetBasket()
        {
            CartCheckOutVM cartCheck = new CartCheckOutVM();
            cartCheck.CartItemVms = new List<CartItemVM>();
            string basketStr = http.HttpContext.Request.Cookies["Basket"];
            if (!http.HttpContext.User.Identity.IsAuthenticated)
            {
                if (!string.IsNullOrEmpty(basketStr))
                {

                    BasketVM basket = JsonConvert.DeserializeObject<BasketVM>(basketStr);



                    foreach (BasketCookieItemVM item in basket.BasketCookieItemVMs)
                    {
                        Clothe clothes = _context.Clothes.Include(c => c.ImageClothes).FirstOrDefault(c => c.Id == item.Id);
                        if (clothes == null)
                        {
                            basket.BasketCookieItemVMs.Remove(item);
                        }
                        else
                        {
                            CartItemVM cartItem = new CartItemVM
                            {
                                clothes = clothes,
                                Quantity = item.Quantity,
                                TotalPrice = (clothes.Price * item.Quantity),
                                ClothesId = item.Id
                            };
                            cartCheck.CartItemVms.Add(cartItem);
                        }
                    }
                    cartCheck.TotalPrice = basket.TotalPrice;
                    return cartCheck;
                }
            }
            else
            {
                AppUser user = userManager.FindByNameAsync(http.HttpContext.User.Identity.Name).Result;

                List<BasketItem> basketItems = _context.BasketItems.Where(i => i.UserId == user.Id)
                    .Include(i => i.Clothes).ThenInclude(i => i.ImageClothes).ToList();
                if (basketItems.Count > 0)
                {
                    foreach (BasketItem item in basketItems)
                    {
                        CartItemVM cart = new CartItemVM
                        {
                            clothes = item.Clothes,
                            ClothesId = item.ClotheId,
                            Quantity = item.Quantity,
                            TotalPrice = (item.Price * item.Quantity)
                        };
                    }
                    return cartCheck;
                }
            }

            return null;
        }


    }
}

