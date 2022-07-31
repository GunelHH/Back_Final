using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineShop.DAL;
using OnlineShop.Models;
using OnlineShop.Utilities;

namespace OnlineShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class CategoryController : Controller
    {
        private readonly AppDbContext context;
        private readonly IWebHostEnvironment env;

        public CategoryController(AppDbContext context,IWebHostEnvironment env)
        {
            this.context = context;
            this.env = env;
        }
        public IActionResult Index()
        {
            List<Category> categories = context.Categories.ToList();
            return View(categories);
        }

        public IActionResult Details(int? id)
        {
            if(id is null || id==0) return RedirectToAction("notfound", "error", new { area = string.Empty });
            Category category = context.Categories.FirstOrDefault(i => i.Id == id);
            if(category is null)return RedirectToAction("notfound", "error", new { area = string.Empty });
            return View(category);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Create(Category category)
        {
            if (!ModelState.IsValid) return View();

            if (category.Photo is null)
            {
                ModelState.AddModelError("Photo", "You forgot to select image");
                return View();
            }
            if (!category.Photo.ImageIsOkay(2))
            {
                ModelState.AddModelError("Photo", "Please choose valid Image");
                return View();
            }
            Category existed = context.Categories.FirstOrDefault(c => c.Name.ToLower().Trim() == category.Name.ToLower().Trim());
            if (existed != null)
            {
                ModelState.AddModelError("Name", "Already exist such category");
                return View();
            }

            category.Image =await category.Photo.FileCreate(env.WebRootPath, "assets/img/products");
            context.Categories.Add(category);
            context.SaveChanges();
            return RedirectToAction(nameof(Index));

        }

        public IActionResult Update(int? id)
        {
            if (id is null || id == 0) return RedirectToAction("notfound", "error", new { area = string.Empty });
            Category category = context.Categories.FirstOrDefault(i => i.Id == id);
            if (category is null) return RedirectToAction("notfound", "error", new { area = string.Empty });
            return View(category);
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]

        public async Task<IActionResult> Update(int? id,Category newCategory)
        {
             Category category = context.Categories.FirstOrDefault(c => c.Id == id);
            if (category is null) return RedirectToAction("notfound", "error", new { area = string.Empty });
            Category ExistName = context.Categories.FirstOrDefault(c => c.Name == newCategory.Name);
            if (newCategory.Photo is null)
            {
                if (!ModelState.IsValid) return View(category);
                if (Methods.CheckCategory(id, ExistName))
                {
                    ModelState.AddModelError("Name", "The category is already exist!");
                    return View(category);
                }

                string ImageFile = category.Image;
                context.Entry(category).CurrentValues.SetValues(newCategory);
                category.Image = ImageFile;
                context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
           
            if (!ModelState.IsValid) return View(category);
            if (!newCategory.Photo.ImageIsOkay(2))
            {
                ModelState.AddModelError("Photo", "Please choose valid Image");
                return View(category);
            } 
            if (Methods.CheckCategory(id,ExistName))
            {
                ModelState.AddModelError("Name", "The category is already exist!");
                return View(category);
            }
           
            Methods.FileDelete(env.WebRootPath, "assets/img/products", category.Image);

            context.Entry(category).CurrentValues.SetValues(newCategory);
            category.Image = await newCategory.Photo.FileCreate(env.WebRootPath, "assets/img/products");
            context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }




        public async Task<IActionResult> Delete(int? id)
        {
            if (id is null || id == 0) return RedirectToAction("notfound", "error", new { area = string.Empty });

            Category category = await context.Categories.FindAsync(id);
            if (category is null) return RedirectToAction("notfound", "error", new { area = string.Empty });

            Methods.FileDelete(env.WebRootPath, "assets/img/products", category.Image);

            context.Categories.Remove(category);
            await context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}