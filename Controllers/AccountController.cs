using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OnlineShop.ViewModels;

namespace OnlineShop.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Register()
        {
            return View();
        }

        //[HttpPost]
        //[AutoValidateAntiforgeryToken]

        //public async Task<IActionResult> Register(RegisterVM register)
        //{

        //    return View();
        //}

        //public IActionResult Login()
        //{
        //    return View();
        //}

        //Check Methods-------------


    }
}