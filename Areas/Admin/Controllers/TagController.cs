using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OnlineShop.DAL;
using OnlineShop.Models;

namespace OnlineShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class TagController : Controller
    {
        private readonly AppDbContext context;

        public TagController(AppDbContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            List<Tag> tags = context.Tags.ToList();
            return View(tags);
        }


        public IActionResult Details(int? id)
        {
            if(id is null || id == 0) return RedirectToAction("notfound", "error", new { area = string.Empty });
            Tag tag = context.Tags.FirstOrDefault(i => i.Id == id);
            if (tag is null) return RedirectToAction("notfound", "error", new { area = string.Empty });
            return View(tag);
        }


        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult Create(Tag tag)
        {
            if (!ModelState.IsValid) return View();

            Tag exist = context.Tags.FirstOrDefault(i => i.Name.ToLower().Trim() == tag.Name.Trim().ToLower());
            if (exist != null)
            {
                ModelState.AddModelError("Name", "Already has such Tag");
                return View();
            }
            context.Tags.Add(tag);
            context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Update(int? id)
        {
            if (id is null) return RedirectToAction("notfound", "error", new { area = string.Empty });
            Tag tag = context.Tags.FirstOrDefault(i => i.Id == id);
            if (tag is null) return RedirectToAction("notfound", "error", new { area = string.Empty });
            return View(tag);
        }


        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult Update(int? id, Tag Newtag)
        {
            Tag exist = context.Tags.FirstOrDefault(i => i.Id == id);
            if (exist is null) return RedirectToAction("notfound", "error", new { area = string.Empty });
            if (!ModelState.IsValid) return View(exist);

            Tag tagName = context.Tags.FirstOrDefault(i => i.Name == Newtag.Name);
            if (tagName != null && tagName.Id != id)
            {
                ModelState.AddModelError("Name", "Already exist");
                return View(exist);
            }
            exist.Name = Newtag.Name;
            context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }


        public IActionResult Delete(int? id)
        {
            if (id is null) return RedirectToAction("notfound", "error", new { area = string.Empty });
            Tag tag = context.Tags.FirstOrDefault(i => i.Id == id);
            if (tag is null) return RedirectToAction("notfound", "error", new { area = string.Empty });


            context.Tags.Remove(tag);
            context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
    }
}