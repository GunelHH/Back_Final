using System;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Collections.Generic;
using OnlineShop.DAL;
using OnlineShop.Models;
using System.Linq;

namespace OnlineShop.ViewModels.Basket
{
    public class ItemViewVM
    {
        private readonly AppDbContext context;
        private readonly HttpContextAccessor http;

        public CartCheckOutVM cartCheckOut { get; set; }

        public ItemViewVM(AppDbContext context,HttpContextAccessor http)
        {
            this.context = context;
            this.http = http;
        }

    }
}

