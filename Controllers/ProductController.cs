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
using static System.Net.WebRequestMethods;

namespace OnlineShop.Controllers
{
    public class ProductController : Controller
    {
        private readonly AppDbContext _context;

        public ProductController(AppDbContext context)
        {
            this._context = context;
        }
        public IActionResult Detail(int? id)
        {
            if (id is null || id == 0) return RedirectToAction("notfound", "error");
            Clothe clothes = _context.Clothes
                .Include(i => i.ImageClothes)
                .Include(i=>i.Category)
                .Include(i=>i.Tag)
                .Include(i => i.ClotheInformation).FirstOrDefault(i => i.Id == id);
            if (id is null) return RedirectToAction("notfound", "error");


            List<Clothe> relatedClothes = _context.Clothes.Include(c=>c.ImageClothes).Include(c => c.Category).Where(c => c.CategoryId == clothes.CategoryId && c.Id!=id).ToList();

            ViewBag.Related = relatedClothes;
            ViewBag.Colors = _context.Colors.ToList();
            ViewBag.Sizes = _context.Sizes.ToList();
            ViewBag.Carousel = _context.Clothes
                .Include(c => c.ImageClothes).ToList();
            return View(clothes);
        }

        public async Task<IActionResult> Shop(int? id,string clicked)
        {
            if (id != null && id != 0)
            {
                Category category = await _context.Categories.Include(i => i.Clothe).ThenInclude(i =>i.ImageClothes).FirstOrDefaultAsync(c => c.Id == id);
                if (category != null)
                {
                    if (category.Clothe.Count()!=0)
                    {
                        return View(category.Clothe);
                    }
                    else
                    {
                        ViewBag.Message = "There is no Product in this category";
                        return View();
                    }
                }
                
                   
            }
            List<Clothe> clothes = await _context.Clothes.Include(c => c.ImageClothes).ToListAsync();

            if (!string.IsNullOrEmpty(clicked))
            {
                clothes = Sorting(clicked);
            }
            
            return View(clothes);
        }

        public  List<Clothe> Sorting(string clicked)
        {
            List<Clothe> clothes = new List<Clothe>();

            switch (clicked)
            {
                case "A-Z":
                   clothes= _context.Clothes.Include(c => c.ImageClothes).OrderBy(i=>i.Name).ToList();
                    break;
                case "Z-A":
                    clothes = _context.Clothes.Include(c => c.ImageClothes).OrderByDescending(i => i.Name).ToList();
                    break;
                case "Price":
                    clothes = _context.Clothes.Include(c => c.ImageClothes).OrderByDescending(i => i.Price).ToList();
                    break;
                default:
                    break;
            }
            return clothes;

        }


    }
}

