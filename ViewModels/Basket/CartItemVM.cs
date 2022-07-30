using System;
using OnlineShop.Models;

namespace OnlineShop.ViewModels.Basket
{
    public class CartItemVM
    {
        public Clothe clothes { get; set; }

        public int Quantity { get; set; }

        public decimal TotalPrice { get; set; }

        public int ClothesId { get; set; }
    }
}

