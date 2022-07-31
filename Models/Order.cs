using System;
using System.Collections.Generic;
using OnlineShop.Models.Base;

namespace OnlineShop.Models
{
    public class Order:BaseEntity
    {
        public DateTime Date { get; set; }

        public decimal TotalPrice { get; set; }

        public List<BasketItem> BasketItems { get; set; }

        public string UserId { get; set; }

        public AppUser User { get; set; }

        public string Address { get; set; }
    }
}

