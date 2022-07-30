using System;
using OnlineShop.Models.Base;

namespace OnlineShop.Models
{
    public class BasketItem:BaseEntity
    {
        public string UserId { get; set; }

        public AppUser User { get; set; }

        public int ClotheId { get; set; }

        public Clothe Clothes { get; set; }

        public decimal Price { get; set; }

        public int Quantity { get; set; }

        public string Color { get; set; }

        public string Size { get; set; }


    }
}

