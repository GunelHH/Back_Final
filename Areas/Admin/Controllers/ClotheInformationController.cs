using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineShop.DAL;
using OnlineShop.Models;

namespace OnlineShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class ClotheInformationController : Controller
    {
        private readonly AppDbContext context;

        public ClotheInformationController(AppDbContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            List<ClotheInformation> clothe = context.ClotheInformation.ToList();
            return View(clothe);
        }

        public IActionResult Details(int? id)
        {
            if (id is null || id == 0) return RedirectToAction("notfound", "error", new { area = string.Empty });
            ClotheInformation clothes = context.ClotheInformation.FirstOrDefault(i=>i.Id==id);
            if (clothes is null) return RedirectToAction("notfound", "error", new { area = string.Empty });
            return View(clothes);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Create(ClotheInformation inform)
        {
            if (!ModelState.IsValid) return View();

            ClotheInformation information = await context.ClotheInformation.FirstOrDefaultAsync(i=>i.Title==inform.Title);
            if (information!=null)
            {
                ModelState.AddModelError("Title", "Already has such title");
                return View();
            }
            context.ClotheInformation.Add(inform);
            await context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }


        public IActionResult Update(int? id)
        {
            if (id is null || id == 0) return RedirectToAction("notfound", "error", new { area = string.Empty });
            ClotheInformation inform = context.ClotheInformation.FirstOrDefault(i => i.Id == id);
            if (inform is null) return RedirectToAction("notfound", "error", new { area = string.Empty });
            return View(inform);
        }


        [HttpPost]
        [AutoValidateAntiforgeryToken]

        public async Task<IActionResult> Update(int? id,ClotheInformation inform)
        {
            ClotheInformation information = context.ClotheInformation.FirstOrDefault(i => i.Id == id);
            if (information==null) return RedirectToAction("notfound", "error", new { area = string.Empty });

            if (!ModelState.IsValid) return View(information);

            context.ClotheInformation.Add(information);
            await context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int? id)
        {
            if(id==null || id==0) return RedirectToAction("notfound", "error", new { area = string.Empty });
            ClotheInformation inform = context.ClotheInformation.FirstOrDefault(i => i.Id == id);
            if(inform is null) return RedirectToAction("notfound", "error", new { area = string.Empty });

            context.ClotheInformation.Remove(inform);
            context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
    }
}