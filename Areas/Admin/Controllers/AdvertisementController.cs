using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineShop.DAL;
using OnlineShop.Models;
using OnlineShop.Utilities;


namespace OnlineShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdvertisementController : Controller
    {
        private readonly AppDbContext context;
        private readonly IWebHostEnvironment env;

        public AdvertisementController(AppDbContext context,IWebHostEnvironment env)
        {
            this.context = context;
            this.env = env;
        }


        public IActionResult Index()
        {
           List<Advertisement> adverts = context.Advertisements.ToList();
            return View(adverts);
        }

        public IActionResult Details(int? id)
        {
            if (id is null || id == 0) return RedirectToAction("notfound", "error", new { area = string.Empty });
            Advertisement advert =context.Advertisements.FirstOrDefault(i => i.Id == id);
            if (advert is null) return RedirectToAction("notfound", "error", new { area = string.Empty });

            return View(advert);
        }

        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Create(Advertisement advert)
        {
            if (!ModelState.IsValid) return View();
           
            if (advert.Photo is null)
            {
                ModelState.AddModelError("Photo", "Image is Required");
                return View();
            }
            if (!advert.Photo.ImageIsOkay(2))
            {
                ModelState.AddModelError("Photo", "Please choose valid Image");
                return View();
            }
            bool exist = context.Advertisements.Any(a => a.Order == advert.Order);
            if (exist)
            {
                ModelState.AddModelError("Order", "Already exist such Order");
                return View();
            }
            advert.Image = await advert.Photo.FileCreate(env.WebRootPath, "assets/img");

            context.Advertisements.Add(advert);
            await context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Update(int? id)
        {
            if (id is null || id == 0) return RedirectToAction("notfound", "error", new { area = string.Empty });
            Advertisement advertisement = context.Advertisements.FirstOrDefault(a => a.Id == id);
            if (advertisement is null) return NotFound();
            return View(advertisement);
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Update(int? id, Advertisement advertisement)
        {
            Advertisement advert = context.Advertisements.FirstOrDefault(a => a.Id == id);
            if (!ModelState.IsValid) return View(advert);

           
            if (advertisement.Photo is null)
            {
                string filename = advert.Image;
                context.Entry(advert).CurrentValues.SetValues(advertisement);
                advert.Image = filename;
                 context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }


             if (advertisement.Photo!=null && advertisement.Photo.ImageIsOkay(2))
             {
                context.Entry(advert).CurrentValues.SetValues(advertisement);
                advert.Image = await advertisement.Photo.FileCreate(env.WebRootPath, "assets/img");
                Methods.FileDelete(env.WebRootPath, "assets/img", advert.Image);
                await context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            else
            {
                ModelState.AddModelError("Photo", "Please Choose Valid Image");
                return View(advert);
            }
            
            
        }


        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0) return RedirectToAction("notfound", "error", new { area = string.Empty });
            Advertisement advert = context.Advertisements.FirstOrDefault(i => i.Id == id);
            if (advert is null) return RedirectToAction("notfound", "error", new { area = string.Empty });

            Methods.FileDelete(env.WebRootPath, "assets/img", advert.Image);
            context.Advertisements.Remove(advert);
            context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

    }
}