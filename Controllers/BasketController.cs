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
    public class BasketController : Controller
    {
        private readonly AppDbContext context;
        private readonly UserManager<AppUser> userManager;

        public BasketController(AppDbContext context,UserManager<AppUser>userManager)
        {
            this.context = context;
            this.userManager = userManager;
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

            //if (User.Identity.IsAuthenticated)
            //{
            //    AppUser user = await userManager.FindByNameAsync(User.Identity.Name);
            //    if (user == null) return NotFound();
            //    BasketItem existed = await context.BasketItems.FirstOrDefaultAsync(b => b.AppUserId == user.Id && b.PlantId == plant.Id);
            //    if (existed == null)
            //    {
            //        existed = new BasketItem
            //        {
            //            Plant = plant,
            //            AppUser = user,
            //            Quantity = 1,
            //            Price = plant.Price
            //        };
            //        context.BasketItems.Add(existed);
            //    }
            //    else
            //    {
            //        existed.Quantity++;
            //    }
            //    await context.SaveChangesAsync();
            //}
            //else
            //{
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
            //}

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

        //public async Task<IActionResult> GetColor(int? id,string name)
        //{
        //    Color color = context.Colors.FirstOrDefault(c => c.Name == name);
        //    AppUser user =await userManager.FindByNameAsync(User.Identity.Name);
        //    BasketItem basket = context.BasketItems.FirstOrDefault(i => i.UserId == user.Id);

        //    if (color != null)
        //    {
        //        return Json(context.BasketItems.Add(basket));
               
        //    }
        //    else
        //    {
        //        return Content("Color secilmelidir");
        //    }
        //}
    }
}