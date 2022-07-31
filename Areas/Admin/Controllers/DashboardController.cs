using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OnlineShop.DAL;
using OnlineShop.Models;

namespace OnlineShop.Areas.Admin
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class DashboardController : Controller
    {
        private readonly AppDbContext context;

        public DashboardController(AppDbContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {  
            return View();
        }

        public IActionResult Message()
        {
            List<Message> messages = context.Messages.ToList();
            return View(messages);
        }

        public IActionResult Delete(int? id)
        {
            if(id !=null || id != 0)
            {
                Message exist = context.Messages.FirstOrDefault(m=>m.Id==id);
                if (exist is null) return RedirectToAction("notfound", "error", new { area = string.Empty });
                context.Messages.Remove(exist);
                context.SaveChanges();
                return RedirectToAction(nameof(Message));
            }
            return RedirectToAction("notfound", "error", new { area = string.Empty });
        }
      
    }

   
}