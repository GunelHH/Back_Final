using System;
using System.Collections.Generic;
using OnlineShop.Models;

namespace OnlineShop.ViewModels.Basket
{
    public class BasketVM
    {
        public List<BasketCookieItemVM> BasketCookieItemVMs { get; set; }

        public decimal TotalPrice { get; set; }
    }
}

