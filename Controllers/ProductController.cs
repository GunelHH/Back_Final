using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineShop.DAL;
using OnlineShop.Models;

namespace OnlineShop.Controllers
{
    public class ProductController:Controller
    {
        private readonly AppDbContext _context;

        public ProductController(AppDbContext context)
        {
            this._context = context;
        }
        public IActionResult Detail(int? id)
        {
            if (id is null || id == 0) return RedirectToAction("notfound", "error");
           Clothe    clothes=_context.Clothes.Include(i=>i.ImageClothes).Include(i=>i.ClotheInformation).FirstOrDefault(i=>i.Id==id);
            if (id is null) return RedirectToAction("notfound", "error");

            ViewBag.Clothes = _context.Clothes.Include(i=>i.ImageClothes).ToList();
            return View(clothes);
        }

        public  async Task<IActionResult> Shop(int? id)
        {
            if (id is null || id == 0) return RedirectToAction("notfound", "error");
            Category category =await _context.Categories.Include(i=>i.Clothe).FirstOrDefaultAsync(i => i.Id == id);
            if(category is null) return RedirectToAction("notfound", "error");

            return View(category.Clothe);
        }
    }
}

