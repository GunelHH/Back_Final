using System;
using System.Collections.Generic;
using OnlineShop.Models;

namespace OnlineShop.ViewModels
{
    public class HomeVM
    {
        public List<Advertisement> Advertisements { get; set; }

        public List<Slider> sliders { get; set; }

        public List<Category> Categories { get; set; }

        public List<Clothe> clothe { get; set; }


    }
}

