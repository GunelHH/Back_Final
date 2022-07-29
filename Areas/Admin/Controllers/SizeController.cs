using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OnlineShop.DAL;
using OnlineShop.Models;
using Size = OnlineShop.Models.Size;

namespace OnlineShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SizeController : Controller
    {
        private readonly AppDbContext context;

        public SizeController(AppDbContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            List<Size> sizes = context.Sizes.ToList();
            return View(sizes);
        }

        public IActionResult Details(int? id)
        {
            if (id is null || id == 0) return RedirectToAction("notfound", "error", new { area = string.Empty });
            Size size = context.Sizes.FirstOrDefault(i => i.Id == id);
            if (size is null) return RedirectToAction("notfound", "error", new { area = string.Empty });
            return View(size);
        }


        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult Create(Size size)
        {
            if (!ModelState.IsValid) return View();

            Size exist = context.Sizes.FirstOrDefault(i => i.Name.ToLower().Trim() == size.Name.Trim().ToLower());
            if (exist != null)
            {
                ModelState.AddModelError("Name", "Already has such Size");
                return View();
            }
            context.Sizes.Add(size);
            context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }


        public IActionResult Update(int? id)
        {
            if (id is null) return RedirectToAction("notfound", "error", new { area = string.Empty });
            Size size = context.Sizes.FirstOrDefault(i => i.Id == id);
            if (size is null) return RedirectToAction("notfound", "error", new { area = string.Empty });
            return View(size);
        }


        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult Update(int? id,Size NewSize)
        {
            Size exist = context.Sizes.FirstOrDefault(i => i.Id == id);
            if (exist is null) return RedirectToAction("notfound", "error", new { area = string.Empty });
            if (!ModelState.IsValid) return View(exist);

            Size sizeName = context.Sizes.FirstOrDefault(i => i.Name == NewSize.Name);
            if (sizeName != null && sizeName.Id != id)
            {
                ModelState.AddModelError("Name", "Already exist");
                return View(exist);
            }
            exist.Name = NewSize.Name;
            context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int? id)
        {
            if (id is null) return RedirectToAction("notfound", "error", new { area = string.Empty });
            Size size = context.Sizes.FirstOrDefault(i => i.Id == id);
            if (size is null) return RedirectToAction("notfound", "error", new { area = string.Empty });


            context.Sizes.Remove(size);
            context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
    }
}