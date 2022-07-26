using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineShop.DAL;
using OnlineShop.Models;
using System.Linq;
using System.Threading.Tasks;
using OnlineShop.ViewModels;

namespace OnlineShop.Controllers
{
    public class HomeController:Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            this._context = context;
        }
       public async Task<IActionResult> Index()
        {
            HomeVM homeVM = new HomeVM
            {
                sliders = await _context.Sliders.ToListAsync(),
                Advertisements = await _context.Advertisements.ToListAsync(),
                clothe = await _context.Clothes.Include(i => i.Category)
                .Include(i => i.ClotheInformation).Include(i => i.ImageClothes).Include(i => i.Tag).ToListAsync(),
                Categories = await _context.Categories.Include(i => i.Clothe).ToListAsync(),
            };       
            return View(homeVM);
        }

        public async Task<IActionResult> Shop()
        {
            List<Clothe> clothes =await _context.Clothes.Include(i => i.Category)
                .Include(i => i.ClotheInformation).Include(i => i.ImageClothes).Include(i => i.Tag).ToListAsync();
            return View(clothes);
        }

        public IActionResult Contact()
        {
            return View();
        }
    }
}

