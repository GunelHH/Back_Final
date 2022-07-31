using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using OnlineShop.DAL;
using OnlineShop.Models;

namespace OnlineShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles ="Admin")]
    
    public class AppUserController : Controller
    {
        private readonly AppDbContext context;
        private readonly UserManager<AppUser> userManager;

        public AppUserController(AppDbContext context,UserManager<AppUser> userManager)
        {
            this.context = context;
            this.userManager = userManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        //[HttpPost]
        //[AutoValidateAntiforgeryToken]
        //public async Task<IActionResult> Create(AppUser Newuser)
        //{
        //    if (!ModelState.IsValid) return View();
        //    AppUser exist = await userManager.FindByEmailAsync(Newuser.Email);
        //    if (exist != null)
        //    {
        //        ModelState.AddModelError("Email", "Already registered with this email");
        //        return View();
        //    }
        //    if (Newuser.UserName == exist.UserName)
        //    {
        //        ModelState.AddModelError("UserName", "Username must be unique");
        //        return View();
        //    }
        //    IdentityUser user=
        //}
    }
}