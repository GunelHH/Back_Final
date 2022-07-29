using System;
using OnlineShop.DAL;
using System.Collections.Generic;
using OnlineShop.Models;
using System.Linq;

namespace OnlineShop.Services
{
    public class LayoutService
    {
        private readonly AppDbContext _context;

        public LayoutService(AppDbContext context)
        {
            this._context = context;
        }

       public List<Setting> GetSettings()
        {
            List<Setting> settings = _context.Settings.ToList();
            return settings;
        }
        public List<Category> GetCategories()
        {
            List<Category> categories = _context.Categories.ToList();
            return categories;
        }

    }
}

