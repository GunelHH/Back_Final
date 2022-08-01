using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using OnlineShop.DAL;
using OnlineShop.Models;
using OnlineShop.ViewModels.Basket;

namespace OnlineShop.Services
{
    public class CartCheckOutService
    {
        private readonly AppDbContext _context;
        private readonly IHttpContextAccessor http;

        public CartCheckOutService(AppDbContext context, IHttpContextAccessor http)
        {
            this._context = context;
            this.http = http;
        }

        
    }
}

