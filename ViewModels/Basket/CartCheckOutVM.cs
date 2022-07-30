using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using OnlineShop.DAL;
using OnlineShop.Models;

namespace OnlineShop.ViewModels.Basket
{
    public class CartCheckOutVM
    {

        public List<CartItemVM> CartItemVms { get; set; }

        public decimal TotalPrice { get; set; }
       
    }
}


