using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OnlineShop.DAL;
using OnlineShop.Models;

namespace OnlineShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class ColorController : Controller
    {
        private readonly AppDbContext context;

        public ColorController(AppDbContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            List<Color> colors = context.Colors.ToList();
            return View(colors);
        }

        public IActionResult Details(int? id)
        {
            if (id is null || id == 0) return RedirectToAction("notfound", "error", new { area = string.Empty });
            Color color = context.Colors.FirstOrDefault(i => i.Id == id);
            if (color is null) return RedirectToAction("notfound", "error", new { area = string.Empty });
            return View(color);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult Create(Color color)
        {
            if (!ModelState.IsValid) return View();

            Color exist = context.Colors.FirstOrDefault(i => i.Name.ToLower().Trim() == color.Name.Trim().ToLower());
            if (exist!=null)
            {
                ModelState.AddModelError("Name", "Already has such Color");
                return View();
            }

            Type colorType = typeof(System.Drawing.Color);

            PropertyInfo[] propInfoList = colorType.GetProperties(BindingFlags.Static | BindingFlags.DeclaredOnly | BindingFlags.Public);

                foreach (var c in propInfoList)
                {
                    if (color.Name.ToLower().Trim() == c.Name.Trim().ToLower())
                    {
                      context.Colors.Add(color);
                      context.SaveChanges();
                      return RedirectToAction(nameof(Index));
                    }

                }
            ModelState.AddModelError("Name", "No Such Color ");
            return View();
            
        }

        public IActionResult Update(int? id)
        {
           if(id is null) return RedirectToAction("notfound", "error", new { area = string.Empty });
           Color color=context.Colors.FirstOrDefault(i=>i.Id==id);
            if (color is null) return RedirectToAction("notfound", "error", new { area = string.Empty });
            return View(color);
        }


        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult Update(int? id, Color color)
        {
            Color exist = context.Colors.FirstOrDefault(i => i.Id == id);
            if (exist is null) return RedirectToAction("notfound", "error", new { area = string.Empty });
            if (!ModelState.IsValid) return View(exist);

            Color colorName = context.Colors.FirstOrDefault(i => i.Name == color.Name);
            if (colorName != null && colorName.Id != id)
            {
                ModelState.AddModelError("Name", "Already exist");
                return View(exist);
            }

            Type colorType = typeof(System.Drawing.Color);

            PropertyInfo[] propInfoList = colorType.GetProperties(BindingFlags.Static | BindingFlags.DeclaredOnly | BindingFlags.Public);

            foreach (var c in propInfoList)
            {
                if (color.Name.ToLower().Trim() == c.Name.Trim().ToLower())

                {
                    exist.Name = color.Name;

                    //context.Colors.Add(exist);
                    context.SaveChanges();
                    return RedirectToAction(nameof(Index));
                }

            }

            ModelState.AddModelError("Name", "No Such Color ");
            return View();

        }

        public IActionResult Delete(int? id)
        {
            if(id is null || id==0)  return RedirectToAction("notfound", "error", new { area = string.Empty });
            Color color = context.Colors.FirstOrDefault(i=>i.Id==id);
            if(color is null) return RedirectToAction("notfound", "error", new { area = string.Empty });

            context.Colors.Remove(color);
            context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

    }
}