using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineShop.DAL;
using OnlineShop.Models;
using System.Linq;
using System.Threading.Tasks;
using OnlineShop.ViewModels;
using Microsoft.AspNetCore.Identity;

namespace OnlineShop.Controllers
{
    public class HomeController:Controller
    {
        private readonly AppDbContext _context;
        private readonly Microsoft.AspNetCore.Identity.UserManager<AppUser> userManager;

        public HomeController(AppDbContext context,UserManager<AppUser> userManager)
        {
            this._context = context;
            this.userManager = userManager;
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
            ViewBag.Setting = _context.Settings.ToList();
            return View();
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Contact(Message message)
        {
            if (User.Identity.IsAuthenticated)
            {
                if (!ModelState.IsValid) return View();
                AppUser user = await userManager.FindByEmailAsync(message.Email);

                if (user==null)
                {
                    return RedirectToAction("notfound", "error");
                }
                else
                {
                    Message newMessage = new Message
                    {
                        Name = message.Name,
                        Email = message.Email,
                        Subject = message.Subject,
                        Body = message.Body
                    };
                    _context.Messages.Add(newMessage);
                    await _context.SaveChangesAsync();
                    ViewBag.Message = "Your message has been sent successfully";
                    ViewBag.Setting = _context.Settings.ToList();
                    return View();
                }

               
            }
            
                ModelState.AddModelError("", "Please Firstly Sign in or  Sign Up");
            ViewBag.Setting = _context.Settings.ToList();
            return View();
        }
    }
}

