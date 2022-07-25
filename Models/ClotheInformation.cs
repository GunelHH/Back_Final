using System;
using System.Collections.Generic;
using OnlineShop.Models.Base;

namespace OnlineShop.Models
{
    public class ClotheInformation:BaseEntity
    {
        public List<Clothe> Clothes { get; set; }
    }
}

