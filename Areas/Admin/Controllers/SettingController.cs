using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OnlineShop.DAL;
using OnlineShop.Models;

namespace OnlineShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SettingController : Controller
    {
        private readonly AppDbContext context;

        public SettingController(AppDbContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            List<Setting> settings = context.Settings.ToList();
            return View(settings);
        }

        public IActionResult Details(int? id)
        {
            if (id is null || id == 0) return RedirectToAction("notfound", "error", new { area = string.Empty });
            Setting setting = context.Settings.FirstOrDefault(i => i.Id == id);
            if (setting is null) return RedirectToAction("notfound", "error", new { area = string.Empty });
            return View(setting);
        }

        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult Create(Setting set)
        {
            if (!ModelState.IsValid) return View();

            //Setting exist = context.Settings.FirstOrDefault(i => i.Key.ToLower().Trim() == set.Key.Trim().ToLower());
            //if (exist != null)
            //{
            //    ModelState.AddModelError("Name", "Already has such Tag");
            //    return View();
            //}
            context.Settings.Add(set);
            context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Update(int? id)
        {
            if (id is null) return RedirectToAction("notfound", "error", new { area = string.Empty });
            Setting setting = context.Settings.FirstOrDefault(i => i.Id == id);
            if (setting is null) return RedirectToAction("notfound", "error", new { area = string.Empty });
            return View(setting);
        }


        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult Update(int? id, Setting set)
        {
            Setting exist = context.Settings.FirstOrDefault(i => i.Id == id);
            if (exist is null) return RedirectToAction("notfound", "error", new { area = string.Empty });
            if (!ModelState.IsValid) return View(exist);


            context.Entry(exist).CurrentValues.SetValues(set);
            context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }


        public IActionResult Delete(int? id)
        {
            if (id is null) return RedirectToAction("notfound", "error", new { area = string.Empty });
            Setting set = context.Settings.FirstOrDefault(i => i.Id == id);
            if (set is null) return RedirectToAction("notfound", "error", new { area = string.Empty });


            context.Settings.Remove(set);
            context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }


    }
}