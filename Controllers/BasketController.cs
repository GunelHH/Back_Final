using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using OnlineShop.DAL;
using OnlineShop.Models;
using OnlineShop.ViewModels.Basket;

namespace OnlineShop.Controllers
{
    public class BasketController : Controller
    {
        private readonly AppDbContext context;

        public BasketController(AppDbContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult AddBasket(int? id)
        {
            if (id is null || id == 0) return RedirectToAction("notfound", "error");
            Clothe clothes = context.Clothes.FirstOrDefault(c => c.Id == id);
            if (clothes is null) return RedirectToAction("notfound", "error");

            string BasketStr = HttpContext.Request.Cookies["Basket"];

            BasketVM basket;

            if (string.IsNullOrEmpty(BasketStr))
            {
                basket = new BasketVM();
                BasketCookieItemVM cookieItem = new BasketCookieItemVM
                {
                    Id = clothes.Id,
                    Quantity = 1,
                };
                basket.BasketCookieItemVMs = new List<BasketCookieItemVM>();
                basket.TotalPrice = clothes.Price;
                basket.BasketCookieItemVMs.Add(cookieItem);
            }
            else
            {
                basket = JsonConvert.DeserializeObject<BasketVM>(BasketStr);

                BasketCookieItemVM existedItem = basket.BasketCookieItemVMs.FirstOrDefault(b => b.Id == id);
                if (existedItem == null)
                {
                    BasketCookieItemVM cookieItem = new BasketCookieItemVM
                    {
                        Id = clothes.Id,
                        Quantity = 1,
                    };
                    basket.TotalPrice += clothes.Price;
                    basket.BasketCookieItemVMs.Add(cookieItem);
                }
                else
                {
                    basket.TotalPrice += clothes.Price;
                    existedItem.Quantity++;

                }
            }


            BasketStr = JsonConvert.SerializeObject(basket);


            HttpContext.Response.Cookies.Append("Basket", BasketStr);

            return RedirectToAction("index", "home");

        }


        public IActionResult Increase(int? id)
        {
            if (id is null || id == 0) return RedirectToAction("notfound", "error");
            Clothe clothes = context.Clothes.FirstOrDefault(c => c.Id == id);
            if (clothes is null) return RedirectToAction("notfound", "error");

            string BasketStr = HttpContext.Request.Cookies["Basket"];

            BasketVM basket;

            if (string.IsNullOrEmpty(BasketStr))
            {
                basket = new BasketVM();
                BasketCookieItemVM cookieItem = new BasketCookieItemVM
                {
                    Id = clothes.Id,
                    Quantity = 1,
                };
                basket.BasketCookieItemVMs = new List<BasketCookieItemVM>();
                basket.TotalPrice = clothes.Price;
                basket.BasketCookieItemVMs.Add(cookieItem);
            }
            else
            {
                basket = JsonConvert.DeserializeObject<BasketVM>(BasketStr);

                BasketCookieItemVM existedItem = basket.BasketCookieItemVMs.FirstOrDefault(b => b.Id == id);
                if (existedItem == null)
                {
                    BasketCookieItemVM cookieItem = new BasketCookieItemVM
                    {
                        Id = clothes.Id,
                        Quantity = 1,
                    };
                    basket.TotalPrice += clothes.Price;
                    basket.BasketCookieItemVMs.Add(cookieItem);
                }
                else
                {
                    basket.TotalPrice += clothes.Price;
                    existedItem.Quantity++;

                }
            }


            BasketStr = JsonConvert.SerializeObject(basket);


            HttpContext.Response.Cookies.Append("Basket", BasketStr);

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Decrease(int? id)
        {
            if (id is null || id == 0) return RedirectToAction("notfound", "error");
            Clothe clothes = context.Clothes.FirstOrDefault(c => c.Id == id);
            if (clothes is null) return RedirectToAction("notfound", "error");

            string BasketStr = HttpContext.Request.Cookies["Basket"];

            BasketVM basket;

            if (string.IsNullOrEmpty(BasketStr))
            {
                basket = new BasketVM();
                BasketCookieItemVM cookieItem = new BasketCookieItemVM
                {
                    Id = clothes.Id,
                    Quantity = 1,
                };
                basket.BasketCookieItemVMs = new List<BasketCookieItemVM>();
                basket.TotalPrice = clothes.Price;
                basket.BasketCookieItemVMs.Add(cookieItem);
            }
            else
            {
                basket = JsonConvert.DeserializeObject<BasketVM>(BasketStr);

                BasketCookieItemVM existedItem = basket.BasketCookieItemVMs.FirstOrDefault(b => b.Id == id);
                if (existedItem == null)
                {
                    BasketCookieItemVM cookieItem = new BasketCookieItemVM
                    {
                        Id = clothes.Id,
                        Quantity = 1,
                    };
                    basket.TotalPrice += clothes.Price;
                    basket.BasketCookieItemVMs.Add(cookieItem);
                }
                else
                {
                    basket.TotalPrice += clothes.Price;
                    existedItem.Quantity--;

                }
            }


            BasketStr = JsonConvert.SerializeObject(basket);


            HttpContext.Response.Cookies.Append("Basket", BasketStr);

            return RedirectToAction(nameof(Index));
        }
    }
}