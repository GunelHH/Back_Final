using System;
using OnlineShop.DAL;
using System.Collections.Generic;
using OnlineShop.Models;
using System.Linq;
using OnlineShop.ViewModels.Basket;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace OnlineShop.Services
{
    public class LayoutService
    {
        private readonly AppDbContext _context;
        private readonly IHttpContextAccessor http;

        public LayoutService(AppDbContext context, IHttpContextAccessor http)
        {
            this._context = context;
            this.http = http;
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
            string basketStr =http.HttpContext.Request.Cookies["Basket"];
            if (!string.IsNullOrEmpty(basketStr))
            {
                BasketVM basket =JsonConvert.DeserializeObject<BasketVM>(basketStr);

                CartCheckOutVM cartCheck = new CartCheckOutVM();
                cartCheck.CartItemVms = new List<CartItemVM>();

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
                            TotalPrice=(clothes.Price*item.Quantity),
                            ClothesId=item.Id
                        };
                        cartCheck.CartItemVms.Add(cartItem);
                    }
                }
                cartCheck.TotalPrice = basket.TotalPrice;
                return cartCheck;
            }
            return null;
        }

    }
}

