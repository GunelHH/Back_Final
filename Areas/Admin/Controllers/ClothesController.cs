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
    public class ClothesController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment env;

        public ClothesController(AppDbContext context,IWebHostEnvironment env)
        {
            this._context = context;
            this.env = env;
        }
        public IActionResult Index()
        {
            
            List<Clothe> clothes = _context.Clothes.Include(i => i.Category)
                .Include(i => i.ClotheInformation).ThenInclude(i => i.Clothe)
                .Include(i => i.ImageClothes).Include(i => i.Tag).ToList();
            return View(clothes);
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id is null || id == 0)return RedirectToAction("notfound", "error");
            Clothe clothes = await _context.Clothes.Include(i => i.Category)
                .Include(i => i.ClotheInformation).ThenInclude(i=>i.Clothe)
                .Include(i => i.ImageClothes).Include(i => i.Tag).FirstOrDefaultAsync(i => i.Id == id);
            if(clothes is null) return RedirectToAction("notfound", "error");
            return View(clothes);
        }


        public IActionResult Create()
        {
            ViewBag.Categories = _context.Categories.ToList();
            ViewBag.Tags = _context.Tags.ToList();
            ViewBag.Informations = _context.ClotheInformation.ToList();
            return View();
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Create(Clothe clothes)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.Categories = _context.Categories.ToList();
                ViewBag.Tags = _context.Tags.ToList();
                ViewBag.Informations = _context.ClotheInformation.ToList();
                return View();
            } 

            if(clothes.MainImage is null && clothes.SecondaryImages is null)
            {
                ModelState.AddModelError(String.Empty, "You Must Choose one main and one another image");
                ViewBag.Categories = _context.Categories.ToList();
                ViewBag.Tags = _context.Tags.ToList();
                ViewBag.Informations = _context.ClotheInformation.ToList();
                return View();
            }

            if (!clothes.MainImage.ImageIsOkay(2))
            {
                ModelState.AddModelError("MainImage", "Please choose valid Image");
                ViewBag.Categories = _context.Categories.ToList();
                ViewBag.Tags = _context.Tags.ToList();
                ViewBag.Informations = _context.ClotheInformation.ToList();
                return View();
            }
            clothes.ImageClothes = new List<ImageClothe>();
            TempData["FileName"] = "";
            List<IFormFile> removable = new List<IFormFile>();
            foreach (var photo in clothes.SecondaryImages)
            {
                if (!photo.ImageIsOkay(2))
                {
                    removable.Add(photo);
                    TempData["FileName"] += photo.FileName + " ";
                    continue;
                }
                ImageClothe another = new ImageClothe
                {
                    Name = await photo.FileCreate(env.WebRootPath, "assets/img/products"),
                    IsMain = false,
                    Alternative = photo.Name,
                    Clothe = clothes,
                };
                clothes.ImageClothes.Add(another);
            }
            clothes.SecondaryImages.RemoveAll(i => removable.Any(r => r.FileName == i.FileName));
            ImageClothe MainImage = new ImageClothe
            {
                Name = await clothes.MainImage.FileCreate(env.WebRootPath, "assets/img/products"),
                IsMain=true,
                Alternative=clothes.Name,
                Clothe=clothes
            };
            clothes.ImageClothes.Add(MainImage);

            await _context.Clothes.AddAsync(clothes);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        //public static void Removable(List<IFormFile> removable,IFormFile image, int mb)
        //{
        //    if (!image.ImageIsOkay(mb))
        //    {
        //        removable.Add(image);
        //    }

        //}


        public IActionResult Update(int? id)
        {
            if (id is null || id == 0) return RedirectToAction("notfound", "error");
            Clothe clothes = _context.Clothes.FirstOrDefault(i=>i.Id==id);
            if (clothes is null) return RedirectToAction("notfound", "error");

            ViewBag.Categories = _context.Categories.ToList();
            ViewBag.Tags = _context.Tags.ToList();
            ViewBag.Informations = _context.ClotheInformation.ToList();

            return View(clothes);
        }

        //[HttpPost]
        //[AutoValidateAntiforgeryToken]
        //public async Task<IActionResult> Update(int? id,Clothe clothes)
        //{

        //}
    }
}