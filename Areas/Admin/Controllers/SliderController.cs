using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using OnlineShop.DAL;
using OnlineShop.Models;
using OnlineShop.Utilities;

namespace OnlineShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class SliderController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment env;

        public SliderController(AppDbContext context, IWebHostEnvironment env)
        {
            this._context = context;
            this.env = env;
        }
        public IActionResult Index()
        {
            List<Slider> sliders = _context.Sliders.ToList();
            return View(sliders);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Create(Slider slider)
        {
            if (!ModelState.IsValid) return View(ModelState);

            if (slider.Photo is null)
            {
                ModelState.AddModelError("Photo", "You must select at least one photo");
                return View();
            }
            if (!slider.Photo.ImageIsOkay(2))
            {
                ModelState.AddModelError("Photo", "Image Can be only be up to 2 MB");
                return View();
            }
            bool exist = _context.Sliders.Any(e => e.Order == slider.Order);
            if (exist)
            {
                ModelState.AddModelError("Order", "You already have such order");
                return View();
            }
            slider.Image = await slider.Photo.FileCreate(env.WebRootPath, "assets/img");

            await _context.Sliders.AddRangeAsync(slider);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }


        public IActionResult Update(int? id)
        {
            if (id is null || id == 0) return RedirectToAction("notfound", "error", new { area = string.Empty });
            Slider slider = _context.Sliders.FirstOrDefault(i => i.Id == id);
            if (slider is null) return RedirectToAction("notfound", "error", new { area = string.Empty });
            return View(slider);
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]

        public async Task<IActionResult> Update(int? id,Slider slider)
        {
            Slider existed = await _context.Sliders.FindAsync(id);
            if (existed is null) return RedirectToAction("notfound", "error", new { area = string.Empty });
            if (!ModelState.IsValid) return View(existed);

            if (slider.Photo is null)
            {
                string image = existed.Image;
                _context.Entry(existed).CurrentValues.SetValues(slider);
                existed.Image = image;
            }
            else
            {
                if (!slider.Photo.ImageIsOkay(2))
                {
                    ModelState.AddModelError("Photo", "Aaa!!! Image is over 2MB");
                    return View(existed);
                }
                Methods.FileDelete(env.WebRootPath, "assets/img", existed.Image);
                _context.Entry(existed).CurrentValues.SetValues(slider);
                existed.Image = await slider.Photo.FileCreate(env.WebRootPath, "assets/img");
            }
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Delete(int? id)
        {
            if (id is null || id == 0) return RedirectToAction("notfound", "error", new { area = string.Empty });
            Slider slider = _context.Sliders.FirstOrDefault(i => i.Id == id);
            if (slider is null) return RedirectToAction("notfound", "error", new { area = string.Empty });

            Methods.FileDelete(env.WebRootPath, "assets/img", slider.Image);

            _context.Sliders.Remove(slider);
            await _context.SaveChangesAsync();

          
            return RedirectToAction(nameof(Index));

        }

        public IActionResult Details(int? id)
        {
            if (id is null || id == 0) return RedirectToAction("notfound", "error", new { area = string.Empty });
            Slider slider = _context.Sliders.FirstOrDefault(i => i.Id == id);
            if (slider is null) return RedirectToAction("notfound", "error", new { area = string.Empty });

            return View(slider);
        }   
}   }